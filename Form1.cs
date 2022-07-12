using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAutenticidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCadastroAcesso_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadastroUsuario = new CadastroUsuario();
            cadastroUsuario.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
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
