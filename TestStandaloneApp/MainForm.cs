using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            string reportID = "sample";
            TemplateEngine engine = new TemplateEngine();
            string path = engine.TemplateCompile(dataPath, reportID);


        }
    }
}
