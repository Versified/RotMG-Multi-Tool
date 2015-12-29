using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RotMG_Multitool
{
    partial class ItemCreatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.objectTypeText = new TextBox();
            this.objectIdText = new TextBox();
            this.createXMLButton = new MetroButton();
            this.displayNameText = new TextBox();
            this.textureButton = new MetroButton();
            this.classText = new TextBox();
            this.textureFileText = new TextBox();
            this.textureIndexText = new TextBox();
            this.rtextureInstanceText = new TextBox();
            this.rtextureIdText = new TextBox();
            this.warningLabel = new Label();
            this.slotTypeCombobox = new MetroComboBox();
            this.tierText = new TextBox();
            this.label1 = new Label();
            this.descriptionText = new TextBox();
            this.rateOfFireText = new TextBox();
            this.bagTypeCombobox = new MetroComboBox();
            this.SuspendLayout();
            // 
            // objectTypeText
            // 
            this.objectTypeText.Location = new Point(107, 63);
            this.objectTypeText.Name = "objectTypeText";
            this.objectTypeText.Size = new Size(82, 20);
            this.objectTypeText.TabIndex = 0;
            this.objectTypeText.Text = "Object Type";
            // 
            // objectIdText
            // 
            this.objectIdText.Location = new Point(195, 63);
            this.objectIdText.Name = "objectIdText";
            this.objectIdText.Size = new Size(82, 20);
            this.objectIdText.TabIndex = 1;
            this.objectIdText.Text = "Item Name";
            // 
            // createXMLButton
            // 
            this.createXMLButton.Location = new Point(255, 281);
            this.createXMLButton.Name = "createXMLButton";
            this.createXMLButton.Size = new Size(75, 23);
            this.createXMLButton.TabIndex = 2;
            this.createXMLButton.Text = "Create";
            this.createXMLButton.UseSelectable = true;
            this.createXMLButton.Click += new EventHandler(this.createXMLButton_Click);
            // 
            // displayNameText
            // 
            this.displayNameText.Location = new Point(195, 89);
            this.displayNameText.Name = "displayNameText";
            this.displayNameText.Size = new Size(82, 20);
            this.displayNameText.TabIndex = 4;
            this.displayNameText.Text = "Display Name";
            // 
            // textureButton
            // 
            this.textureButton.Location = new Point(25, 281);
            this.textureButton.Name = "textureButton";
            this.textureButton.Size = new Size(97, 23);
            this.textureButton.TabIndex = 5;
            this.textureButton.Text = "Remote Texture";
            this.textureButton.UseSelectable = true;
            this.textureButton.Click += new EventHandler(this.textureButton_Click);
            // 
            // classText
            // 
            this.classText.Location = new Point(107, 89);
            this.classText.Name = "classText";
            this.classText.Size = new Size(82, 20);
            this.classText.TabIndex = 3;
            this.classText.Text = "Equipment";
            // 
            // textureFileText
            // 
            this.textureFileText.Location = new Point(107, 115);
            this.textureFileText.Name = "textureFileText";
            this.textureFileText.Size = new Size(82, 20);
            this.textureFileText.TabIndex = 6;
            this.textureFileText.Text = "File";
            // 
            // textureIndexText
            // 
            this.textureIndexText.Location = new Point(195, 115);
            this.textureIndexText.Name = "textureIndexText";
            this.textureIndexText.Size = new Size(82, 20);
            this.textureIndexText.TabIndex = 7;
            this.textureIndexText.Text = "Index";
            // 
            // rtextureInstanceText
            // 
            this.rtextureInstanceText.Location = new Point(107, 115);
            this.rtextureInstanceText.Name = "rtextureInstanceText";
            this.rtextureInstanceText.Size = new Size(82, 20);
            this.rtextureInstanceText.TabIndex = 8;
            this.rtextureInstanceText.Text = "draw";
            // 
            // rtextureIdText
            // 
            this.rtextureIdText.Location = new Point(195, 115);
            this.rtextureIdText.Name = "rtextureIdText";
            this.rtextureIdText.Size = new Size(82, 20);
            this.rtextureIdText.TabIndex = 9;
            this.rtextureIdText.Text = "Id";
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = Color.White;
            this.warningLabel.ForeColor = Color.Red;
            this.warningLabel.Location = new Point(11, 118);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new Size(90, 13);
            this.warningLabel.TabIndex = 10;
            this.warningLabel.Text = "Don\'t change this";
            // 
            // slotTypeCombobox
            // 
            this.slotTypeCombobox.FormattingEnabled = true;
            this.slotTypeCombobox.ItemHeight = 23;
            this.slotTypeCombobox.Items.AddRange(new object[] {
            "Sword",
            "Dagger",
            "Bow",
            "Wand",
            "Staff"});
            this.slotTypeCombobox.Location = new Point(128, 141);
            this.slotTypeCombobox.Name = "slotTypeCombobox";
            this.slotTypeCombobox.Size = new Size(121, 29);
            this.slotTypeCombobox.Style = MetroFramework.MetroColorStyle.Purple;
            this.slotTypeCombobox.TabIndex = 11;
            this.slotTypeCombobox.UseSelectable = true;
            // 
            // tierText
            // 
            this.tierText.Location = new Point(149, 176);
            this.tierText.Name = "tierText";
            this.tierText.Size = new Size(82, 20);
            this.tierText.TabIndex = 12;
            this.tierText.Text = "Tier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.White;
            this.label1.ForeColor = Color.Red;
            this.label1.Location = new Point(63, 179);
            this.label1.Name = "label1";
            this.label1.Size = new Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Set to -1 for UT";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new Point(107, 202);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new Size(170, 41);
            this.descriptionText.TabIndex = 14;
            this.descriptionText.Text = "Description";
            // 
            // rateOfFireText
            // 
            this.rateOfFireText.Location = new Point(149, 249);
            this.rateOfFireText.Name = "rateOfFireText";
            this.rateOfFireText.Size = new Size(82, 20);
            this.rateOfFireText.TabIndex = 15;
            this.rateOfFireText.Text = "Rate of Fire";
            // 
            // bagTypeCombobox
            // 
            this.bagTypeCombobox.FormattingEnabled = true;
            this.bagTypeCombobox.ItemHeight = 23;
            this.bagTypeCombobox.Items.AddRange(new object[] {
            "Brown Bag",
            "Purple Bag",
            "High Tiered Bag",
            "Potion Bag",
            "White Bag"});
            this.bagTypeCombobox.Location = new Point(128, 275);
            this.bagTypeCombobox.Name = "bagTypeCombobox";
            this.bagTypeCombobox.Size = new Size(121, 29);
            this.bagTypeCombobox.Style = MetroColorStyle.Purple;
            this.bagTypeCombobox.TabIndex = 16;
            this.bagTypeCombobox.UseSelectable = true;
            // 
            // ItemCreatorForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new Size(340, 318);
            this.Controls.Add(this.bagTypeCombobox);
            this.Controls.Add(this.rateOfFireText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tierText);
            this.Controls.Add(this.slotTypeCombobox);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.rtextureIdText);
            this.Controls.Add(this.rtextureInstanceText);
            this.Controls.Add(this.textureIndexText);
            this.Controls.Add(this.textureFileText);
            this.Controls.Add(this.textureButton);
            this.Controls.Add(this.displayNameText);
            this.Controls.Add(this.classText);
            this.Controls.Add(this.createXMLButton);
            this.Controls.Add(this.objectIdText);
            this.Controls.Add(this.objectTypeText);
            this.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ItemCreatorForm";
            this.Resizable = false;
            this.Style = MetroColorStyle.Purple;
            this.Text = "Item Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroButton createXMLButton;
        public TextBox objectIdText;
        public TextBox objectTypeText;
        public TextBox displayNameText;
        private MetroButton textureButton;
        public TextBox classText;
        public TextBox textureFileText;
        public TextBox textureIndexText;
        public TextBox rtextureInstanceText;
        public TextBox rtextureIdText;
        private Label warningLabel;
        private MetroComboBox slotTypeCombobox;
        public TextBox tierText;
        private Label label1;
        public TextBox descriptionText;
        public TextBox rateOfFireText;
        private MetroComboBox bagTypeCombobox;
    }
}