using MetroFramework.Forms;
using RotMG_Multitool.Serializers;
using System;
using System.Windows.Forms;

namespace RotMG_Multitool
{
    public partial class ItemCreatorForm : MetroForm
    {
        public ItemCreatorForm()
        {
            InitializeComponent();
        }

        public static bool remoteTexture = true;

        private void createXMLButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateThings();
                Item.Serialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), caption: "Error");
            }
        }

        private void UpdateThings()
        {
            try
            {
                Item.ObjectType = objectTypeText.Text;
                Item.ObjectId = objectIdText.Text;
                Item.Class = classText.Text;
                Item.DisplayName = displayNameText.Text;
                Item.RemoteTextureInstance = rtextureInstanceText.Text;
                Item.RemoteTextureID = rtextureIdText.Text;
                Item.TextureFile = textureFileText.Text;
                Item.TextureIndex = textureIndexText.Text;
                Item.SlotType = GetSlotTypeFromItem(slotTypeCombobox.Text);
                Item.Tier = int.Parse(tierText.Text);
                Item.Description = descriptionText.Text;
                Item.RateOfFire = int.Parse(rateOfFireText.Text);
                Item.BagType = GetBagTypeFromType(bagTypeCombobox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), caption: "Error");
            }
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

                remoteTexture = false;
            }
            else
            {
                textureButton.Text = "Remote Texture";
                rtextureIdText.Show();
                rtextureInstanceText.Show();
                warningLabel.Show();

                textureFileText.Hide();
                textureIndexText.Hide();

                remoteTexture = true;
            }
        }

        private int GetSlotTypeFromItem(string item)
        {
            switch (item)
            {
                case "Sword":
                    return 1;
                    break;

                case "Dagger":
                    return 2;
                    break;

                case "Bow":
                    return 3;
                    break;
                case "Wand":
                    return 8;
                    break;
                case "Staff":
                    return 17;
                    break;
                default:
                    return 1;
                    break;
            }
        }

        private int GetBagTypeFromType(string bagtype)
        {
            switch (bagtype)
            {
                case "Brown Bag":
                    return 0;
                    break;
                case "Purple Bag":
                    return 1;
                    break;
                case "High Tiered Bag":
                    return 2;
                    break;
                case "Potion Bag":
                    return 3;
                    break;
                case "White Bag":
                    return 4;
                    break;
                default:
                    return 4;
                    break;
            }
        }
    }
}
