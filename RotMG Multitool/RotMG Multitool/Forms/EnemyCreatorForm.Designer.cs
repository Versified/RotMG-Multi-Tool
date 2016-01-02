namespace RotMG_Multitool
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
            this.createXMLButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // createXMLButton
            // 
            this.createXMLButton.Location = new System.Drawing.Point(218, 268);
            this.createXMLButton.Name = "createXMLButton";
            this.createXMLButton.Size = new System.Drawing.Size(75, 23);
            this.createXMLButton.TabIndex = 3;
            this.createXMLButton.Text = "Create";
            this.createXMLButton.UseSelectable = true;
            this.createXMLButton.Click += new System.EventHandler(this.createXMLButton_Click);
            // 
            // EnemyCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.createXMLButton);
            this.MaximizeBox = false;
            this.Name = "EnemyCreatorForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Enemy Creator";
            this.Load += new System.EventHandler(this.enemyCreatorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton createXMLButton;
    }
}