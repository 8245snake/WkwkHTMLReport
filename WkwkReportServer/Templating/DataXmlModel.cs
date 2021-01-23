using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WkwkReportServer.Templating
{
    /// <summary>
    /// XmlDocumentのラッパークラス
    /// </summary>
    public class DataXmlModel
    {
        private XmlDocument _XmlDocument = new XmlDocument();


        public DataXmlModel(string path)
        {
            _XmlDocument.Load(path);
        }

        /// <summary>
        /// 指定したXPathの文字列を返す
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns></returns>
        public string Text(string xpath)
        {
            XmlNodeList nodeList = _XmlDocument.SelectNodes(xpath);
            foreach (XmlNode node in nodeList)
            {
                return node.InnerText;
            }
            return "";
        }

        /// <summary>
        /// ノードのリストを返す
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns></returns>
        public IEnumerable<DataXmlNode> Nodes(string xpath)
        {
            XmlNodeList nodeList = _XmlDocument.SelectNodes(xpath);
            foreach (XmlNode node in nodeList)
            {
                yield return new DataXmlNode(node);
            }
        }
    }
}
