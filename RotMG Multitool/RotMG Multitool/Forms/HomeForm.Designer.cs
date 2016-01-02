namespace RotMG_Multitool
{
    partial class HomeForm
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
            this.itemCreatorButton = new MetroFramework.Controls.MetroButton();
            this.enemyCreatorButton = new MetroFramework.Controls.MetroButton();
            this.remoteTextureButton = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // itemCreatorButton
            // 
            this.itemCreatorButton.Location = new System.Drawing.Point(27, 60);
            this.itemCreatorButton.Name = "itemCreatorButton";
            this.itemCreatorButton.Size = new System.Drawing.Size(75, 23);
            this.itemCreatorButton.TabIndex = 4;
            this.itemCreatorButton.Text = "Item Creator";
            this.itemCreatorButton.UseSelectable = true;
            this.itemCreatorButton.Click += new System.EventHandler(this.itemCreatorButton_Click);
            // 
            // enemyCreatorButton
            // 
            this.enemyCreatorButton.Location = new System.Drawing.Point(108, 60);
            this.enemyCreatorButton.Name = "enemyCreatorButton";
            this.enemyCreatorButton.Size = new System.Drawing.Size(88, 23);
            this.enemyCreatorButton.TabIndex = 5;
            this.enemyCreatorButton.Text = "Enemy Creator";
            this.enemyCreatorButton.UseSelectable = true;
            this.enemyCreatorButton.Click += new System.EventHandler(this.enemyCreatorButton_Click);
            // 
            // remoteTextureButton
            // 
            this.remoteTextureButton.Location = new System.Drawing.Point(202, 60);
            this.remoteTextureButton.Name = "remoteTextureButton";
            this.remoteTextureButton.Size = new System.Drawing.Size(97, 23);
            this.remoteTextureButton.TabIndex = 6;
            this.remoteTextureButton.Text = "Remote Texture";
            this.remoteTextureButton.UseSelectable = true;
            this.remoteTextureButton.Click += new System.EventHandler(this.remoteTextureButton_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(93, 94);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(113, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Behavior Snippets";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(314, 128);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.remoteTextureButton);
            this.Controls.Add(this.enemyCreatorButton);
            this.Controls.Add(this.itemCreatorButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "RotMG Multi-Tool v0.1";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton itemCreatorButton;
        private MetroFramework.Controls.MetroButton enemyCreatorButton;
        private MetroFramework.Controls.MetroButton remoteTextureButton;
        private MetroFramework.Controls.MetroButton metroButton1;

    }
}

