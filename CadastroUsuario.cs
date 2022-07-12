using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAutenticidade
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
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

        private void ckbDiretorDivisao_CheckedChanged(object sender, EventArgs e)
        {
            ckbMinistroDoMeioAmbiente.Checked = false;

        }

        private void ckbMinistroDoMeioAmbiente_CheckedChanged(object sender, EventArgs e)
        {
            ckbDiretorDivisao.Checked = false;

        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                #region Validações do Cadastro   
                if (ckbDiretorDivisao.Checked.Equals(false) && ckbMinistroDoMeioAmbiente.Checked.Equals(false))
                {
                    throw new Exception("Para efetuar o cadastro, é necessário selecionar o tipo de perfil!");
                }
                if(nomeArquivo.Equals(null))
                {
                    throw new Exception("Para efetuar o cadastro, é necessário arquivar uma imagem!");
                }
                if(txtNome.Text.Equals(string.Empty))
                {
                    throw new Exception("Para efetuar o cadastro, é necessário informar um nome de Usuário!");
                }
                #endregion 

                pgBar.Visible = true;
                btnLimparImagem.Enabled = true;
                string refPixels;
                imagem = new Bitmap(nomeArquivo);
                pgBar.Maximum = imagem.Width;

                //Validação para a dimensão da Imagem
                if (imagem.Width != 300 && imagem.Height != 300)
                {
                    throw new Exception("Para efetuar o cadastro, é necessário que a imagem tenha Dimensões 300 x 300!");
                }

                #region um for para para verificar a coloração da Imagem
                for (int x = 0; x < imagem.Width; x++)
                {
                    for (int y = 0; y < imagem.Height; y++)
                    {
                        //img_ref para pegar as dimensões de cada pixel da Imagem
                        refPixels = imagem.GetPixel(x, y).ToString();

                        //O cont pega os valores das colorações de cada pixel da imagem
                        cont += refPixels.Replace("Color [A=", "").Replace(", R=", "").Replace(", G=", "").Replace(", B=", "").Replace("]", "");

                    }
                    pgBar.Value++;
                }
                #endregion

                //Validação do Checkbox para a variável usuario, se for 1: Diretor(a) de divisões, 2: Ministro(a) do meio Ambiente
                if (ckbDiretorDivisao.Checked.Equals(true))
                {
                    usuario = 1;
                }
                else { usuario = 2; }

                #region Inserção no Banco de Dados
                string nome = txtNome.Text;
                String resultado;
                clsConexao con = new clsConexao();
                resultado = con.InserirDados("Insert Acesso_Biometrico(Nome_Usuario, Usuario, Cod_Biometrico) values ('"+nome+"',"+ usuario +",'"+ cont +"')");         
                MessageBox.Show("Inserido com sucesso no banco de dados!");

                //Após inserir no banco, os campos são esvaziados
                txtNome.Text = string.Empty;
                ImagemBOX.Image = null;
                pgBar.Value = 0;
                cont = string.Empty;
                #endregion
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
