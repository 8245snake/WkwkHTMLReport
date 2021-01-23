using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WkwkReportServer.Printing;
using WkwkReportServer.Templating;

namespace TestStandaloneApp
{
    public partial class MainForm : Form
    {
        private static string dataPath = TemplateEngine.CanonicalizePath(@"script\DataXmlSample.xml");

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
            TemplateEngine engine = new TemplateEngine();
            string path = engine.TemplateCompile(dataPath, reportID);
            PDFCreator creator = new PDFCreator();
            Uri uri = new Uri(path);
            var success = await creator.CreatePDFAsync(uri.AbsoluteUri, pdfPath);
            if (success)
            {
                MessageBox.Show($"PDFを作成しました\r\n{pdfPath}");
            }
        }
    }
}
