//<Object type="0xa00" id="Short Sword">
//    <Class>Equipment</Class>
//    <Item/>
//    <Texture>
//      <File>lofiObj5</File>
//      <Index>0x30</Index>
//    </Texture>
//    <SlotType>1</SlotType>
//    <Tier>0</Tier>
//    <Description>A steel short sword.</Description>
//    <RateOfFire>1</RateOfFire>
//    <Sound>weapon/blunt_sword</Sound>
//    <LevelReq>1</LevelReq> // Not used.
//    <BagType>0</BagType>
//    <OldSound>bladeSwing</OldSound>
//  </Object>
using System;
using System.Globalization;
using System.IO;
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
                var document = new XmlDocument();

                var @object = document.CreateElement("Object"); // @object because "object" is a keyword

                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo(1033);
                var comment = document.CreateComment("Generated on " + DateTime.Today.ToShortDateString() + " at " + DateTime.Now.ToShortTimeString());
                document.AppendChild(comment);

                var objectType = document.CreateAttribute("type");
                objectType.Value = ObjectType.ToString();
                @object.Attributes.Append(objectType);

                var objectId = document.CreateAttribute("id");
                objectId.Value = ObjectId;
                @object.Attributes.Append(objectId);
                var @class = document.CreateElement("Class"); // @class because "class" is a keyword
                @class.InnerText = Class;
                @object.AppendChild(@class);

                var displayID = document.CreateElement("DisplayID");
                displayID.InnerText = DisplayName;
                @object.AppendChild(displayID);

                var item = document.CreateElement("Item");
                @object.AppendChild(item);

                if (ItemCreatorForm.remoteTexture)
                {
                    var remoteTexture = document.CreateElement("RemoteTexture");
                    var remoteTextureInstance = document.CreateElement("Instance");
                    var remoteTextureId = document.CreateElement("Id");

                    remoteTextureInstance.InnerText = RemoteTextureInstance;
                    remoteTextureId.InnerText = RemoteTextureID;

                    remoteTexture.AppendChild(remoteTextureInstance);
                    remoteTexture.AppendChild(remoteTextureId);

                    @object.AppendChild(remoteTexture);
                }
                else if (!ItemCreatorForm.remoteTexture)
                {
                    var texture = document.CreateElement("Texture");
                    var textureFile = document.CreateElement("File");
                    var textureIndex = document.CreateElement("Index");

                    textureFile.InnerText = TextureFile;
                    textureIndex.InnerText = TextureIndex;

                    texture.AppendChild(textureFile);
                    texture.AppendChild(textureIndex);

                    @object.AppendChild(texture);
                }

                var slotType = document.CreateElement("SlotType");
                slotType.InnerText = SlotType.ToString();
                @object.AppendChild(slotType);

                var tier = document.CreateElement("Tier");
                if (Tier == -1)
                {
                    tier.InnerText = "UT";
                }
                else
                {
                    tier.InnerText = Tier.ToString();
                }
                @object.AppendChild(tier);

                var description = document.CreateElement("Description");
                description.InnerText = Description;
                @object.AppendChild(description);

                var rateOfFire = document.CreateElement("RateOfFire");
                rateOfFire.InnerText = RateOfFire.ToString();
                @object.AppendChild(rateOfFire);

                var weaponSound = document.CreateElement("sound");
                weaponSound.InnerText = "weapon/blunt_sword";
                @object.AppendChild(weaponSound);

                var bagType = document.CreateElement("BagType");
                bagType.InnerText = BagType.ToString();
                @object.AppendChild(bagType);

                var oldSound = document.CreateElement("OldSound");
                oldSound.InnerText = "bladeSwing";
                @object.AppendChild(oldSound);

                document.AppendChild(@object);

                var writer = new StringWriter();
                document.Save(writer);

                var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                var fullFileName = Path.Combine(desktopFolder, "Generated Item.xml");

                DialogResult dlr = MessageBox.Show(writer.ToString(), "Finished XML", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    MessageBox.Show("Saving generated XML file to \r\n" + fullFileName);
                    document.Save(fullFileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), caption: "Error");
            }
        }
    }
}
