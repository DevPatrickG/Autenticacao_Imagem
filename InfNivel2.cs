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
    public partial class InfNivel2 : Form
    {
        public InfNivel2()
        {
            InitializeComponent();
        }

        static string nomeArquivo;
        Bitmap imagem;
        string cont;
        int usuario = 0;
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnAnexarImagem_Click(object sender, EventArgs e)
        {
            ofd.FileName = "";
            ofd.Title = "Imagens";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
           

            ofd.ShowDialog();
            if (ofd.FileName.ToString() != "")
            {
                nomeArquivo = ofd.FileName.ToString();
                ImagemBOX.Image = new Bitmap(nomeArquivo);
            }
        }

        private void btnLimparImagem_Click(object sender, EventArgs e)
        {
            ImagemBOX.Image = null;
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (nomeArquivo.Equals(null))
                {
                    throw new Exception("Para efetuar o cadastro, é necessário arquivar uma imagem!");
                }
                if (txtNome.Text.Equals(string.Empty))
                {
                    throw new Exception("Para efetuar o cadastro, é necessário informar um nome de Usuário!");
                }

                pgBar.Visible = true;
                btnLimparImagem.Enabled = true;

                string refPixels;
                imagem = new Bitmap(nomeArquivo);
                cont = string.Empty;

                pgBar.Maximum = imagem.Width;
               
                for (int x = 0; x < imagem.Width; x++)
                {
                    for (int y = 0; y < imagem.Height; y++)
                    {
                        refPixels = imagem.GetPixel(x, y).ToString();

                        cont += refPixels.Replace("Color [A=", "").Replace(", R=", "").Replace(", G=", "").Replace(", B=", "").Replace("]", "");

                    }
                    pgBar.Value++;
                }
                usuario = 1;
                SqlDataReader dados;

                #region Valores Biométricos para consultar no banco (Pixels do inicio, Meio e fim da Imagem)
                string iniBiometria = cont.Substring(0, 7900);
                string medBiometria = cont.Substring(400000, 7900);
                string fimBiometria = cont.Substring(cont.Length - 7900);
                #endregion

                clsConexao clsConexao = new clsConexao();
                dados = clsConexao.Consulta("select * from Acesso_Biometrico where Nome_Usuario = '" + txtNome.Text +"' and Usuario = " +
                    "" + usuario + " and Cod_Biometrico LIKE '" + iniBiometria + "%' and Cod_Biometrico LIKE '%" + medBiometria +"%' and " +
                    "Cod_Biometrico LIKE '%" + fimBiometria +"'");
                string teste = string.Empty;

                
                pgBar.Value = 0;
                if (dados.Read())
                {
                    InfNivel2Autenticada infNivel2Autenticada = new InfNivel2Autenticada();
                    infNivel2Autenticada.ShowDialog();
                }
                else
                {throw new Exception("Autenticação Negada!");}
               
         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
