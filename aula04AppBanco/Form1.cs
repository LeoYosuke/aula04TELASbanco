using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula04AppBanco
{
    public partial class Form1 : Form
    {
         List<string> extratos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtvalor.Text);
            double saldo = double.Parse(lblDinheiro.Text.Replace("R$", ""));
            double soma = saldo + valor;
            if(lblD.Text == "SAQUE")
            {
                 soma = saldo - valor;
                extratos.Add($"SAQUE no valor de de R$ {valor}");
            }
            else
            {
                 soma = valor + saldo;
                extratos.Add($"DEPOSITO no valor de de R$ {valor}");
            }
            lblDinheiro.Text = "R$" + soma;

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            btnDepositar.BackColor = Color.Gainsboro;
            btnDepositar.ForeColor = Color.Black;
            btnSacar.ForeColor = Color.DodgerBlue;
            btnSacar.BackColor = Color.LightBlue;
            lblD.Text = "SAQUE";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnSacar.BackColor = Color.Gainsboro;
            btnSacar.ForeColor = Color.Black;
            btnDepositar.ForeColor = Color.LightBlue;
            btnDepositar.BackColor = Color.DodgerBlue;
            lblD.Text = "DEPOSITO";
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            Form2 tela2 = new Form2();
            tela2.extratos = extratos;
            tela2.Show();

        }
    }
}
