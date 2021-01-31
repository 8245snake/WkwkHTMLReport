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
            this.lblReportID = new System.Windows.Forms.Label();
            this.lblDataXML = new System.Windows.Forms.Label();
            this.txtDataXML = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDevTool = new System.Windows.Forms.Button();
            this.btnSettingReload = new System.Windows.Forms.Button();
            this.btnSaveAndReload = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tabSetting = new System.Windows.Forms.TabControl();
            this.pagePatternSetting = new System.Windows.Forms.TabPage();
            this.pageDataXML = new System.Windows.Forms.TabPage();
            this.txtEditReportID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLayoutPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartialPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataXMLEdit = new System.Windows.Forms.TextBox();
            this.pageLayoutXML = new System.Windows.Forms.TabPage();
            this.txtLayoutEdit = new System.Windows.Forms.TextBox();
            this.combReportID = new System.Windows.Forms.ComboBox();
            this.linkLayoutXML = new System.Windows.Forms.LinkLabel();
            this.linkDataXML = new System.Windows.Forms.LinkLabel();
            this.btnPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.pagePatternSetting.SuspendLayout();
            this.pageDataXML.SuspendLayout();
            this.pageLayoutXML.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 775);
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
            this.splitContainer1.Panel1.Controls.Add(this.combReportID);
            this.splitContainer1.Panel1.Controls.Add(this.tabSetting);
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveAndReload);
            this.splitContainer1.Panel1.Controls.Add(this.btnSettingReload);
            this.splitContainer1.Panel1.Controls.Add(this.lblDataXML);
            this.splitContainer1.Panel1.Controls.Add(this.txtDataXML);
            this.splitContainer1.Panel1.Controls.Add(this.lblReportID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnPDF);
            this.splitContainer1.Panel2.Controls.Add(this.btnPrint);
            this.splitContainer1.Panel2.Controls.Add(this.btnDevTool);
            this.splitContainer1.Panel2.Controls.Add(this.btnReload);
            this.splitContainer1.Panel2.Controls.Add(this.browser);
            this.splitContainer1.Size = new System.Drawing.Size(1334, 775);
            this.splitContainer1.SplitterDistance = 670;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // browser
            // 
            this.browser.ActivateBrowserOnCreation = false;
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(3, 56);
            this.browser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(656, 719);
            this.browser.TabIndex = 0;
            // 
            // lblReportID
            // 
            this.lblReportID.AutoSize = true;
            this.lblReportID.Location = new System.Drawing.Point(13, 23);
            this.lblReportID.Name = "lblReportID";
            this.lblReportID.Size = new System.Drawing.Size(68, 16);
            this.lblReportID.TabIndex = 1;
            this.lblReportID.Text = "帳票識別子";
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
            this.txtDataXML.AllowDrop = true;
            this.txtDataXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataXML.Location = new System.Drawing.Point(89, 49);
            this.txtDataXML.Name = "txtDataXML";
            this.txtDataXML.Size = new System.Drawing.Size(555, 27);
            this.txtDataXML.TabIndex = 2;
            this.txtDataXML.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtDataXML_DragDrop);
            this.txtDataXML.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtDataXML_DragEnter);
            this.txtDataXML.Validated += new System.EventHandler(this.txtDataXML_Validated);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(475, 23);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "更新";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDevTool
            // 
            this.btnDevTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevTool.Location = new System.Drawing.Point(556, 23);
            this.btnDevTool.Name = "btnDevTool";
            this.btnDevTool.Size = new System.Drawing.Size(100, 23);
            this.btnDevTool.TabIndex = 1;
            this.btnDevTool.Text = "開発者ツール";
            this.btnDevTool.UseVisualStyleBackColor = true;
            this.btnDevTool.Click += new System.EventHandler(this.btnDevTool_Click);
            // 
            // btnSettingReload
            // 
            this.btnSettingReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingReload.Location = new System.Drawing.Point(370, 740);
            this.btnSettingReload.Name = "btnSettingReload";
            this.btnSettingReload.Size = new System.Drawing.Size(114, 23);
            this.btnSettingReload.TabIndex = 2;
            this.btnSettingReload.Text = "設定再読み込み";
            this.btnSettingReload.UseVisualStyleBackColor = true;
            this.btnSettingReload.Click += new System.EventHandler(this.btnSettingReload_Click);
            // 
            // btnSaveAndReload
            // 
            this.btnSaveAndReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAndReload.Location = new System.Drawing.Point(503, 740);
            this.btnSaveAndReload.Name = "btnSaveAndReload";
            this.btnSaveAndReload.Size = new System.Drawing.Size(141, 23);
            this.btnSaveAndReload.TabIndex = 4;
            this.btnSaveAndReload.Text = "保存して再読み込み";
            this.btnSaveAndReload.UseVisualStyleBackColor = true;
            this.btnSaveAndReload.Click += new System.EventHandler(this.btnSaveAndReload_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(392, 22);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "印刷";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tabSetting
            // 
            this.tabSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSetting.Controls.Add(this.pagePatternSetting);
            this.tabSetting.Controls.Add(this.pageLayoutXML);
            this.tabSetting.Controls.Add(this.pageDataXML);
            this.tabSetting.Location = new System.Drawing.Point(16, 92);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.SelectedIndex = 0;
            this.tabSetting.Size = new System.Drawing.Size(641, 642);
            this.tabSetting.TabIndex = 5;
            // 
            // pagePatternSetting
            // 
            this.pagePatternSetting.Controls.Add(this.label4);
            this.pagePatternSetting.Controls.Add(this.label3);
            this.pagePatternSetting.Controls.Add(this.txtPartialPath);
            this.pagePatternSetting.Controls.Add(this.label2);
            this.pagePatternSetting.Controls.Add(this.txtLayoutPath);
            this.pagePatternSetting.Controls.Add(this.label1);
            this.pagePatternSetting.Controls.Add(this.txtEditReportID);
            this.pagePatternSetting.Location = new System.Drawing.Point(4, 25);
            this.pagePatternSetting.Name = "pagePatternSetting";
            this.pagePatternSetting.Padding = new System.Windows.Forms.Padding(3);
            this.pagePatternSetting.Size = new System.Drawing.Size(633, 613);
            this.pagePatternSetting.TabIndex = 0;
            this.pagePatternSetting.Text = "帳票パターン設定";
            this.pagePatternSetting.UseVisualStyleBackColor = true;
            // 
            // pageDataXML
            // 
            this.pageDataXML.Controls.Add(this.linkDataXML);
            this.pageDataXML.Controls.Add(this.txtDataXMLEdit);
            this.pageDataXML.Location = new System.Drawing.Point(4, 25);
            this.pageDataXML.Name = "pageDataXML";
            this.pageDataXML.Padding = new System.Windows.Forms.Padding(3);
            this.pageDataXML.Size = new System.Drawing.Size(633, 613);
            this.pageDataXML.TabIndex = 1;
            this.pageDataXML.Text = "データXML";
            this.pageDataXML.UseVisualStyleBackColor = true;
            // 
            // txtEditReportID
            // 
            this.txtEditReportID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditReportID.Location = new System.Drawing.Point(105, 24);
            this.txtEditReportID.Name = "txtEditReportID";
            this.txtEditReportID.Size = new System.Drawing.Size(519, 27);
            this.txtEditReportID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "帳票識別子";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "レイアウト";
            // 
            // txtLayoutPath
            // 
            this.txtLayoutPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLayoutPath.Location = new System.Drawing.Point(105, 64);
            this.txtLayoutPath.Name = "txtLayoutPath";
            this.txtLayoutPath.Size = new System.Drawing.Size(519, 27);
            this.txtLayoutPath.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "部分ビュー";
            // 
            // txtPartialPath
            // 
            this.txtPartialPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartialPath.Location = new System.Drawing.Point(105, 100);
            this.txtPartialPath.Multiline = true;
            this.txtPartialPath.Name = "txtPartialPath";
            this.txtPartialPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPartialPath.Size = new System.Drawing.Size(519, 199);
            this.txtPartialPath.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "(改行区切り）";
            // 
            // txtDataXMLEdit
            // 
            this.txtDataXMLEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataXMLEdit.Location = new System.Drawing.Point(6, 35);
            this.txtDataXMLEdit.Multiline = true;
            this.txtDataXMLEdit.Name = "txtDataXMLEdit";
            this.txtDataXMLEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDataXMLEdit.Size = new System.Drawing.Size(618, 572);
            this.txtDataXMLEdit.TabIndex = 0;
            // 
            // pageLayoutXML
            // 
            this.pageLayoutXML.Controls.Add(this.linkLayoutXML);
            this.pageLayoutXML.Controls.Add(this.txtLayoutEdit);
            this.pageLayoutXML.Location = new System.Drawing.Point(4, 25);
            this.pageLayoutXML.Name = "pageLayoutXML";
            this.pageLayoutXML.Padding = new System.Windows.Forms.Padding(3);
            this.pageLayoutXML.Size = new System.Drawing.Size(633, 613);
            this.pageLayoutXML.TabIndex = 2;
            this.pageLayoutXML.Text = "レイアウト";
            this.pageLayoutXML.UseVisualStyleBackColor = true;
            // 
            // txtLayoutEdit
            // 
            this.txtLayoutEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLayoutEdit.Location = new System.Drawing.Point(6, 35);
            this.txtLayoutEdit.Multiline = true;
            this.txtLayoutEdit.Name = "txtLayoutEdit";
            this.txtLayoutEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLayoutEdit.Size = new System.Drawing.Size(618, 572);
            this.txtLayoutEdit.TabIndex = 1;
            // 
            // combReportID
            // 
            this.combReportID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combReportID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combReportID.FormattingEnabled = true;
            this.combReportID.Location = new System.Drawing.Point(89, 18);
            this.combReportID.Name = "combReportID";
            this.combReportID.Size = new System.Drawing.Size(555, 24);
            this.combReportID.TabIndex = 6;
            this.combReportID.SelectedIndexChanged += new System.EventHandler(this.combReportID_SelectedIndexChanged);
            // 
            // linkLayoutXML
            // 
            this.linkLayoutXML.AutoSize = true;
            this.linkLayoutXML.Location = new System.Drawing.Point(7, 12);
            this.linkLayoutXML.Name = "linkLayoutXML";
            this.linkLayoutXML.Size = new System.Drawing.Size(0, 16);
            this.linkLayoutXML.TabIndex = 2;
            this.linkLayoutXML.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // linkDataXML
            // 
            this.linkDataXML.AutoSize = true;
            this.linkDataXML.Location = new System.Drawing.Point(6, 12);
            this.linkDataXML.Name = "linkDataXML";
            this.linkDataXML.Size = new System.Drawing.Size(0, 16);
            this.linkDataXML.TabIndex = 3;
            this.linkDataXML.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDF.Location = new System.Drawing.Point(310, 23);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(75, 23);
            this.btnPDF.TabIndex = 6;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 775);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帳票エディタ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabSetting.ResumeLayout(false);
            this.pagePatternSetting.ResumeLayout(false);
            this.pagePatternSetting.PerformLayout();
            this.pageDataXML.ResumeLayout(false);
            this.pageDataXML.PerformLayout();
            this.pageLayoutXML.ResumeLayout(false);
            this.pageLayoutXML.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private CefSharp.WinForms.ChromiumWebBrowser browser;
        private System.Windows.Forms.Label lblDataXML;
        private System.Windows.Forms.TextBox txtDataXML;
        private System.Windows.Forms.Label lblReportID;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSaveAndReload;
        private System.Windows.Forms.Button btnSettingReload;
        private System.Windows.Forms.Button btnDevTool;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TabControl tabSetting;
        private System.Windows.Forms.TabPage pagePatternSetting;
        private System.Windows.Forms.TabPage pageDataXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditReportID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLayoutPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartialPath;
        private System.Windows.Forms.TextBox txtDataXMLEdit;
        private System.Windows.Forms.TabPage pageLayoutXML;
        private System.Windows.Forms.TextBox txtLayoutEdit;
        private System.Windows.Forms.ComboBox combReportID;
        private System.Windows.Forms.LinkLabel linkLayoutXML;
        private System.Windows.Forms.LinkLabel linkDataXML;
        private System.Windows.Forms.Button btnPDF;
    }
}

