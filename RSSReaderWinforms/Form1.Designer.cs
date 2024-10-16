namespace RSSReaderApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFeedUrl = new System.Windows.Forms.TextBox();
            this.btnAddFeed = new System.Windows.Forms.Button();
            this.lstFeeds = new System.Windows.Forms.ListBox();
            this.txtNewsContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtFeedUrl
            // 
            this.txtFeedUrl.Location = new System.Drawing.Point(12, 12);
            this.txtFeedUrl.Name = "txtFeedUrl";
            this.txtFeedUrl.Size = new System.Drawing.Size(300, 20);
            this.txtFeedUrl.TabIndex = 0;
            // 
            // btnAddFeed
            // 
            this.btnAddFeed.Location = new System.Drawing.Point(318, 10);
            this.btnAddFeed.Name = "btnAddFeed";
            this.btnAddFeed.Size = new System.Drawing.Size(75, 23);
            this.btnAddFeed.TabIndex = 1;
            this.btnAddFeed.Text = "Добавить";
            this.btnAddFeed.UseVisualStyleBackColor = true;
            this.btnAddFeed.Click += new System.EventHandler(this.btnAddFeed_Click);
            // 
            // lstFeeds
            // 
            this.lstFeeds.FormattingEnabled = true;
            this.lstFeeds.Location = new System.Drawing.Point(12, 38);
            this.lstFeeds.Name = "lstFeeds";
            this.lstFeeds.Size = new System.Drawing.Size(381, 95);
            this.lstFeeds.TabIndex = 2;
            this.lstFeeds.SelectedIndexChanged += new System.EventHandler(this.lstFeeds_SelectedIndexChanged);
            // 
            // txtNewsContent
            // 
            this.txtNewsContent.Location = new System.Drawing.Point(12, 139);
            this.txtNewsContent.Name = "txtNewsContent";
            this.txtNewsContent.Size = new System.Drawing.Size(381, 200);
            this.txtNewsContent.TabIndex = 3;
            this.txtNewsContent.Text = "";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(404, 351);
            this.Controls.Add(this.txtNewsContent);
            this.Controls.Add(this.lstFeeds);
            this.Controls.Add(this.btnAddFeed);
            this.Controls.Add(this.txtFeedUrl);
            this.Name = "MainForm";
            this.Text = "RSS Reader";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtFeedUrl;
        private System.Windows.Forms.Button btnAddFeed;
        private System.Windows.Forms.ListBox lstFeeds;
        private System.Windows.Forms.RichTextBox txtNewsContent;
    }
}
