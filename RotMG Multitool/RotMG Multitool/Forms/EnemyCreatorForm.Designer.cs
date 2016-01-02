namespace RotMG_Multitool.Forms
{
    partial class EnemyCreatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.warningLabel = new System.Windows.Forms.Label();
            this.rtextureIdText = new System.Windows.Forms.TextBox();
            this.rtextureInstanceText = new System.Windows.Forms.TextBox();
            this.textureIndexText = new System.Windows.Forms.TextBox();
            this.textureFileText = new System.Windows.Forms.TextBox();
            this.textureButton = new MetroFramework.Controls.MetroButton();
            this.classText = new System.Windows.Forms.TextBox();
            this.createXMLButton = new MetroFramework.Controls.MetroButton();
            this.objectIdText = new System.Windows.Forms.TextBox();
            this.objectTypeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeTextBoxText = new System.Windows.Forms.TextBox();
            this.defenseTextBoxText = new System.Windows.Forms.TextBox();
            this.healthTextBoxText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = System.Drawing.Color.White;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(6, 121);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(90, 13);
            this.warningLabel.TabIndex = 27;
            this.warningLabel.Text = "Don\'t change this";
            // 
            // rtextureIdText
            // 
            this.rtextureIdText.Location = new System.Drawing.Point(190, 118);
            this.rtextureIdText.Name = "rtextureIdText";
            this.rtextureIdText.Size = new System.Drawing.Size(82, 20);
            this.rtextureIdText.TabIndex = 26;
            this.rtextureIdText.Text = "Id";
            // 
            // rtextureInstanceText
            // 
            this.rtextureInstanceText.Location = new System.Drawing.Point(102, 118);
            this.rtextureInstanceText.Name = "rtextureInstanceText";
            this.rtextureInstanceText.Size = new System.Drawing.Size(82, 20);
            this.rtextureInstanceText.TabIndex = 25;
            this.rtextureInstanceText.Text = "draw";
            // 
            // textureIndexText
            // 
            this.textureIndexText.Location = new System.Drawing.Point(190, 118);
            this.textureIndexText.Name = "textureIndexText";
            this.textureIndexText.Size = new System.Drawing.Size(82, 20);
            this.textureIndexText.TabIndex = 24;
            this.textureIndexText.Text = "Index";
            // 
            // textureFileText
            // 
            this.textureFileText.Location = new System.Drawing.Point(102, 118);
            this.textureFileText.Name = "textureFileText";
            this.textureFileText.Size = new System.Drawing.Size(82, 20);
            this.textureFileText.TabIndex = 23;
            this.textureFileText.Text = "File";
            // 
            // textureButton
            // 
            this.textureButton.Location = new System.Drawing.Point(23, 170);
            this.textureButton.Name = "textureButton";
            this.textureButton.Size = new System.Drawing.Size(97, 23);
            this.textureButton.TabIndex = 22;
            this.textureButton.Text = "Remote Texture";
            this.textureButton.UseSelectable = true;
            this.textureButton.Click += new System.EventHandler(this.textureButton_Click);
            // 
            // classText
            // 
            this.classText.Location = new System.Drawing.Point(144, 92);
            this.classText.Name = "classText";
            this.classText.Size = new System.Drawing.Size(82, 20);
            this.classText.TabIndex = 20;
            this.classText.Text = "Character";
            // 
            // createXMLButton
            // 
            this.createXMLButton.Location = new System.Drawing.Point(241, 170);
            this.createXMLButton.Name = "createXMLButton";
            this.createXMLButton.Size = new System.Drawing.Size(75, 23);
            this.createXMLButton.TabIndex = 19;
            this.createXMLButton.Text = "Create";
            this.createXMLButton.UseSelectable = true;
            this.createXMLButton.Click += new System.EventHandler(this.createXMLButton_Click);
            // 
            // objectIdText
            // 
            this.objectIdText.Location = new System.Drawing.Point(190, 66);
            this.objectIdText.Name = "objectIdText";
            this.objectIdText.Size = new System.Drawing.Size(82, 20);
            this.objectIdText.TabIndex = 18;
            this.objectIdText.Text = "Enemy Name";
            // 
            // objectTypeText
            // 
            this.objectTypeText.Location = new System.Drawing.Point(102, 66);
            this.objectTypeText.Name = "objectTypeText";
            this.objectTypeText.Size = new System.Drawing.Size(82, 20);
            this.objectTypeText.TabIndex = 17;
            this.objectTypeText.Text = "Object Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Don\'t change this";
            // 
            // sizeTextBoxText
            // 
            this.sizeTextBoxText.Location = new System.Drawing.Point(102, 144);
            this.sizeTextBoxText.Name = "sizeTextBoxText";
            this.sizeTextBoxText.Size = new System.Drawing.Size(82, 20);
            this.sizeTextBoxText.TabIndex = 35;
            this.sizeTextBoxText.Text = "Size";
            // 
            // defenseTextBoxText
            // 
            this.defenseTextBoxText.Location = new System.Drawing.Point(190, 144);
            this.defenseTextBoxText.Name = "defenseTextBoxText";
            this.defenseTextBoxText.Size = new System.Drawing.Size(82, 20);
            this.defenseTextBoxText.TabIndex = 36;
            this.defenseTextBoxText.Text = "Defense";
            // 
            // healthTextBoxText
            // 
            this.healthTextBoxText.Location = new System.Drawing.Point(144, 170);
            this.healthTextBoxText.Name = "healthTextBoxText";
            this.healthTextBoxText.Size = new System.Drawing.Size(82, 20);
            this.healthTextBoxText.TabIndex = 37;
            this.healthTextBoxText.Text = "Health";
            // 
            // EnemyCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(339, 207);
            this.Controls.Add(this.healthTextBoxText);
            this.Controls.Add(this.defenseTextBoxText);
            this.Controls.Add(this.sizeTextBoxText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.rtextureIdText);
            this.Controls.Add(this.rtextureInstanceText);
            this.Controls.Add(this.textureIndexText);
            this.Controls.Add(this.textureFileText);
            this.Controls.Add(this.textureButton);
            this.Controls.Add(this.classText);
            this.Controls.Add(this.createXMLButton);
            this.Controls.Add(this.objectIdText);
            this.Controls.Add(this.objectTypeText);
            this.MaximizeBox = false;
            this.Name = "EnemyCreatorForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Enemy Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label warningLabel;
        public System.Windows.Forms.TextBox rtextureIdText;
        public System.Windows.Forms.TextBox rtextureInstanceText;
        public System.Windows.Forms.TextBox textureIndexText;
        public System.Windows.Forms.TextBox textureFileText;
        private MetroFramework.Controls.MetroButton textureButton;
        private MetroFramework.Controls.MetroButton createXMLButton;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox objectTypeText;
        public System.Windows.Forms.TextBox objectIdText;
        public System.Windows.Forms.TextBox classText;
        public System.Windows.Forms.TextBox sizeTextBoxText;
        public System.Windows.Forms.TextBox defenseTextBoxText;
        public System.Windows.Forms.TextBox healthTextBoxText;
    }
}