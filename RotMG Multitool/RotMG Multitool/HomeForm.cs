using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotMG_Multitool
{
    public partial class HomeForm : MetroForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void itemCreatorButton_Click(object sender, EventArgs e)
        {
            ItemCreatorForm itemForm = new ItemCreatorForm();
            itemForm.ShowDialog();
        }
    }
}
