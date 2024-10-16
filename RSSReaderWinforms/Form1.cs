using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;

namespace RSSReaderApp
{
    public partial class MainForm : Form
    {
        private List<SyndicationFeed> feeds;

        public MainForm()
        {
            InitializeComponent();
            feeds = new List<SyndicationFeed>();
        }

        private void btnAddFeed_Click(object sender, EventArgs e)
        {
            string url = txtFeedUrl.Text.Trim();
            if (!string.IsNullOrEmpty(url))
            {
                LoadFeed(url);
            }
        }

        private void LoadFeed(string url)
        {
            try
            {
                using (XmlReader reader = XmlReader.Create(url))
                {
                    SyndicationFeed feed = SyndicationFeed.Load(reader);
                    feeds.Add(feed);
                    lstFeeds.Items.Add(feed.Title.Text);
                    txtFeedUrl.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке RSS-ленты: " + ex.Message);
            }
        }

        private void lstFeeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFeeds.SelectedIndex >= 0)
            {
                var feed = feeds[lstFeeds.SelectedIndex];
                DisplayFeedItems(feed);
            }
        }

        private void DisplayFeedItems(SyndicationFeed feed)
        {
            txtNewsContent.Clear();
            foreach (var item in feed.Items)
            {
                txtNewsContent.AppendText(item.Title.Text + Environment.NewLine);
            }
        }
    }
}
