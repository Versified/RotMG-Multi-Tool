using MetroFramework.Forms;
using System;

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
            ItemCreatorForm form = new ItemCreatorForm();
            form.ShowDialog();
        }

        private void enemyCreatorButton_Click(object sender, EventArgs e)
        {
            enemyCreatorForm form = new enemyCreatorForm();
            form.ShowDialog();
        }

        private void remoteTextureButton_Click(object sender, EventArgs e)
        {
            remoteTextureForm form = new remoteTextureForm();
            form.ShowDialog();
        }
    }
}
