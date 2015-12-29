using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;


namespace RotMG_Multitool
{
    public partial class remoteTextureForm : MetroForm
    {
        ListViewItem[] realItems;
        int perPage = 200;
        bool hasClicked = false;

        public remoteTextureForm()
        {
            InitializeComponent();
            realItems = new ListViewItem[perPage];
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                hasClicked = true;
                listOfName.Clear();
                WebClient wc = new WebClient();
                string result = wc.DownloadString("http://realmofthemadgod.appspot.com/picture/list?num=" + perPage + "&tags=" + textBox1.Text);

                XDocument xDoc = XDocument.Parse(result);
                List<Picture> pics = new List<Picture>();

                if (xDoc.Root.HasElements)
                {
                    foreach (XElement x in xDoc.Root.Elements("Pic"))
                        pics.Add(Picture.FromXElement(x));

                    foreach (var p in pics)
                    {
                        listOfName.Items.Add(new ListViewItem
                        {
                            Text = p.Name,
                            Tag = p.ID
                        });
                    }
                    listOfName.Items.CopyTo(realItems, 0);
                }
            }
            else
            {
                MessageBox.Show("You must enter a tag to search for first", "Silly you");
            }
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
                MessageBox.Show("You must choose an image to save first", "Silly you");
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Special Thanks to Travoos");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can set how many objects appear");
            string howManyPerPage = Interaction.InputBox("How many objects to show (Don't go overboard or R.I.P)", "Configuration", "200", -1, -1);
            perPage = int.Parse(howManyPerPage);
        }
    }
}
