namespace WkwkReportDeveloper
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.browser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.txtReportID = new System.Windows.Forms.TextBox();
            this.lblReportID = new System.Windows.Forms.Label();
            this.lblDataXML = new System.Windows.Forms.Label();
            this.txtDataXML = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 523);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnReload);
            this.splitContainer1.Panel1.Controls.Add(this.lblDataXML);
            this.splitContainer1.Panel1.Controls.Add(this.txtDataXML);
            this.splitContainer1.Panel1.Controls.Add(this.lblReportID);
            this.splitContainer1.Panel1.Controls.Add(this.txtReportID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.browser);
            this.splitContainer1.Size = new System.Drawing.Size(1018, 523);
            this.splitContainer1.SplitterDistance = 512;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // browser
            // 
            this.browser.ActivateBrowserOnCreation = false;
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 0);
            this.browser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(501, 523);
            this.browser.TabIndex = 0;
            // 
            // txtReportID
            // 
            this.txtReportID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReportID.Location = new System.Drawing.Point(89, 12);
            this.txtReportID.Name = "txtReportID";
            this.txtReportID.Size = new System.Drawing.Size(397, 27);
            this.txtReportID.TabIndex = 0;
            // 
            // lblReportID
            // 
            this.lblReportID.AutoSize = true;
            this.lblReportID.Location = new System.Drawing.Point(13, 23);
            this.lblReportID.Name = "lblReportID";
            this.lblReportID.Size = new System.Drawing.Size(45, 16);
            this.lblReportID.TabIndex = 1;
            this.lblReportID.Text = "帳票ID";
            // 
            // lblDataXML
            // 
            this.lblDataXML.AutoSize = true;
            this.lblDataXML.Location = new System.Drawing.Point(13, 56);
            this.lblDataXML.Name = "lblDataXML";
            this.lblDataXML.Size = new System.Drawing.Size(70, 16);
            this.lblDataXML.TabIndex = 3;
            this.lblDataXML.Text = "データXML";
            // 
            // txtDataXML
            // 
            this.txtDataXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataXML.Location = new System.Drawing.Point(89, 45);
            this.txtDataXML.Name = "txtDataXML";
            this.txtDataXML.Size = new System.Drawing.Size(397, 27);
            this.txtDataXML.TabIndex = 2;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(411, 78);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "更新";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 523);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帳票エディタ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private CefSharp.WinForms.ChromiumWebBrowser browser;
        private System.Windows.Forms.Label lblDataXML;
        private System.Windows.Forms.TextBox txtDataXML;
        private System.Windows.Forms.Label lblReportID;
        private System.Windows.Forms.TextBox txtReportID;
        private System.Windows.Forms.Button btnReload;
    }
}

