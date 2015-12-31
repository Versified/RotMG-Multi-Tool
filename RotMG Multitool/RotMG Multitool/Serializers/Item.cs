using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace RotMG_Multitool.Serializers
{
    internal class Item
    {
        public static string ObjectId { get; set; }
        public static string ObjectType { get; set; }
        public static string DisplayId { get; set; }
        public static string Class { get; set; }
        public static string DisplayName { get; set; }
        public static string RemoteTextureInstance { get; set; }
        public static string RemoteTextureID { get; set; }
        public static string TextureFile { get; set; }
        public static string TextureIndex { get; set; }
        public static int SlotType { get; set; }
        public static int Tier { get; set; }
        public static string Description { get; set; }
        public static int RateOfFire { get; set; }
        public static int BagType { get; set; }

        public static void Serialize()
        {
            ItemCreatorForm form = new ItemCreatorForm();
            try
            {
                // This is the XML Document which we are writing to.
                var doc = new XmlDocument();

                var _object = doc.CreateElement("Object"); // @object because "object" is a keyword

                Thread.CurrentThread.CurrentCulture = new CultureInfo(1033);
                var _command = doc.CreateComment("Generated on " + DateTime.Today.ToShortDateString() + " at " + DateTime.Now.ToShortTimeString());
                doc.AppendChild(_command);

                var _objectType = doc.CreateAttribute("type");
                _objectType.Value = ObjectType;
                _object.Attributes.Append(_objectType);

                var _objectId = doc.CreateAttribute("id");
                _objectId.Value = ObjectId;
                _object.Attributes.Append(_objectId);

                var _class = doc.CreateElement("Class"); // @class because "class" is a keyword
                _class.InnerText = Class;
                _object.AppendChild(_class);

                var _isItem = doc.CreateElement("Item");
                _object.AppendChild(_isItem);

                if (ItemCreatorForm.remoteTexture)
                {
                    var _remoteTexture = doc.CreateElement("RemoteTexture");
                    var _rtInstance = doc.CreateElement("Instance");
                    var _rtId = doc.CreateElement("Id");

                    _rtInstance.InnerText = RemoteTextureInstance;
                    _rtId.InnerText = RemoteTextureID;

                    _remoteTexture.AppendChild(_rtInstance);
                    _remoteTexture.AppendChild(_rtId);

                    _object.AppendChild(_remoteTexture);
                }
                else if (!ItemCreatorForm.remoteTexture)
                {
                    var _texture = doc.CreateElement("Texture");
                    var _tFile = doc.CreateElement("File");
                    var _tIndex = doc.CreateElement("Index");

                    _tFile.InnerText = TextureFile;
                    _tIndex.InnerText = TextureIndex;

                    _texture.AppendChild(_tFile);
                    _texture.AppendChild(_tIndex);

                    _object.AppendChild(_texture);
                }

                var _slotType = doc.CreateElement("SlotType");
                _slotType.InnerText = SlotType.ToString();
                _object.AppendChild(_slotType);

                var _tier = doc.CreateElement("Tier");
                _tier.InnerText = Tier == -1 ? "UT" : Tier.ToString();
                _object.AppendChild(_tier);

                var _description = doc.CreateElement("Description");
                _description.InnerText = Description;
                _object.AppendChild(_description);

                var _rateOfFire = doc.CreateElement("RateOfFire");
                _rateOfFire.InnerText = RateOfFire.ToString();
                _object.AppendChild(_rateOfFire);

                var _sound = doc.CreateElement("sound");
                _sound.InnerText = "weapon/blunt_sword";
                _object.AppendChild(_sound);

                var _bagType = doc.CreateElement("BagType");
                _bagType.InnerText = BagType.ToString();
                _object.AppendChild(_bagType);

                var _oldSound = doc.CreateElement("OldSound");
                _oldSound.InnerText = "bladeSwing";
                _object.AppendChild(_oldSound);

                var _displayId = doc.CreateElement("DisplayId");
                _displayId.InnerText = DisplayName;
                _object.AppendChild(_displayId);

                doc.AppendChild(_object);

                var writer = new StringWriter();
                doc.Save(writer);

                var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                var fullFileName = Path.Combine(desktopFolder, "Generated Item.xml");

                var dlr = MessageBox.Show(writer.ToString(), "Finished XML", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    MessageBox.Show("Saving generated XML file to \r\n" + fullFileName);
                    doc.Save(fullFileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), caption: "Error");
            }
        }
    }
}
