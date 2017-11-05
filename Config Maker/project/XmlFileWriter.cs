using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AC_Config_Maker
{
    internal class XmlFileWriter
    {
        private string outputPath;
        private string outputXmlString;
        private string KEYS = "keys";
        private string REMOTE = "remote";
        private string KEY = "key";
        private string NAME = "name";
        private string TYPE = "type";
        private string HEX = "hex";
        private int minDegree, maxDegree;
        private int fanMaxSpeed;
        private List<char> modesList;
        private string MIN_DEGREE = "min_degree";
        private string MAX_DEGREE = "max_degree";
        private string AC_DISPLAY = "ac_display";
        private string degreeType;
        private bool acDisplayRequired;

        public XmlFileWriter
            (string outputFolder, string outputXmlString, string minDegree, string maxDegree, List<char> modesList, int fanMaxSpeed, string degreeType, bool acDisplayRequired)
        {
            this.acDisplayRequired = acDisplayRequired;
            this.minDegree = int.Parse(minDegree);
            this.maxDegree = int.Parse(maxDegree);
            this.modesList = modesList;
            this.fanMaxSpeed = fanMaxSpeed;
            this.outputPath = outputFolder;
            this.outputXmlString = outputXmlString;
            this.degreeType = degreeType;
        }

        public void WriteXml()
        {
            XmlDocument document = new XmlDocument();
            XmlDeclaration xmlDeclaration = document.CreateXmlDeclaration("1.0", "utf-8", null);
            XmlElement remoteNode = document.CreateElement(REMOTE);
            XmlElement keysNode = document.CreateElement(KEYS);
            outputXmlString.Trim();


            string[] parsedString = outputXmlString.Split(' ');
            foreach (string nodeVal in parsedString)
            {
                if (nodeVal.Equals("")) continue;
                XmlElement keyNode = document.CreateElement(KEY);
                keyNode.SetAttribute(TYPE, HEX);
                keyNode.SetAttribute(NAME, nodeVal);
                keysNode.AppendChild(keyNode);
            }


            if (acDisplayRequired) {
                SetDegreesNodes(document, keysNode);
                SetDisplayNode(document, keysNode);
            }
            remoteNode.AppendChild(keysNode);
            document.AppendChild(remoteNode);

            document.InsertBefore(xmlDeclaration, remoteNode);
            if (!Directory.Exists(outputPath)) Directory.CreateDirectory(outputPath);
            document.Save(outputPath +"\\config.xml");
            System.Console.WriteLine("done! wrote to: "+ outputPath);
        }

        private void SetDisplayNode(XmlDocument document, XmlElement keysNode)
        {
            XmlElement acDisplayNode = document.CreateElement(KEY);
            acDisplayNode.SetAttribute(TYPE, HEX);
            acDisplayNode.SetAttribute(NAME, TextTemplateHandler.SCREEN_ELEMENT_TAG + AC_DISPLAY);

            keysNode.AppendChild(acDisplayNode);
        }

        private void SetDegreesNodes(XmlDocument document, XmlElement keysNode)
        {
            SetRemoteParams(document, keysNode);
            for (int mode = 0; mode < modesList.Count; mode++)
            {
                for (int fanSpeed = 1; fanSpeed < fanMaxSpeed+1; fanSpeed++)
                {
                    for (int degree = minDegree; degree < maxDegree+1; degree++)
                    {
                        XmlElement keyNode = document.CreateElement(KEY);
                        keyNode.SetAttribute(TYPE, HEX);
                        keyNode.SetAttribute(NAME, modesList[mode].ToString() + degree+"F"+ fanSpeed);
                        keysNode.AppendChild(keyNode);
                    }
                }
            }
        }

        private void SetRemoteParams(XmlDocument document, XmlElement keysNode)
        {
            XmlElement minNode = document.CreateElement(KEY);
            minNode.SetAttribute(TYPE, HEX);
            minNode.SetAttribute(NAME, MIN_DEGREE);
            minNode.InnerText = minDegree.ToString();

            XmlElement maxNode = document.CreateElement(KEY);
            maxNode.SetAttribute(TYPE, HEX);
            maxNode.SetAttribute(NAME, MAX_DEGREE);
            maxNode.InnerText = maxDegree.ToString();

            XmlElement modesNode = document.CreateElement(KEY);
            modesNode.SetAttribute(TYPE, HEX);
            modesNode.SetAttribute(NAME, TextTemplateHandler.MODES);
            foreach (var mode in modesList)
                modesNode.InnerText += " " + mode;
            modesNode.InnerText = modesNode.InnerText.Trim();
            modesNode.InnerText = modesNode.InnerText.Replace(" ", ", ");

            XmlElement maxFanPowerNode = document.CreateElement(KEY);
            maxFanPowerNode.SetAttribute(TYPE, HEX);
            maxFanPowerNode.SetAttribute(NAME, TextTemplateHandler.MAX_FAN_POWER);
            maxFanPowerNode.InnerText = fanMaxSpeed.ToString();

            XmlElement degreeTypeNode = document.CreateElement(KEY);
            degreeTypeNode.SetAttribute(TYPE, HEX);
            degreeTypeNode.SetAttribute(NAME, TextTemplateHandler.DEGREE_TYPE);
            degreeTypeNode.InnerText = degreeType;

            keysNode.AppendChild(degreeTypeNode);
            keysNode.AppendChild(maxFanPowerNode);
            keysNode.AppendChild(modesNode);
            keysNode.AppendChild(minNode);
            keysNode.AppendChild(maxNode);
        }
    }
}