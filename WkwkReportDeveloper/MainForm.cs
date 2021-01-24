using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WkwkReportStandalone;

namespace WkwkReportDeveloper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            string reportID = txtReportID.Text;
            string dataPath = txtDataXML.Text;
            ShowPage(reportID, dataPath);
        }

        private void ShowPage(string reportID, string dataPath)
        {
            try
            {
                var uri = ReportGenerator.CreatePage(reportID, dataPath);
                browser.Load(uri);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
