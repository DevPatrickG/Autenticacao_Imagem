using System;
using System.Windows.Forms;

namespace ProjetoAutenticidade
{
    public partial class InitialMenu : Form
    {
        public InitialMenu()
        {
            InitializeComponent();
        }

        private void btnRegistrationAccess_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfNvl1_Click(object sender, EventArgs e)
        {
            InfNivel1 infNivel1 = new InfNivel1();
            infNivel1.ShowDialog();
        }

        private void btnInfNvl2_Click(object sender, EventArgs e)
        {
            InfNivel2 infNivel2 = new InfNivel2();
            infNivel2.ShowDialog();
        }

        private void btnInfNvl3_Click(object sender, EventArgs e)
        {
            InfNivel3 infNivel3 = new InfNivel3();
            infNivel3.ShowDialog();
        }
    }
}
