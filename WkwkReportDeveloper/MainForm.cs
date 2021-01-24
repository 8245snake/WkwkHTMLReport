using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WkwkReportStandalone;
using CefSharp;
using CefSharp.WinForms;
using WkwkReportServer.Templating;

namespace WkwkReportDeveloper
{
    public partial class MainForm : Form
    {
        private ReportPatternList _ReportPatternList = TemplateEngine.LoadPatternList();
        private const string CaptionNew = "新規追加";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 全コントロールにキーダウンイベントをもたせる
            txtDataXML.KeyDown += MainForm_KeyDown;
            splitContainer1.KeyDown += MainForm_KeyDown;
            splitContainer1.Panel1.KeyDown += MainForm_KeyDown;
            splitContainer1.Panel2.KeyDown += MainForm_KeyDown;
            browser.KeyDown += MainForm_KeyDown;

            // コンボボックス初期化
            foreach (var pattern in _ReportPatternList.Items)
            {
                combReportID.Items.Add(pattern.ReportID);
            }
            combReportID.Items.Add(CaptionNew);

            if (_ReportPatternList.Count > 0)
            {
                combReportID.SelectedIndex = 0;
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ShowPage(true);
        }

        private void ShowPage(bool showErrorMessage = false)
        {
            try
            {
                string reportID = combReportID.Text;
                string dataPath = txtDataXML.Text.Trim(new char[] { '"' });
                var uri = ReportGenerator.CreatePage(reportID, dataPath);
                browser.Load(uri);
            }
            catch(Exception e)
            {
                if (showErrorMessage) { MessageBox.Show(e.Message); }
            }

        }

        private void btnDevTool_Click(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            browser.Print();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.P:
                    if (e.Modifiers == Keys.Control)
                    {
                        browser.Print();
                    }
                    break;
                case Keys.F5:
                    ShowPage(true);
                    break;
                case Keys.F12:
                    browser.ShowDevTools();
                    break;
                default:
                    break;
            }
        }

        private void ReloadSetting()
        {
            ReportPattern pattern = _ReportPatternList[combReportID.Text];
            if (pattern == null) { return; }

            txtEditReportID.Text = pattern.ReportID;
            txtEditReportID.ReadOnly = true;
            txtLayoutPath.Text = pattern.TemplatePath;
            txtPartialPath.Text = string.Join("\r\n", pattern.PartialTemplates.Select(item => item.Key).ToArray());
            SetLayoutXMLText();
            SetDataXMLText();
            ShowPage();
        }

        private void btnSettingReload_Click(object sender, EventArgs e)
        {
            ReloadSetting();
        }

        private void combReportID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combReportID.Text == CaptionNew)
            {
                txtEditReportID.Text = "";
                txtEditReportID.ReadOnly = false;
                txtLayoutPath.Text = "";
                txtPartialPath.Text = "";
                txtLayoutEdit.Text = "";
            }
            else
            {
                ReloadSetting();
            }
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            if (link == null) { return; }
            //オプションに"/select"を指定して開く
            System.Diagnostics.Process.Start("EXPLORER.EXE", $"/select,\"{link.Text}\"");
        }

        private void SetLayoutXMLText()
        {
            string path = txtLayoutPath.Text.Trim(new char[] { '"' });
            if (File.Exists(path))
            {
                try
                {
                    txtLayoutEdit.Text = File.ReadAllText(path);
                    linkLayoutXML.Text = path;
                }
                catch { }
            }
        }

        private void SetDataXMLText()
        {
            string path = txtDataXML.Text.Trim(new char[] { '"' });
            if (File.Exists(path))
            {
                try { 
                    txtDataXMLEdit.Text = File.ReadAllText(path);
                    linkDataXML.Text = path;
                }
                catch { }
            }
        }

        private void txtDataXML_Validated(object sender, EventArgs e)
        {
            SetDataXMLText();
        }

        private void btnSaveAndReload_Click(object sender, EventArgs e)
        {

        }

        private void txtDataXML_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void txtDataXML_DragDrop(object sender, DragEventArgs e)
        {
            // ファイルが渡されていなければ、何もしない
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            // 渡されたファイルに対して処理を行う
            foreach (var filePath in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                txtDataXML.Text = filePath;
            }
        }
    }
}
