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

namespace TestStandaloneApp
{
    public partial class MainForm : Form
    {
        private static string dataPath = ReportGenerator.CanonicalizePath(@"script\DataXmlSample.xml");

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            CreatePDF("sample", "sample.pdf");
        }

        private async void CreatePDF(string reportID, string pdfPath)
        {
            bool success = await ReportGenerator.CreatePDFAsync(reportID, dataPath, pdfPath);
            if (success)
            {
                ReportGenerator.PrintPDF(pdfPath, showDialog: true);
            }

        }
    }
}
