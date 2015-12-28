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
            this.itemIdTextbox = new System.Windows.Forms.TextBox();
            this.itemNameTextbox = new System.Windows.Forms.TextBox();
            this.createXMLButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // itemIdTextbox
            // 
            this.itemIdTextbox.Location = new System.Drawing.Point(107, 63);
            this.itemIdTextbox.Name = "itemIdTextbox";
            this.itemIdTextbox.Size = new System.Drawing.Size(82, 20);
            this.itemIdTextbox.TabIndex = 0;
            this.itemIdTextbox.Text = "Object ID";
            // 
            // itemNameTextbox
            // 
            this.itemNameTextbox.Location = new System.Drawing.Point(195, 63);
            this.itemNameTextbox.Name = "itemNameTextbox";
            this.itemNameTextbox.Size = new System.Drawing.Size(82, 20);
            this.itemNameTextbox.TabIndex = 1;
            this.itemNameTextbox.Text = "Item Name";
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
            // ItemCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.createXMLButton);
            this.Controls.Add(this.itemNameTextbox);
            this.Controls.Add(this.itemIdTextbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ItemCreatorForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Item Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemIdTextbox;
        private System.Windows.Forms.TextBox itemNameTextbox;
        private MetroFramework.Controls.MetroButton createXMLButton;

    }
}