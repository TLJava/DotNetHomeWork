using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using System.Net;
using System.IO;
using System.Threading;
using System.Collections.Concurrent;

namespace SimpleCrawler
{
    class Crawler
    {
        public event Action<Crawler, string> PageDownloaded;
        public Hashtable urls = new Hashtable();
        public int count = 0;
        static public string startUrl = "";
        static public string starHtml = "";
        
        public void Crawl()
        {
            string str = @"(www\.){0,1}.*?\..*?/";
            Regex r = new Regex(str);
            Match m = r.Match(startUrl);
            starHtml = m.Value;
            
            while (true)
            {
                string current = null;   //找出一个没有下载过的网页
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 15) break;
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                PageDownloaded(this, current);
                Parse(html, current);//解析,并加入新的链接
                
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        //解析
        private void Parse(string html, string oldUrl)
        {
            //匹配不含相对路径,且包含html的网址
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'](http|https)[^""'#>]+..html.*?[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {//删掉首尾包含的括号中的字符
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0)
                    continue;
                //仅包含起始网站上的网页
                if (url.Contains("starHtml"))
                {
                    if (urls[url] == null)
                        urls[url] = false;
                }
            }

            //匹配相对路径,且包含html的网址

            strRef = @"(href|HREF)[ ]*=[ ]*[""'][^(http|https)][^""'#>]+..html.*?[""']";
            matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0) continue;
                Uri baseUri = new Uri(oldUrl);
                Uri absoluteUri = new Uri(baseUri, url);
                Console.WriteLine("相对路径:" + url);
                Console.WriteLine("绝对路径:" + absoluteUri.ToString());
                if (urls[absoluteUri.ToString()] == null)
                    urls[absoluteUri.ToString()] = false;
            }
        }
    }
}