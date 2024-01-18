using System;
using System.Windows.Forms;

namespace ProjetoAutenticidade
{
    public partial class InfNivel2Autenticada : Form
    {
        public InfNivel2Autenticada()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InfNivel2 infNivel2 = new InfNivel2();
            infNivel2.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
