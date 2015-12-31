using MetroFramework.Forms;
using RotMG_Multitool.Serializers;
using System;
using System.Windows.Forms;

namespace RotMG_Multitool
{
    public partial class ItemCreatorForm : MetroForm
    {
        Item item = new Item();

        public ItemCreatorForm()
        {
            InitializeComponent();
        }

        public static bool remoteTexture = true;

        private void createXMLButton_Click(object sender, EventArgs e)
        {
            try
            {
                setPropertyValues();
                item.Serialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), caption: "Error");
            }
        }

        private void setPropertyValues()
        {
            try
            {
                item.ObjectType = objectTypeText.Text;
                item.ObjectId = objectIdText.Text;
                item.Class = classText.Text;
                item.DisplayName = displayNameText.Text;
                item.RemoteTextureInstance = rtextureInstanceText.Text;
                item.RemoteTextureID = rtextureIdText.Text;
                item.TextureFile = textureFileText.Text;
                item.TextureIndex = textureIndexText.Text;
                item.SlotType = GetSlotTypeFromItem(slotTypeCombobox.Text);
                item.Tier = int.Parse(tierText.Text);
                item.Description = descriptionText.Text;
                item.RateOfFire = int.Parse(rateOfFireText.Text);
                item.BagType = GetBagTypeFromType(bagTypeCombobox.Text);
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
                case "Sword": return 1;
                case "Dagger": return 2;
                case "Bow": return 3;
                case "Wand": return 8;
                case "Staff": return 17;
                default: return 1;
            }
        }

        private int GetBagTypeFromType(string bagtype)
        {
            switch (bagtype)
            {
                case "Brown Bag": return 0;
                case "Purple Bag": return 1;
                case "High Tiered Bag": return 2;
                case "Potion Bag": return 3;
                case "White Bag": return 4;
                default: return 4;
            }
        }
    }
}