
namespace ProjetoAutenticidade
{
    partial class CadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ImagemBOX = new System.Windows.Forms.PictureBox();
            this.btnAnexarImagem = new System.Windows.Forms.Button();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnLimparImagem = new System.Windows.Forms.Button();
            this.ckbDiretorDivisao = new System.Windows.Forms.CheckBox();
            this.ckbMinistroDoMeioAmbiente = new System.Windows.Forms.CheckBox();
            this.btnSalvarCadastro = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltar.Location = new System.Drawing.Point(12, 374);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(117, 64);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ImagemBOX
            // 
            this.ImagemBOX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ImagemBOX.Location = new System.Drawing.Point(256, 26);
            this.ImagemBOX.Name = "ImagemBOX";
            this.ImagemBOX.Size = new System.Drawing.Size(289, 218);
            this.ImagemBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemBOX.TabIndex = 1;
            this.ImagemBOX.TabStop = false;
            // 
            // btnAnexarImagem
            // 
            this.btnAnexarImagem.Location = new System.Drawing.Point(256, 250);
            this.btnAnexarImagem.Name = "btnAnexarImagem";
            this.btnAnexarImagem.Size = new System.Drawing.Size(289, 25);
            this.btnAnexarImagem.TabIndex = 2;
            this.btnAnexarImagem.Text = "ANEXAR IMAGEM";
            this.btnAnexarImagem.UseVisualStyleBackColor = true;
            this.btnAnexarImagem.Click += new System.EventHandler(this.btnAnexarImagem_Click);
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(256, 393);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(261, 36);
            this.pgBar.TabIndex = 3;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog";
            // 
            // btnLimparImagem
            // 
            this.btnLimparImagem.Location = new System.Drawing.Point(559, 107);
            this.btnLimparImagem.Name = "btnLimparImagem";
            this.btnLimparImagem.Size = new System.Drawing.Size(117, 37);
            this.btnLimparImagem.TabIndex = 4;
            this.btnLimparImagem.Text = "LIMPAR IMAGEM";
            this.btnLimparImagem.UseVisualStyleBackColor = true;
            this.btnLimparImagem.Click += new System.EventHandler(this.btnLimparImagem_Click);
            // 
            // ckbDiretorDivisao
            // 
            this.ckbDiretorDivisao.AutoSize = true;
            this.ckbDiretorDivisao.Location = new System.Drawing.Point(256, 319);
            this.ckbDiretorDivisao.Name = "ckbDiretorDivisao";
            this.ckbDiretorDivisao.Size = new System.Drawing.Size(110, 17);
            this.ckbDiretorDivisao.TabIndex = 5;
            this.ckbDiretorDivisao.Text = "Diretor de Divisão";
            this.ckbDiretorDivisao.UseVisualStyleBackColor = true;
            this.ckbDiretorDivisao.CheckedChanged += new System.EventHandler(this.ckbDiretorDivisao_CheckedChanged);
            // 
            // ckbMinistroDoMeioAmbiente
            // 
            this.ckbMinistroDoMeioAmbiente.AutoSize = true;
            this.ckbMinistroDoMeioAmbiente.Location = new System.Drawing.Point(405, 319);
            this.ckbMinistroDoMeioAmbiente.Name = "ckbMinistroDoMeioAmbiente";
            this.ckbMinistroDoMeioAmbiente.Size = new System.Drawing.Size(150, 17);
            this.ckbMinistroDoMeioAmbiente.TabIndex = 6;
            this.ckbMinistroDoMeioAmbiente.Text = "Ministro do Meio Ambiente";
            this.ckbMinistroDoMeioAmbiente.UseVisualStyleBackColor = true;
            this.ckbMinistroDoMeioAmbiente.CheckedChanged += new System.EventHandler(this.ckbMinistroDoMeioAmbiente_CheckedChanged);
            // 
            // btnSalvarCadastro
            // 
            this.btnSalvarCadastro.Location = new System.Drawing.Point(335, 342);
            this.btnSalvarCadastro.Name = "btnSalvarCadastro";
            this.btnSalvarCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalvarCadastro.Size = new System.Drawing.Size(94, 36);
            this.btnSalvarCadastro.TabIndex = 7;
            this.btnSalvarCadastro.Text = "Salvar Cadastro";
            this.btnSalvarCadastro.UseVisualStyleBackColor = true;
            this.btnSalvarCadastro.Click += new System.EventHandler(this.btnSalvarCadastro_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(366, 281);
            this.txtNome.MaxLength = 10;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(179, 20);
            this.txtNome.TabIndex = 8;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(253, 284);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(110, 13);
            this.lblNomeUsuario.TabIndex = 9;
            this.lblNomeUsuario.Text = "NOME DO USUÁRIO";
            // 
            // btnSair
            // 
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(712, 374);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 67);
            this.btnSair.TabIndex = 20;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvarCadastro);
            this.Controls.Add(this.ckbMinistroDoMeioAmbiente);
            this.Controls.Add(this.ckbDiretorDivisao);
            this.Controls.Add(this.btnLimparImagem);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.btnAnexarImagem);
            this.Controls.Add(this.ImagemBOX);
            this.Controls.Add(this.btnVoltar);
            this.Name = "CadastroUsuario";
            this.Text = "Cadastro de Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox ImagemBOX;
        private System.Windows.Forms.Button btnAnexarImagem;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnLimparImagem;
        private System.Windows.Forms.CheckBox ckbDiretorDivisao;
        private System.Windows.Forms.CheckBox ckbMinistroDoMeioAmbiente;
        private System.Windows.Forms.Button btnSalvarCadastro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Button btnSair;
    }
}