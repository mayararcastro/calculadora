using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App1
{
    public partial class Calculadora : Form
    {
        double primeiro;
        double segundo;
        double operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        classe.ClsSomar obj = new classe.ClsSomar();
        classe.clsResto obj2 = new classe.clsResto();
        classe.clsMult obj3 = new classe.clsMult();
        classe.clsDivisao obj4 = new classe.clsDivisao();

        private void btnN0_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "0";
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + ".";
        }
        private void form1_load(object sender, EventArgs e)
        {

        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            NewMethod2();
            primeiro = double.Parse(tbxResultado.Text);
            tbxResultado.Clear();
        }

        private void NewMethod2()
        {
            operador = "+";
        }

        private void NewMethod()
        {
            NewMethod1();
        }

        private void NewMethod1()
        {
            primeiro = double.Parse(tbxResultado.Text);
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            operador = "-";
            primeiro = double.Parse(tbxResultado.Text);
            tbxResultado.Clear();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operador = "*";
            primeiro = double.Parse(tbxResultado.Text);
            tbxResultado.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operador = "/";
            primeiro = double.Parse(tbxResultado.Text);
            tbxResultado.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

        }
    }
}
