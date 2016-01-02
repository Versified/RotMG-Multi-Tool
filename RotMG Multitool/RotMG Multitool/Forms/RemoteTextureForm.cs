using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using MetroFramework.Forms;
using Microsoft.VisualBasic;
using MetroFramework;

namespace RotMG_Multitool.Forms
{
    public partial class RemoteTextureForm : MetroForm
    {
        private readonly ListViewItem[] realItems;
        private int perPage = 200;
        private bool hasClicked;

        public RemoteTextureForm()
        {
            InitializeComponent();
            realItems = new ListViewItem[perPage];
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                listOfName.Clear();

                hasClicked = true;

                var wc = new WebClient();
                var result = wc.DownloadString("http://realmofthemadgod.appspot.com/picture/list?num=" + perPage + "&tags=" + textBox1.Text);

                var xDoc = XDocument.Parse(result);
                var pics = new List<Picture>();

                if (!(xDoc.Root?.HasElements ?? false)) return;
                pics.AddRange(xDoc.Root.Elements("Pic").Select(Picture.FromXElement));

                foreach (var p in pics)
                    listOfName.Items.Add(new ListViewItem
                    {
                        Text = p.Name,
                        Tag = p.ID
                    });
                listOfName.Items.CopyTo(realItems, 0);
            }
            else
                MetroMessageBox.Show(this, "You must enter a tag to search for first", "Silly you", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public class Picture
        {
            public long ID;
            public string Name;

            public static Picture FromXElement(XElement x)
            {
                return new Picture()
                {
                   ID = Convert.ToInt64(x.Attribute("id").Value),
                   Name = x.Element("PicName").Value
                };
            }
        }

        private void listOfName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = listOfName.SelectedItems[0].Tag.ToString();
                pictureBox1.Load("http://realmofthemadgod.appspot.com/picture/get?id=" + listOfName.SelectedItems[0].Tag.ToString());
            }
            catch
            {
            }
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (hasClicked)
            {
                saveFileDialog1.FileName = listOfName.SelectedItems[0].Text.ToString();

                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
            else
            {
                MetroMessageBox.Show(this, "You must choose an image to save first", "Silly you", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Special Thanks to Travoos", "Thanks", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Here you can set how many objects appear", "Input Value");
            var howManyPerPage = Interaction.InputBox("How many objects to show (Don't go overboard or R.I.P)", "Configuration", "200", -1, -1);
            int val;
            if (Int32.TryParse(howManyPerPage, out val))
                perPage = val;
        }
    }
}
