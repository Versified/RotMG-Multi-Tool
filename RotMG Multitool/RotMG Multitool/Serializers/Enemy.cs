using MetroFramework;
using RotMG_Multitool.Forms;
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
        private readonly EnemyCreatorForm enemyCreatorForm;

        public Enemy(EnemyCreatorForm enemyCreatorForm)
        {
            this.enemyCreatorForm = enemyCreatorForm;
        }

        public string ObjectType { get; set; } // 0x0000
        public string ObjectId { get; set; } // Name

        // <Enemy />
        public string Class { get; set; } // Character

        public string RemoteTextureInstance { get; set; } // draw
        public string RemoteTextureId { get; set; } // 948590345743985374589
        public string TextureFile { get; set; } // lofiinterface
        public string TextureIndex { get; set; } // 69
        public string HitSound { get; set; } // monster/abyss_brutes_hit
        public string DeathSound { get; set; } // monster/abyss_brutes_death
        public int Size { get; set; } // 100
        public int HP { get; set; } // 10000
        public int Defense { get; set; } // 100

        public void Serialize()
        {
            // This is the XML Document.
            var doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
            var root = doc.CreateElement("Object");

            Thread.CurrentThread.CurrentCulture = new CultureInfo(1033);
            var command = doc.CreateComment("Generated on " + DateTime.Today.ToShortDateString() + " at " + DateTime.Now.ToShortTimeString());
            doc.AppendChild(command);

            var objectType = doc.CreateAttribute("type");
            objectType.Value = ObjectType;
            root.Attributes.Append(objectType);

            var @class = doc.CreateElement("Class"); // @class because "class" is a keyword
            @class.InnerText = Class;
            root.AppendChild(@class);

            var isEnemy = doc.CreateElement("Enemy");
            root.AppendChild(isEnemy);

            if (enemyCreatorForm.RemoteTexture)
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

            var size = doc.CreateElement("Size");
            size.InnerText = Size.ToString();
            root.AppendChild(size);

            var defense = doc.CreateElement("Defense");
            defense.InnerText = Defense.ToString();
            root.AppendChild(defense);

            var hp = doc.CreateElement("MaxHitPoints");
            hp.InnerText = HP.ToString();
            root.AppendChild(hp);

            doc.AppendChild(root);

            var writer = new StringWriter();
            doc.Save(writer);

            var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var fullFileName = Path.Combine(desktopFolder, "GeneratedEnemy.xml");

            var dlr = MessageBox.Show(enemyCreatorForm, writer.ToString(), "Finished XML", MessageBoxButtons.YesNo, MessageBoxIcon.Information); // Cannot be metro, text too big doesn't fit.
            if (dlr != DialogResult.Yes) return;
            //MessageBox.Show("Saving generated XML file to \r\n" + fullFileName);
            MetroMessageBox.Show(enemyCreatorForm, "Saving generated XML file to \r\n" + fullFileName, "Finished XML", MessageBoxButtons.OK, MessageBoxIcon.Information);

            doc.Save(fullFileName);
        }
    }
}