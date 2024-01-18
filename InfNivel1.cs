using System;
using System.Windows.Forms;

namespace ProjetoAutenticidade
{
    public partial class InfNivel1 : Form
    {
        public InfNivel1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            InitialMenu form1 = new InitialMenu();

            form1.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
