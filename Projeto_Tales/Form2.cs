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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (TbxMatricula.Text == "150300007")
            {
                MessageBox.Show("Matrícula aceita!");
            }
            else
            {
                MessageBox.Show("Matrícula Inválida!");
            }

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (TbxCPF.Text=="11111111111")
            {
                MessageBox.Show("CPF Válido!");
            }
            else
            {
                MessageBox.Show("CPF Inválido!");
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            teste.WsTesteClient teste = new teste.WsTesteClient();

            teste.soma

            soma = teste.Soma(txtnum1.text, txtnum2.text);

            txresultado.text = soma;
            MessageBox.Show("Salvo com Sucesso!");
        }
    }
}
