using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCrawler;


namespace frmParallelCrawl
{
    public partial class frmParallelCrawl : Form
    {
        BindingSource UrlBindingSource = new BindingSource();
        Crawler crawler = new Crawler();
        Thread thread = null;
        public frmParallelCrawl()
        {
            InitializeComponent();
            UrlGridView.DataSource = UrlBindingSource;
            crawler.PageDownloaded += PageDownloaded;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            UrlBindingSource.Clear();
            crawler.urls = new ConcurrentBag<urlstates>();
            crawler.count = 0;
            Crawler.startUrl = txtURL.Text;
            
            if (thread != null)
            {
                thread.Abort();
            }

            thread = new Thread(crawler.Crawl);
            thread.Start();
        }
        private void PageDownloaded(Crawler crawler, urlstates url)
        {
            lock (UrlBindingSource)
            {
                var pageInfo = new { Index = UrlBindingSource.Count + 1, URL = url.Urlorder };
                Action action = () => { UrlBindingSource.Add(pageInfo); };
                if (this.InvokeRequired)
                {
                    this.Invoke(action);
                }
                else
                {
                    action();
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null)  thread.Abort();
        }
    }
}
