using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula53_Exercicio
{
    public partial class Form1 : Form
    {
        public int TipoContrato { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            if (rBtnCLT.Checked)
            {
                TipoContrato = 1;
                Colaborador colaborador = new Colaborador(txtColaborador.Text, double.Parse(txtSalBruto.Text), TipoContrato);
                double sal = colaborador.CalculaSalarioLiquido(colaborador);
                lblSalLiquido.Text = $" Salário líquido = {colaborador.CalculaSalarioLiquido(colaborador)} ";
            }
            else if (rBtnPJ.Checked)
            {
                TipoContrato = 2;
                Colaborador colaborador = new Colaborador(txtColaborador.Text, double.Parse(txtSalBruto.Text), TipoContrato);
                lblSalLiquido.Text = $" Salário líquido = {colaborador.CalculaSalarioLiquido(colaborador)} ";
            }
            else if (rBtnFreela.Checked)
            {
                TipoContrato = 3;
                Colaborador colaborador = new Colaborador(txtColaborador.Text, TipoContrato, double.Parse(txtValorProjeto.Text));

                lblSalLiquido.Text = $" Salário líquido = {colaborador.CalculaSalarioLiquido(colaborador)} ";

            }
            else
            {
                txtValorProjeto.Visible = false;
                MessageBox.Show("Selecione um tipo de contrato");
            }

            txtColaborador.Clear();
            txtSalBruto.Clear();
            txtValorProjeto.Clear();
            

        }

        private void rBtnFreela_CheckedChanged(object sender, EventArgs e)
        {
            txtValorProjeto.Visible = true;
            lblValorproj.Visible = true;
            txtSalBruto.Visible = false;
            lblSalBruto.Visible = false;
        }

        private void rBtnPJ_CheckedChanged(object sender, EventArgs e)
        {
            txtValorProjeto.Visible = false;
            lblValorproj.Visible = false;
            txtSalBruto.Visible = true;
            lblSalBruto.Visible = true;
        }

        private void rBtnCLT_CheckedChanged(object sender, EventArgs e)
        {
            txtValorProjeto.Visible = false;
            lblValorproj.Visible = false;
            txtSalBruto.Visible = true;
            lblSalBruto.Visible = true;
        }
    }


}

