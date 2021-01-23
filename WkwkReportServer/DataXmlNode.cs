using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace WkwkReportServer
{
    /// <summary>
    /// XmlNodeのラッパークラス
    /// </summary>
    public class DataXmlNode
    {
        private XmlNode _Node;

        public DataXmlNode(XmlNode node)
        {
            _Node = node;
        }

        /// <summary>
        /// 指定したXPathの文字列を返す
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns></returns>
        public string Text(string xpath)
        {
            XmlNodeList nodeList = _Node.SelectNodes(xpath);
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
            XmlNodeList nodeList = _Node.SelectNodes(xpath);
            foreach (XmlNode node in nodeList)
            {
                yield return new DataXmlNode(node);
            }
        }

    }
}
