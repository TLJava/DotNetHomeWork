using SimpleCrawler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace FrmCrawler
{
    public partial class frmCrawler : Form
    {
        BindingSource UrlbindingSource = new BindingSource();
        Crawler crawler = new Crawler();
        Thread thread = null;
        public frmCrawler()
        {
            InitializeComponent();
            URLGridView.DataSource = UrlbindingSource;
            crawler.PageDownloaded += PageDownloaded;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            UrlbindingSource.Clear();
            Crawler.startUrl = txtURL.Text;

            if (thread != null)  thread.Abort();
            crawler.urls.Add(Crawler.startUrl,false); 
            thread = new Thread(crawler.Crawl);
            thread.Start();
        }

        private void PageDownloaded(Crawler crawler, string url)
        {
            var pageInfo = new { Index = UrlbindingSource.Count + 1, URL = url };
            Action action = () => { UrlbindingSource.Add(pageInfo); };
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
}
