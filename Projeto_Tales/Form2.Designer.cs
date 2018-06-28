namespace Projeto_Tales
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.TbxMatricula = new System.Windows.Forms.TextBox();
            this.TbxCPF = new System.Windows.Forms.TextBox();
            this.CbxEventos = new System.Windows.Forms.ComboBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.LblCPF = new System.Windows.Forms.Label();
            this.LblEventos = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.loadAllSemestreResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loadAllSemestreResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxMatricula
            // 
            this.TbxMatricula.Location = new System.Drawing.Point(98, 98);
            this.TbxMatricula.Name = "TbxMatricula";
            this.TbxMatricula.Size = new System.Drawing.Size(121, 20);
            this.TbxMatricula.TabIndex = 0;
            // 
            // TbxCPF
            // 
            this.TbxCPF.Location = new System.Drawing.Point(98, 155);
            this.TbxCPF.Name = "TbxCPF";
            this.TbxCPF.Size = new System.Drawing.Size(121, 20);
            this.TbxCPF.TabIndex = 1;
            // 
            // CbxEventos
            // 
            this.CbxEventos.DataSource = this.loadAllSemestreResponseBindingSource;
            this.CbxEventos.FormattingEnabled = true;
            this.CbxEventos.Location = new System.Drawing.Point(98, 44);
            this.CbxEventos.Name = "CbxEventos";
            this.CbxEventos.Size = new System.Drawing.Size(121, 21);
            this.CbxEventos.TabIndex = 2;
            this.CbxEventos.SelectedIndexChanged += new System.EventHandler(this.CbxEventos_SelectedIndexChanged);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(235, 153);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 3;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(125, 214);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Location = new System.Drawing.Point(31, 101);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(55, 13);
            this.LblMatricula.TabIndex = 5;
            this.LblMatricula.Text = "Matrícula:";
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Location = new System.Drawing.Point(31, 158);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(30, 13);
            this.LblCPF.TabIndex = 6;
            this.LblCPF.Text = "CPF:";
            // 
            // LblEventos
            // 
            this.LblEventos.AutoSize = true;
            this.LblEventos.Location = new System.Drawing.Point(31, 47);
            this.LblEventos.Name = "LblEventos";
            this.LblEventos.Size = new System.Drawing.Size(49, 13);
            this.LblEventos.TabIndex = 7;
            this.LblEventos.Text = "Eventos:";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(235, 95);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 8;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // loadAllSemestreResponseBindingSource
            // 
            this.loadAllSemestreResponseBindingSource.DataSource = typeof(Projeto_Tales.Soap.loadAllSemestreResponse);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 277);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.LblEventos);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.LblMatricula);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.CbxEventos);
            this.Controls.Add(this.TbxCPF);
            this.Controls.Add(this.TbxMatricula);
            this.Name = "Form2";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadAllSemestreResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxMatricula;
        private System.Windows.Forms.TextBox TbxCPF;
        private System.Windows.Forms.ComboBox CbxEventos;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.Label LblEventos;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.BindingSource loadAllSemestreResponseBindingSource;
    }
}