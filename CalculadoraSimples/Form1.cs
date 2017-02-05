using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class CalculadoraSimples : Form
    {
        Double valor = 0;
        String operador = "";
        bool operacao = false;
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void Numeros_Click(object sender, EventArgs e)
        {
            if ((txtNum.Text == "0") || (operacao))
                txtNum.Clear();

            operacao = false;
            Button Numeros = (Button)sender;           
            txtNum.Text = txtNum.Text + Numeros.Text;

        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            Button btnNumeros = (Button)sender;
            operador = btnNumeros.Text;
            valor = Double.Parse(txtNum.Text);
            operacao = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            operacao = true;
            switch (operador)
            {
                case "+":
                    txtNum.Text = (valor + Double.Parse(txtNum.Text)).ToString();
                    break;
                case "-":
                    txtNum.Text = (valor - Double.Parse(txtNum.Text)).ToString();
                    break;
                case "*":
                    txtNum.Text = (valor * Double.Parse(txtNum.Text)).ToString();
                    break;
                case "/":
                    txtNum.Text = (valor / Double.Parse(txtNum.Text)).ToString();
                    break;
                default:
                    break;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //C 
            txtNum.Clear();
            txtNum.Text = "0";

        }
        private void btnZerar_Click(object sender, EventArgs e)
        {
            //CE
            txtNum.Text = "0";
        }

        // Digitar usando o teclado
        private void CalculadoraSimples_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case "+":
                    btnSoma.PerformClick();
                    break;
                case "-":
                    btnSubtracao.PerformClick();
                    break;
                case "*":
                    btnMultiplicacao.PerformClick();
                    break;
                case "/":
                    btnDivisao.PerformClick();
                    break;
                default:
                    break;
            }

        }
    }
}
