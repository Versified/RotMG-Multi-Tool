namespace RotMG_Multitool
{
    partial class ItemCreatorForm
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
            this.objectTypeText = new System.Windows.Forms.TextBox();
            this.objectIdText = new System.Windows.Forms.TextBox();
            this.createXMLButton = new MetroFramework.Controls.MetroButton();
            this.classText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // objectTypeText
            // 
            this.objectTypeText.Location = new System.Drawing.Point(107, 63);
            this.objectTypeText.Name = "objectTypeText";
            this.objectTypeText.Size = new System.Drawing.Size(82, 20);
            this.objectTypeText.TabIndex = 0;
            this.objectTypeText.Text = "Object Type";
            // 
            // objectIdText
            // 
            this.objectIdText.Location = new System.Drawing.Point(195, 63);
            this.objectIdText.Name = "objectIdText";
            this.objectIdText.Size = new System.Drawing.Size(82, 20);
            this.objectIdText.TabIndex = 1;
            this.objectIdText.Text = "Item Name";
            // 
            // createXMLButton
            // 
            this.createXMLButton.Location = new System.Drawing.Point(318, 470);
            this.createXMLButton.Name = "createXMLButton";
            this.createXMLButton.Size = new System.Drawing.Size(75, 23);
            this.createXMLButton.TabIndex = 2;
            this.createXMLButton.Text = "Create";
            this.createXMLButton.UseSelectable = true;
            this.createXMLButton.Click += new System.EventHandler(this.createXMLButton_Click);
            // 
            // classText
            // 
            this.classText.Location = new System.Drawing.Point(23, 89);
            this.classText.Name = "classText";
            this.classText.Size = new System.Drawing.Size(82, 20);
            this.classText.TabIndex = 3;
            this.classText.Text = "Equipment";
            // 
            // ItemCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(403, 500);
            this.Controls.Add(this.classText);
            this.Controls.Add(this.createXMLButton);
            this.Controls.Add(this.objectIdText);
            this.Controls.Add(this.objectTypeText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ItemCreatorForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Item Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton createXMLButton;
        public System.Windows.Forms.TextBox objectIdText;
        public System.Windows.Forms.TextBox objectTypeText;
        public System.Windows.Forms.TextBox classText;
    }
}