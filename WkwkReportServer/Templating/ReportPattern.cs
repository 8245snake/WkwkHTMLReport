using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace WkwkReportServer.Templating
{
    public class ReportPattern
    {
        public string ReportID { set; get; }
        public string TemplatePath { set; get; }
        public IEnumerable<KeyValuePair<string,string>> PartialTemplates
        {
            get
            {
                foreach (string path in _PartialTemplatePath)
                {
                    string name = Path.GetFileNameWithoutExtension(path);
                    string text = File.ReadAllText(path);
                    yield return new KeyValuePair<string, string>(name, text);
                }
            }
        }

        private List<string> _PartialTemplatePath = new List<string>();

        public void AddPartialTemplatePath(string path)
        {
            _PartialTemplatePath.Add(path);
        }
    }

    public class ReportPatternList
    {
        private List<ReportPattern> _List { set; get; } = new List<ReportPattern>();

        public ReportPattern this[string reportID]
        {
            get => _List.Where(pattern => pattern.ReportID.ToUpper() == reportID.ToUpper()).FirstOrDefault();
        }

        public void Add(ReportPattern pattern)
        {
            _List.Add(pattern);
        }
    }
}
