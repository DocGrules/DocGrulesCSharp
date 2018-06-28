namespace Projeto_Tales
{
    partial class Form1
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
            this.BtLogin = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TbxUsuario = new System.Windows.Forms.TextBox();
            this.TbxSenha = new System.Windows.Forms.TextBox();
            this.BtnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtLogin
            // 
            this.BtLogin.Location = new System.Drawing.Point(12, 208);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(78, 35);
            this.BtLogin.TabIndex = 0;
            this.BtLogin.Text = "Login";
            this.BtLogin.UseVisualStyleBackColor = true;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(99, 43);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuário:";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Location = new System.Drawing.Point(99, 97);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(41, 13);
            this.LblSenha.TabIndex = 2;
            this.LblSenha.Text = "Senha:";
            // 
            // TbxUsuario
            // 
            this.TbxUsuario.Location = new System.Drawing.Point(102, 59);
            this.TbxUsuario.Name = "TbxUsuario";
            this.TbxUsuario.Size = new System.Drawing.Size(123, 20);
            this.TbxUsuario.TabIndex = 3;
            // 
            // TbxSenha
            // 
            this.TbxSenha.Location = new System.Drawing.Point(102, 113);
            this.TbxSenha.Name = "TbxSenha";
            this.TbxSenha.PasswordChar = '*';
            this.TbxSenha.Size = new System.Drawing.Size(123, 20);
            this.TbxSenha.TabIndex = 4;
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(147, 208);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(78, 35);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.TbxSenha);
            this.Controls.Add(this.TbxUsuario);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtLogin);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TbxUsuario;
        private System.Windows.Forms.TextBox TbxSenha;
        private System.Windows.Forms.Button BtnSair;
    }
}

