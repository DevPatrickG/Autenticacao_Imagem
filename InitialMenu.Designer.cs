
namespace ProjetoAutenticidade
{
    partial class InitialMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialMenu));
            this.btnCadastroAcesso = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnInfNvl1 = new System.Windows.Forms.Button();
            this.btnInfNvl2 = new System.Windows.Forms.Button();
            this.btnInfNvl3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastroAcesso
            // 
            this.btnCadastroAcesso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnCadastroAcesso, "btnCadastroAcesso");
            this.btnCadastroAcesso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastroAcesso.Name = "btnCadastroAcesso";
            this.btnCadastroAcesso.UseVisualStyleBackColor = false;
            this.btnCadastroAcesso.Click += new System.EventHandler(this.btnRegistrationAccess_Click);
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnInfNvl1
            // 
            this.btnInfNvl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnInfNvl1, "btnInfNvl1");
            this.btnInfNvl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInfNvl1.Name = "btnInfNvl1";
            this.btnInfNvl1.UseVisualStyleBackColor = false;
            this.btnInfNvl1.Click += new System.EventHandler(this.btnInfNvl1_Click);
            // 
            // btnInfNvl2
            // 
            this.btnInfNvl2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnInfNvl2, "btnInfNvl2");
            this.btnInfNvl2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInfNvl2.Name = "btnInfNvl2";
            this.btnInfNvl2.UseVisualStyleBackColor = false;
            this.btnInfNvl2.Click += new System.EventHandler(this.btnInfNvl2_Click);
            // 
            // btnInfNvl3
            // 
            this.btnInfNvl3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnInfNvl3, "btnInfNvl3");
            this.btnInfNvl3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInfNvl3.Name = "btnInfNvl3";
            this.btnInfNvl3.UseVisualStyleBackColor = false;
            this.btnInfNvl3.Click += new System.EventHandler(this.btnInfNvl3_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInfNvl3);
            this.Controls.Add(this.btnInfNvl2);
            this.Controls.Add(this.btnInfNvl1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroAcesso);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastroAcesso;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInfNvl1;
        private System.Windows.Forms.Button btnInfNvl2;
        private System.Windows.Forms.Button btnInfNvl3;
        private System.Windows.Forms.Label label1;
    }
}

