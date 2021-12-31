using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.XPath;

namespace XpathHelp
{
    public class XpathHelper
    {
        public XmlDocument doc;
        private string m_filename;
        private XPathDocument docNav;
        XPathNavigator nav;
        XPathNodeIterator NodeIter;
      
        public XpathHelper(string filename)
        {
            m_filename = filename;
            docNav = new XPathDocument(m_filename);
            nav = docNav.CreateNavigator();
            doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.InnerXml = File.ReadAllText(m_filename);       
        }

        public object XpathQuery(string strexpression)
        {
            object evaluation = (object)nav.Evaluate(strexpression);
            System.Type ty = evaluation.GetType();
            if (ty.FullName.Equals("MS.Internal.Xml.XPath.XPathSelectionIterator"))
            {
                string retxml = string.Empty;
                NodeIter = (XPathNodeIterator)evaluation;
                while (NodeIter.MoveNext())
                {
                    retxml += NodeIter.Current.InnerXml.ToString() + Environment.NewLine;
                }
                return retxml;
            }
            else return evaluation;
        } 

    }
}