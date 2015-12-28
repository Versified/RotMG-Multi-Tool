using MetroFramework.Forms;
using RotMG_Multitool.Serializers;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace RotMG_Multitool
{
    public partial class ItemCreatorForm : MetroForm
    {
        public ItemCreatorForm()
        {
            InitializeComponent();
        }

        private void createXMLButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateThings();
                Item.Serialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), caption: "Error");
            }
        }

        private void UpdateThings()
        {
            try
            {
                Item.ObjectType = ushort.Parse(objectTypeText.Text, NumberStyles.HexNumber);
                Item.ObjectId = objectIdText.Text;
                Item.Class = classText.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), caption: "Error");
            }
        }
    }
}
