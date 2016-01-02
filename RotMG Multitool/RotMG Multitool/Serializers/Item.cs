﻿using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace RotMG_Multitool.Serializers
{
    internal class Item
    {
        public string ObjectId { get; set; }
        public string ObjectType { get; set; }
        public string DisplayId { get; set; }
        public string Class { get; set; }
        public string DisplayName { get; set; }
        public string RemoteTextureInstance { get; set; }
        public string RemoteTextureID { get; set; }
        public string TextureFile { get; set; }
        public string TextureIndex { get; set; }
        public int SlotType { get; set; }
        public int Tier { get; set; }
        public string Description { get; set; }
        public int RateOfFire { get; set; }
        public int BagType { get; set; }

        public void Serialize()
        {
            // This is the XML Document which we are writing to.
            var xmlDocument = new XmlDocument();

            var root = xmlDocument.CreateElement("Object");

            Thread.CurrentThread.CurrentCulture = new CultureInfo(1033);
            var comment = xmlDocument.CreateComment("Generated on " + DateTime.Today.ToShortDateString() + " at " + DateTime.Now.ToShortTimeString());
            xmlDocument.AppendChild(comment);

            var _objectType = xmlDocument.CreateAttribute("type");
            _objectType.Value = ObjectType;
            root.Attributes.Append(_objectType);

            var _objectId = xmlDocument.CreateAttribute("id");
            _objectId.Value = ObjectId;
            root.Attributes.Append(_objectId);

            var _class = xmlDocument.CreateElement("Class"); // @class because "class" is a keyword
            _class.InnerText = Class;
            root.AppendChild(_class);

            var _isItem = xmlDocument.CreateElement("Item");
            root.AppendChild(_isItem);

            if (ItemCreatorForm.remoteTexture)
            {
                var _remoteTexture = xmlDocument.CreateElement("RemoteTexture");
                var _rtInstance = xmlDocument.CreateElement("Instance");
                var _rtId = xmlDocument.CreateElement("Id");

                _rtInstance.InnerText = RemoteTextureInstance;
                _rtId.InnerText = RemoteTextureID;

                _remoteTexture.AppendChild(_rtInstance);
                _remoteTexture.AppendChild(_rtId);

                root.AppendChild(_remoteTexture);
            }
            else if (!ItemCreatorForm.remoteTexture)
            {
                var _texture = xmlDocument.CreateElement("Texture");
                var _tFile = xmlDocument.CreateElement("File");
                var _tIndex = xmlDocument.CreateElement("Index");

                _tFile.InnerText = TextureFile;
                _tIndex.InnerText = TextureIndex;

                _texture.AppendChild(_tFile);
                _texture.AppendChild(_tIndex);

                root.AppendChild(_texture);
            }

            var _slotType = xmlDocument.CreateElement("SlotType");
            _slotType.InnerText = SlotType.ToString();
            root.AppendChild(_slotType);

            var _tier = xmlDocument.CreateElement("Tier");
            _tier.InnerText = Tier == -1 ? "UT" : Tier.ToString();
            root.AppendChild(_tier);

            var _description = xmlDocument.CreateElement("Description");
            _description.InnerText = Description;
            root.AppendChild(_description);

            var _rateOfFire = xmlDocument.CreateElement("RateOfFire");
            _rateOfFire.InnerText = RateOfFire.ToString();
            root.AppendChild(_rateOfFire);

            var _sound = xmlDocument.CreateElement("sound");
            _sound.InnerText = "weapon/blunt_sword";
            root.AppendChild(_sound);

            var _bagType = xmlDocument.CreateElement("BagType");
            _bagType.InnerText = BagType.ToString();
            root.AppendChild(_bagType);

            var _oldSound = xmlDocument.CreateElement("OldSound");
            _oldSound.InnerText = "bladeSwing";
            root.AppendChild(_oldSound);

            var _displayId = xmlDocument.CreateElement("DisplayId");
            _displayId.InnerText = DisplayName;
            root.AppendChild(_displayId);

            xmlDocument.AppendChild(root);

            var writer = new StringWriter();
            xmlDocument.Save(writer);

            var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var fullFileName = Path.Combine(desktopFolder, "Generated Item.xml");

            var dlr = MessageBox.Show(writer.ToString(), "Finished XML", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                MessageBox.Show("Saving generated XML file to \r\n" + fullFileName);
                xmlDocument.Save(fullFileName);
            }
        }
    }
}
