using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Tales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            if (( TbxUsuario.Text =="Josias") && (TbxSenha.Text =="123"))
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválida!");
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
