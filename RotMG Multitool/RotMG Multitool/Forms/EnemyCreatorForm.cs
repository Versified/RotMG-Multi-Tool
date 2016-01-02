using MetroFramework.Forms;
using RotMG_Multitool.Serializers;
using System;
using System.Windows.Forms;

namespace RotMG_Multitool
{
    public partial class EnemyCreatorForm : MetroForm
    {
        Enemy enemy = new Enemy();

        public EnemyCreatorForm()
        {
            InitializeComponent();
        }

        private void enemyCreatorForm_Load(object sender, System.EventArgs e)
        {
        }

        private void createXMLButton_Click(object sender, EventArgs e)
        {
            enemy.Serialize();
        }
    }
}
