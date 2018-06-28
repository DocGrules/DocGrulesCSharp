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
        Soap.GrulesWebServiceClient test = new Soap.GrulesWebServiceClient();

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

            test.registrarChamada(CbxEventos.Text,TbxMatricula.Text);
            MessageBox.Show("Salvo com Sucesso!");

          
        }

        private void CbxEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] teste = test.loadAllSemestre();
            List<String> semestres = teste.ToList();
            CbxEventos.DataSource = semestres;
            

        }
    }
}
