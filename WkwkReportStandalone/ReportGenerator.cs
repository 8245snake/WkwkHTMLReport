using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WkwkReportClient;
using WkwkReportServer.Printing;
using WkwkReportServer.Templating;

namespace WkwkReportStandalone
{
    public class ReportGenerator
    {
        /// <summary>
        /// PDFファイルを出力する
        /// </summary>
        /// <param name="url">印刷対象のURL</param>
        /// <param name="outputPath">PDFファイルの出力先パス</param>
        /// <returns>成功したか</returns>
        public static async Task<bool> CreatePDFAsync(string reportID, string dataPath, string outputPath)
        {
            PDFCreator creator = new PDFCreator();
            return await creator.CreatePDFAsync(CreatePage(reportID, dataPath), outputPath);
        }

        /// <summary>
        /// 指定したプリンタでPDFを印刷する
        /// </summary>
        /// <param name="inputFilePath">PDFのパス</param>
        /// <param name="printNumber">印刷枚数</param>
        /// <param name="printerName">プリンタ名</param>
        /// <param name="showDialog">プリンタ選択ダイアログを表示するか否か</param>
        public static void PrintPDF(string inputFilePath, int printNumber = 1, string printerName = null, bool showDialog = false)
        {
            PrintExecuter p = new PrintExecuter();
            p.PrintPDF(inputFilePath, printNumber, printerName, showDialog);
        }

        /// <summary>
        /// パスを正規化する
        /// </summary>
        /// <param name="path">パス（絶対パス/相対パス）</param>
        /// <returns>正規化されたパス</returns>
        public static string CanonicalizePath(string path)
        {
            return TemplateEngine.CanonicalizePath(path);
        }

        /// <summary>
        /// 指定した帳票識別子とデータXMLからページを生成しURLを返す
        /// </summary>
        /// <param name="reportID">帳票識別子</param>
        /// <param name="dataPath">データXMLのパス</param>
        /// <returns>生成したHTMLファイルのパス</returns>
        public static string CreatePage(string reportID, string dataPath)
        {
            TemplateEngine engine = new TemplateEngine();
            string path = engine.TemplateCompile(dataPath, reportID);
            Uri uri = new Uri(path);
            return uri.AbsoluteUri;
        }

        /// <summary>
        /// 指定した帳票識別子とデータXMLからページを生成しURLを返す
        /// </summary>
        /// <param name="dataText">データXMLの中身</param>
        /// <param name="templateText">テンプレートファイルの中身</param>
        /// <param name="partialTemplateTexts">部分ビューの中身</param>
        /// <returns>生成したHTMLファイルのパス</returns>
        public static string CreatePage(string dataText, string templateText, params string[] partialTemplateTexts)
        {
            TemplateEngine engine = new TemplateEngine();
            string path = engine.TemplateCompile(dataText, templateText, partialTemplateTexts);
            Uri uri = new Uri(path);
            return uri.AbsoluteUri;
        }
    }
}
