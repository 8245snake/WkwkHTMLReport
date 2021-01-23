using RazorEngine;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using WkwkReportServer.Templating;

namespace WkwkReportServer.Templating
{
    public class TemplateEngine
    {
        ReportPatternList _PatternList;
        static string ConfigFileName = "TemplateConfig.xml";
        static string ExeDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        /// <summary>
        /// 帳票ごとの設定リスト
        /// </summary>
        public ReportPatternList PatternList { get => _PatternList; set => _PatternList = value; }

        /// <summary>
        /// TemplateConfig.xmlを読み込む
        /// </summary>
        /// <returns>帳票ごとの設定リスト</returns>
        public static ReportPatternList LoadPatternList()
        {
            ReportPatternList patternList = new ReportPatternList();

            try {
                string configPath = Path.Combine(ExeDirectory, ConfigFileName);
                XmlDocument doc = new XmlDocument();
                doc.Load(configPath);
                foreach (XmlNode reportNode in doc.SelectNodes("/Config/Report"))
                {
                    ReportPattern pattern = new ReportPattern();
                    pattern.ReportID = reportNode.SelectSingleNode("ID").InnerText;
                    pattern.TemplatePath = CanonicalizePath(reportNode.SelectSingleNode("TemplatePath").InnerText);
                    foreach (XmlNode partialNode in reportNode.SelectNodes("Partial/Path"))
                    {
                        pattern.AddPartialTemplatePath(CanonicalizePath(partialNode.InnerText));
                    }
                    patternList.Add(pattern);
                }
            }
            catch
            {
            }

            return patternList;
        }

        /// <summary>
        /// テンプレートエンジンを実行しデータXMLをバインディングしたHTMLファイルを生成する
        /// </summary>
        /// <param name="dataXmlPath">データXMLのパス</param>
        /// <param name="reportID">帳票識別子</param>
        /// <returns>生成したHTMLファイルのパス</returns>
        public string TemplateCompile(string dataXmlPath, string reportID)
        {
            // レイアウトファイルを取得する
            if (_PatternList == null) { _PatternList = LoadPatternList(); }
            ReportPattern pattern = _PatternList[reportID];
            if (pattern == null) { return ""; }
            string templateText = File.ReadAllText(pattern.TemplatePath);

            // テンプレートエンジンの実行
            DataXmlModel Model = new DataXmlModel(dataXmlPath);
            var service = Engine.Razor;
            foreach (var partial in pattern.PartialTemplates)
            {
                service.AddTemplate(partial.Key, partial.Value);
            }
            string resultText = service.RunCompile(templateText, reportID, Model.GetType(), Model);

            // ファイル出力
            string outputPath = Path.Combine(
                    Path.GetDirectoryName(pattern.TemplatePath),
                    $"{reportID}_{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.html"
                );
            File.WriteAllText(outputPath, resultText);

            return outputPath;
        }

        /// <summary>
        /// パスを正規化する
        /// </summary>
        /// <param name="path">パス（絶対パス/相対パス）</param>
        /// <returns>正規化されたパス</returns>
        public static string CanonicalizePath(string path)
        {
            if (path.StartsWith(@"\\") || path.Contains(@":\"))
            {
                // この場合は絶対パス確定なので正規化して返す
                return Path.GetFullPath(path);
            }

            // 相対パスの場合はexeからの相対パスを絶対パスにして返す
            string absolutePath = Path.Combine(ExeDirectory, path);
            return Path.GetFullPath(absolutePath);
        }
    }
}
