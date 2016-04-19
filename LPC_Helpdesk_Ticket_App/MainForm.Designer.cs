namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.requiredLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.MainWebBrowser = new System.Windows.Forms.WebBrowser();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.requiredLabel);
            this.panel1.Controls.Add(this.descLabel);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.dueDateLabel);
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.MainWebBrowser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 640);
            this.panel1.TabIndex = 0;
            // 
            // requiredLabel
            // 
            this.requiredLabel.AutoSize = true;
            this.requiredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredLabel.ForeColor = System.Drawing.Color.Red;
            this.requiredLabel.Location = new System.Drawing.Point(20, 160);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.Size = new System.Drawing.Size(94, 13);
            this.requiredLabel.TabIndex = 13;
            this.requiredLabel.Text = "*Required Field";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(19, 399);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(97, 13);
            this.descLabel.TabIndex = 12;
            this.descLabel.Text = "Ticket Description*";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(52, 347);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(64, 13);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Ticket Title*";
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Location = new System.Drawing.Point(63, 290);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(53, 13);
            this.dueDateLabel.TabIndex = 10;
            this.dueDateLabel.Text = "Due Date";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(63, 240);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(53, 13);
            this.categoryLabel.TabIndex = 9;
            this.categoryLabel.Text = "Category*";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(11, 193);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(105, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Your Email (Optional)";
            // 
            // MainWebBrowser
            // 
            this.MainWebBrowser.AllowWebBrowserDrop = false;
            this.MainWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainWebBrowser.Location = new System.Drawing.Point(122, 12);
            this.MainWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.MainWebBrowser.Name = "MainWebBrowser";
            this.MainWebBrowser.ScriptErrorsSuppressed = true;
            this.MainWebBrowser.ScrollBarsEnabled = false;
            this.MainWebBrowser.Size = new System.Drawing.Size(652, 616);
            this.MainWebBrowser.TabIndex = 7;
            this.MainWebBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.MainWebBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 640);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "LPC Helpdesk Ticket Submission";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label requiredLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.WebBrowser MainWebBrowser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

