using System;
using MetroFramework.Forms;

namespace RotMG_Multitool.Forms
{
    public partial class HomeForm : MetroForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void itemCreatorButton_Click(object sender, EventArgs e)
        {
            var form = new ItemCreatorForm();
            form.ShowDialog();
        }

        private void enemyCreatorButton_Click(object sender, EventArgs e)
        {
            var form = new EnemyCreatorForm();
            form.ShowDialog();
        }

        private void remoteTextureButton_Click(object sender, EventArgs e)
        {
            var form = new RemoteTextureForm();
            form.ShowDialog();
        }
    }
}
