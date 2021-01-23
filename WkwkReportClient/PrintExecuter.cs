using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ghostscript.NET;
using Ghostscript.NET.Viewer;
using Ghostscript.NET.Processor;

namespace WkwkReportClient
{
    public class PrintExecuter
    {

        public void PrintPDF(string inputFilePath, int printNumber = 1, string printerName = null)
        {
            if (string.IsNullOrWhiteSpace(printerName))
            {
                var pd = new System.Drawing.Printing.PrintDocument();
                printerName = pd.PrinterSettings.PrinterName;
            }

            using (GhostscriptProcessor processor = new GhostscriptProcessor())
            {
                List<string> switches = new List<string>();
                switches.Add("-empty");
                switches.Add("-dPrinted");
                switches.Add("-dBATCH");
                switches.Add("-dNOPAUSE");
                switches.Add("-dNOSAFER");
                switches.Add($"-dNumCopies={printNumber}"); //部数
                switches.Add("-sDEVICE=mswinpr2");
                //switches.Add("-sPAPERSIZE=a4");
                //横指定A4
                //switches.Add("-dDEVICEWIDTHPOINTS=842");
                //switches.Add("-dDEVICEHEIGHTPOINTS=595");
                //両面印刷
                //switches.Add("-dDuplex");//TrueON,false=off
                //switches.Add("-dTumble=true");//True=短辺綴じ false=長辺綴じ
                switches.Add("-sOutputFile=%printer%" + printerName);
                switches.Add("-f");
                switches.Add(inputFilePath);
                processor.StartProcessing(switches.ToArray(), null);
            }
        }
    }
}
