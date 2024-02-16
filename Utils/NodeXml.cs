using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ECO_DX_For_PUR.Utils
{
    public static class NodeXml
    {
        public const string nodeXmlECOcontrolSheet = "FilePathECOcontrolSheet";
        public const string nodeXmlECNCanonPurchaseAction = "FilePathECNCanonPurchase";
        public const string nodeXmlECNCanonPurchaseMaster = "FilePathMaster";
        public static bool UpdateFilePathToXml(string filePath, string nodeXML)
        {
            if (IsValidPath(filePath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("\\\\vn-file\\DX Center\\7.ECN_Management\\StartUp\\config.xml");

                XmlNode filePathNode = xmlDoc.SelectSingleNode($"/Config/{nodeXML}");

                if (filePathNode != null)
                {
                    filePathNode.InnerText = filePath;
                    xmlDoc.Save("config.xml");
                }
                return true;
            }
            return false;
        }
        public static void SaveFilePathToXml(string filePath, string xmlFileName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Config");
            xmlDoc.AppendChild(root);

            XmlElement filePathElement = xmlDoc.CreateElement("FilePath");
            filePathElement.InnerText = filePath;
            root.AppendChild(filePathElement);

            xmlDoc.Save(xmlFileName);
        }
        public static bool IsValidPath (string path)
        {
            // Check if the path is rooted
            if (Path.IsPathRooted(path))
            {
                // Check if it's a valid directory path
                if (Directory.Exists(path))
                {
                    return true;
                }
                else if (File.Exists(path))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static string GetFilePathFromXml(string nodeXML)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("\\\\vn-file\\DX Center\\7.ECN_Management\\StartUp\\config.xml");

            XmlNode filePathNode = xmlDoc.SelectSingleNode($"/Config/{nodeXML}");

            return filePathNode?.InnerText;
        }
    }
}
