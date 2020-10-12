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
    class urlstates
    {
        public string Urlorder { get; set; }
        public bool process { get; set; }
        public string html { get; set; }
    }
    class Crawler
    {
        public event Action<Crawler, urlstates> PageDownloaded;
        public ConcurrentBag<urlstates> urls = new ConcurrentBag<urlstates>();
        public int count = 0;
        static public string startUrl = "";
        static public string starHtml = "";

        public void Crawl()
        {
            urlstates surl = new urlstates() { Urlorder = startUrl, process = false, html = "" };
            urls.Add(surl);

            string str = @"(www\.){0,1}.*?\..*?/";
            Regex r = new Regex(str);
            Match m = r.Match(startUrl);
            starHtml = m.Value;

            while (true)
            {
                urlstates current = null;
                foreach (var url in urls)
                {
                    if (url.process) continue;
                    current = url;
                    if (count > 15)
                        break;
                    if (current == null)
                        continue;
                    current.process = true;
                    var t = new Thread(() => Process(current));
                    t.Start();
                    count++;
                }
            }
        }

        public bool UrlExsists(string url)
        {
            foreach (urlstates u in urls)
            {
                if (u.Urlorder == url)
                    return true;
            }
            return false;
        }


        public void Process(urlstates url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url.Urlorder);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                url.html = html;
                PageDownloaded(this, url);
                Parse(html, url.Urlorder);//解析,并加入新的链接
            }
            catch (Exception)
            {

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
                if (url.Contains(starHtml))
                {
                    if (!UrlExsists(url))
                    {
                        urls.Add(new urlstates() { Urlorder = url, process = false, html = "" });
                    }
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
                if (!UrlExsists(url))
                {
                    urls.Add(new urlstates() { Urlorder = url, process = false, html = "" });
                }
            }
        }
    }
}