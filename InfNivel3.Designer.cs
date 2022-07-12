
namespace ProjetoAutenticidade
{
    partial class InfNivel3
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
            this.btnAutenticar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnLimparImagem = new System.Windows.Forms.Button();
            this.btnAnexarImagem = new System.Windows.Forms.Button();
            this.ImagemBOX = new System.Windows.Forms.PictureBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAutenticar
            // 
            this.btnAutenticar.Location = new System.Drawing.Point(325, 349);
            this.btnAutenticar.Name = "btnAutenticar";
            this.btnAutenticar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAutenticar.Size = new System.Drawing.Size(94, 36);
            this.btnAutenticar.TabIndex = 22;
            this.btnAutenticar.Text = "Autenticar";
            this.btnAutenticar.UseVisualStyleBackColor = true;
            this.btnAutenticar.Click += new System.EventHandler(this.btnAutenticar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(361, 308);
            this.txtNome.MaxLength = 10;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 20);
            this.txtNome.TabIndex = 21;
            // 
            // btnLimparImagem
            // 
            this.btnLimparImagem.Location = new System.Drawing.Point(543, 110);
            this.btnLimparImagem.Name = "btnLimparImagem";
            this.btnLimparImagem.Size = new System.Drawing.Size(117, 37);
            this.btnLimparImagem.TabIndex = 20;
            this.btnLimparImagem.Text = "LIMPAR IMAGEM";
            this.btnLimparImagem.UseVisualStyleBackColor = true;
            this.btnLimparImagem.Click += new System.EventHandler(this.btnLimparImagem_Click);
            // 
            // btnAnexarImagem
            // 
            this.btnAnexarImagem.Location = new System.Drawing.Point(248, 263);
            this.btnAnexarImagem.Name = "btnAnexarImagem";
            this.btnAnexarImagem.Size = new System.Drawing.Size(289, 25);
            this.btnAnexarImagem.TabIndex = 19;
            this.btnAnexarImagem.Text = "ANEXAR IMAGEM";
            this.btnAnexarImagem.UseVisualStyleBackColor = true;
            this.btnAnexarImagem.Click += new System.EventHandler(this.btnAnexarImagem_Click);
            // 
            // ImagemBOX
            // 
            this.ImagemBOX.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ImagemBOX.Location = new System.Drawing.Point(248, 39);
            this.ImagemBOX.Name = "ImagemBOX";
            this.ImagemBOX.Size = new System.Drawing.Size(289, 218);
            this.ImagemBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagemBOX.TabIndex = 18;
            this.ImagemBOX.TabStop = false;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Location = new System.Drawing.Point(242, 311);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(113, 13);
            this.lblNomeUsuario.TabIndex = 24;
            this.lblNomeUsuario.Text = "NOME DO USUÁRIO:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltar.Location = new System.Drawing.Point(12, 374);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(117, 64);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "* Acesso 3 - Restrito para o Ministério do meio Ambiente";
            // 
            // btnSair
            // 
            this.btnSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSair.Location = new System.Drawing.Point(712, 374);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 67);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(248, 402);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(289, 36);
            this.pgBar.TabIndex = 27;
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // InfNvl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAutenticar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnLimparImagem);
            this.Controls.Add(this.btnAnexarImagem);
            this.Controls.Add(this.ImagemBOX);
            this.Name = "InfNvl3";
            this.Text = "Informações Nivel 3";
            ((System.ComponentModel.ISupportInitialize)(this.ImagemBOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutenticar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnLimparImagem;
        private System.Windows.Forms.Button btnAnexarImagem;
        private System.Windows.Forms.PictureBox ImagemBOX;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}