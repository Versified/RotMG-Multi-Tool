using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using RotMG_Multitool.Forms;

namespace RotMG_Multitool.Serializers
{
    internal class Item
    {
        private readonly  ItemCreatorForm itemCreatorForm;

        public Item(ItemCreatorForm itemCreatorForm)
        {
            this.itemCreatorForm = itemCreatorForm;
        }

        public string ObjectId { get; set; }
        public string ObjectType { get; set; }
        public string DisplayId { get; set; }
        public string Class { get; set; }
        public string DisplayName { get; set; }
        public string RemoteTextureInstance { get; set; }
        public string RemoteTextureId { get; set; }
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
            var doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
            var root = doc.CreateElement("Object");

            Thread.CurrentThread.CurrentCulture = new CultureInfo(1033);
            var command = doc.CreateComment("Generated on " + DateTime.Today.ToShortDateString() + " at " + DateTime.Now.ToShortTimeString());
            doc.AppendChild(command);

            var objectType = doc.CreateAttribute("type");
            objectType.Value = ObjectType;
            root.Attributes.Append(objectType);

            var objectId = doc.CreateAttribute("id");
            objectId.Value = ObjectId;
            root.Attributes.Append(objectId);

            var @class = doc.CreateElement("Class"); // @class because "class" is a keyword
            @class.InnerText = Class;
            root.AppendChild(@class);

            var isItem = doc.CreateElement("Item");
            root.AppendChild(isItem);

            if (itemCreatorForm.RemoteTexture)
            {
                var remoteTexture = doc.CreateElement("RemoteTexture");
                var rtInstance = doc.CreateElement("Instance");
                var rtId = doc.CreateElement("Id");

                rtInstance.InnerText = RemoteTextureInstance;
                rtId.InnerText = RemoteTextureId;

                remoteTexture.AppendChild(rtInstance);
                remoteTexture.AppendChild(rtId);

                root.AppendChild(remoteTexture);
            }
            else
            {
                var texture = doc.CreateElement("Texture");
                var tFile = doc.CreateElement("File");
                var tIndex = doc.CreateElement("Index");

                tFile.InnerText = TextureFile;
                tIndex.InnerText = TextureIndex;

                texture.AppendChild(tFile);
                texture.AppendChild(tIndex);

                root.AppendChild(texture);
            }

            var slotType = doc.CreateElement("SlotType");
            slotType.InnerText = SlotType.ToString();
            root.AppendChild(slotType);

            var tier = doc.CreateElement("Tier");
            tier.InnerText = Tier == -1 ? "UT" : Tier.ToString();
            root.AppendChild(tier);

            var description = doc.CreateElement("Description");
            description.InnerText = Description;
            root.AppendChild(description);

            var rateOfFire = doc.CreateElement("RateOfFire");
            rateOfFire.InnerText = RateOfFire.ToString();
            root.AppendChild(rateOfFire);

            var sound = doc.CreateElement("sound");
            sound.InnerText = "weapon/blunt_sword";
            root.AppendChild(sound);

            var bagType = doc.CreateElement("BagType");
            bagType.InnerText = BagType.ToString();
            root.AppendChild(bagType);

            var oldSound = doc.CreateElement("OldSound");
            oldSound.InnerText = "bladeSwing";
            root.AppendChild(oldSound);

            var displayId = doc.CreateElement("DisplayId");
            displayId.InnerText = DisplayName;
            root.AppendChild(displayId);

            doc.AppendChild(root);

            var writer = new StringWriter();
            doc.Save(writer);

            var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var fullFileName = Path.Combine(desktopFolder, "Generated Item.xml");

            var dlr = MessageBox.Show(writer.ToString(), "Finished XML", MessageBoxButtons.YesNo);
            if (dlr != DialogResult.Yes) return;
            MessageBox.Show("Saving generated XML file to \r\n" + fullFileName);
            doc.Save(fullFileName);
        }
    }
}
