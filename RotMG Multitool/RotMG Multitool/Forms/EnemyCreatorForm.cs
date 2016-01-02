using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using RotMG_Multitool.Serializers;

namespace RotMG_Multitool.Forms
{
    public partial class EnemyCreatorForm : MetroForm
    {
        private readonly Enemy serializer;

        //public string ObjectType { get; set; } // 0x0000
        //public string ObjectId { get; set; } // Name
        //// <Enemy />
        //public string Class { get; set; } // Character
        //public string Texture { get; set; } // <File> <Index>
        //public string HitSound { get; set; } // monster/abyss_brutes_hit
        //public string DeathSound { get; set; } // monster/abyss_brutes_death
        //public int Size { get; set; } // 100
        //public int HP { get; set; } // 10000
        //public int Defense { get; set; } // 100

        public EnemyCreatorForm()
        {
            InitializeComponent();
            serializer = new Enemy(this);
            RemoteTexture = true;
        }

        public bool RemoteTexture { get; set; }

        private void createXMLButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (updateThings())
                    serializer.Serialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private bool updateThings()
        {
            try
            {
                serializer.ObjectType = objectTypeText.Text;
                serializer.ObjectId = objectIdText.Text;
                serializer.Class = classText.Text;
                serializer.RemoteTextureId = rtextureIdText.Text;
                serializer.RemoteTextureInstance = rtextureInstanceText.Text;
                serializer.TextureIndex = textureIndexText.Text;
                serializer.TextureFile = textureFileText.Text;
                int size;
                if (!int.TryParse(sizeTextBoxText.Text, out size))
                {
                    MetroMessageBox.Show(this, "Invalid value for \"Size\"", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                int hp;
                if (!int.TryParse(healthTextBoxText.Text, out hp))
                {
                    MetroMessageBox.Show(this, "Invalid value for \"Health\"", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                int defense;
                if (!int.TryParse(defenseTextBoxText.Text, out defense))
                {
                    MetroMessageBox.Show(this, "Invalid value for \"Defense\"", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
                return false;
            }
            return true;
        }

        private void textureButton_Click(object sender, EventArgs e)
        {
            if (textureButton.Text == "Remote Texture")
            {
                textureButton.Text = "Texture";
                textureFileText.Show();
                textureIndexText.Show();

                rtextureIdText.Hide();
                rtextureInstanceText.Hide();
                warningLabel.Hide();

                RemoteTexture = false;
            }
            else
            {
                textureButton.Text = "Remote Texture";
                rtextureIdText.Show();
                rtextureInstanceText.Show();
                warningLabel.Show();

                textureFileText.Hide();
                textureIndexText.Hide();

                RemoteTexture = true;
            }
        }
    }
}
