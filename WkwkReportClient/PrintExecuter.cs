using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WkwkReportClient
{
    /// <summary>
    /// プリンタにPDFの印刷命令を送るためのクラス
    /// </summary>
    public class PrintExecuter
    {
        static string ExeDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        /// <summary>
        /// 指定したプリンタでPDFを印刷する
        /// </summary>
        /// <param name="inputFilePath">PDFのパス</param>
        /// <param name="printNumber">印刷枚数</param>
        /// <param name="printerName">プリンタ名</param>
        public void PrintPDF(string inputFilePath, int printNumber = 1, string printerName = null)
        {
            if (string.IsNullOrWhiteSpace(printerName))
            {
                // プリンタ名の指定がなければデフォルトプリンタを使用
                var pd = new System.Drawing.Printing.PrintDocument();
                printerName = pd.PrinterSettings.PrinterName;
            }

            // 指定枚数分だけ実行
            for (int i = 0; i < printNumber; i++)
            {
                ExecuteGhostscript(inputFilePath, printerName);
            }
        }

        private string GetGhostscriptPath()
        {
            string x64Path = Path.Combine(ExeDirectory, @"x64\ghostscript\gswin64c.exe");
            if (File.Exists(x64Path))
            {
                return x64Path;
            }

            string x86Path = Path.Combine(ExeDirectory, @"x86\ghostscript\gswin32c.exe");
            if (File.Exists(x86Path))
            {
                return x86Path;
            }
            return "";
        }

        private void ExecuteGhostscript(string inputFilePath, string printerName)
        {
            string ghostscriptPath = GetGhostscriptPath();
            if (string.IsNullOrWhiteSpace(ghostscriptPath))
            {
                return;
            }
            string args = "";
            args += "-r300 ";
            args += "-dPrinted ";
            args += "-dNOPAUSE ";
            args += "-dBATCH ";
            args += "-dNOSAFER ";
            args += "-dNoCancel ";
            args += "-sDEVICE=mswinpr2 ";
            args += $"-sOutputFile=\"%printer%{printerName}\" ";
            args += inputFilePath;

            // 実行
            ExecuteProcess(ghostscriptPath, args);
        }

        /// <summary>
        /// 非表示でプロセスを開始する
        /// </summary>
        /// <param name="exePath">実行ファイルのパス</param>
        /// <param name="args">起動引数</param>
        public static void ExecuteProcess(string exePath, string args)
        {
            using (System.Diagnostics.Process p = new System.Diagnostics.Process())
            {
                //ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
                p.StartInfo.FileName = exePath;
                //ウィンドウを表示しないようにする
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                p.StartInfo.Arguments = args;
                //起動
                p.Start();
                p.Close();
            }
        }
    }
}
