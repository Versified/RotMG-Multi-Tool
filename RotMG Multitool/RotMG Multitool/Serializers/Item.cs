using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace RotMG_Multitool.Serializers
{
    internal class Item
    {
        public static string ObjectId { get; set; }
        public static ushort ObjectType { get; set; }
        public static string DisplayId { get; set; }
        public static string Class { get; set; }

        public static void Serialize()
        {
            try
            {
                var document = new XmlDocument();
                var form = new ItemCreatorForm();

                var @object = document.CreateElement("Object"); // @object because "object" is a keyword

                var objectType = document.CreateAttribute("type");
                objectType.Value = ObjectType.ToString();
                @object.Attributes.Append(objectType);

                var objectId = document.CreateAttribute("id");
                objectId.Value = ObjectId;
                @object.Attributes.Append(objectId);

                var @class = document.CreateElement("Class"); // @class because "class" is a keyword
                @class.InnerText = Class;
                @object.AppendChild(@class);

                document.AppendChild(@object);

                var writer = new StringWriter();
                document.Save(writer);
                MessageBox.Show(writer.ToString(), "Output");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), caption: "Error");
            }
        }
    }
}
