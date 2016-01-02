﻿using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using RotMG_Multitool.Serializers;

namespace RotMG_Multitool.Forms
{
    public partial class ItemCreatorForm : MetroForm
    {
<<<<<<< HEAD
        private readonly Item serializer;
=======
        Item item = new Item();
>>>>>>> origin/master

        public ItemCreatorForm()
        {
            InitializeComponent();
            serializer = new Item(this);
            RemoteTexture = true;
        }

        public bool RemoteTexture { get; set; }

        private void createXMLButton_Click(object sender, EventArgs e)
        {
            try
            {
<<<<<<< HEAD
                if (updateThings())
                    serializer.Serialize();
=======
                setPropertyValues();
                item.Serialize();
>>>>>>> origin/master
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

<<<<<<< HEAD
        private bool updateThings()
        {
            try
            {
                serializer.ObjectType = objectTypeText.Text;
                serializer.ObjectId = objectIdText.Text;
                serializer.Class = classText.Text;
                serializer.DisplayName = displayNameText.Text;
                serializer.RemoteTextureInstance = rtextureInstanceText.Text;
                serializer.RemoteTextureId = rtextureIdText.Text;
                serializer.TextureFile = textureFileText.Text;
                serializer.TextureIndex = textureIndexText.Text;
                serializer.SlotType = getSlotTypeFromItem(slotTypeCombobox.Text);
                int tier;
                if (!int.TryParse(tierText.Text, out tier))
                {
                    MetroMessageBox.Show(this, "Invalid value for \"Tier\"", "Invalid Integer", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                serializer.Tier = tier;
                serializer.Description = descriptionText.Text;
                int rateOfFire;
                if (!int.TryParse(rateOfFireText.Text, out rateOfFire))
                {
                    MetroMessageBox.Show(this, "Invalid value for \"Rate of Fire\"", "Invalid Integer", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                serializer.RateOfFire = rateOfFire;
                serializer.BagType = getBagTypeFromType(bagTypeCombobox.Text);
=======
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
>>>>>>> origin/master
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

        private static int getSlotTypeFromItem(string item)
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

        private static int getBagTypeFromType(string bagtype)
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

        private void ItemCreatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}