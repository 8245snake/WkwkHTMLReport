using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WkwkReportClient;

namespace TestClientApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            PrintExecuter p = new PrintExecuter();
            string path = @"C:\Users\USER\Desktop\test.pdf";
            p.PrintPDF(path, 1);
        }
    }
}
