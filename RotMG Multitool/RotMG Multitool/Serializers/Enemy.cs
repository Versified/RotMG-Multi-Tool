using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace RotMG_Multitool.Serializers
{
    internal class Enemy
    {
        public string ObjectId { get; set; }

        public void Serialize()
        {
            // Todo make the skeleton of the XML.
            var xmlDocument = new XmlDocument();

            var root = xmlDocument.CreateElement("Object");

            var objectType = xmlDocument.CreateAttribute("TestAttribute");
            objectType.Value = "Test";
            root.Attributes.Append(objectType);

            xmlDocument.AppendChild(root);

            var writer = new StringWriter();
            xmlDocument.Save(writer);
            MessageBox.Show(writer.ToString());
        }
    }
}
