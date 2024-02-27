using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        string operador = "";
        double num1 = 0;
        double num2 = 0;    


        private void button11_Click(object sender, EventArgs e) //Botón 6
        {
            if (txtpantalla.Text == "0") txtpantalla.Text = "";
            txtpantalla.Text = txtpantalla.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e) //Botón 9
        {
            if (txtpantalla.Text == "0") txtpantalla.Text = "";
            txtpantalla.Text = txtpantalla.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e) //Botón para borrar caracteres
        {
            if (txtpantalla.TextLength == 1) txtpantalla.Text = "0";
            else txtpantalla.Text = txtpantalla.Text.Substring(0, txtpantalla.Text.Length - 1);

          

        }

        private void btn_limpiar_Click(object sender, EventArgs e) //Botón para limpiar todo.
        {
            txtpantalla.Text = "0";
            num1 = 0;   
            num2 = 0;
            operador = "";
        }

        private void btn_7_Click(object sender, EventArgs e) //Botón 7
        {
            if (txtpantalla.Text == "0") txtpantalla.Text = "";
            txtpantalla.Text = txtpantalla.Text + "7";
        }

        private void btn_resta_Click(object sender, EventArgs e) //Resta
        {
            operador = "-";
            num1 = Convert.ToDouble(txtpantalla.Text);
            txtpantalla.Text = "0";
        }

        private void btn_8_Click(object sender, EventArgs e) //Botón 8
        {
            if (txtpantalla.Text == "0") txtpantalla.Text = "";
            txtpantalla.Text = txtpantalla.Text + "8";
        }

        private void btn_4_Click(object sender, EventArgs e) //Botón 4
        {
            if (txtpantalla.Text == "0") txtpantalla.Text = "";
            txtpantalla.Text = txtpantalla.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e) //Botón 5
        {
            if (txtpantalla.Text == "0") txtpantalla.Text = "";
            txtpantalla.Text = txtpantalla.Text + "5";
        }

        private void btn_1_Click(object sender, EventArgs e) //Botón 1
        {
            if (txtpantalla.Text == "0") txtpantalla.Text = "";
            txtpantalla.Text = txtpantalla.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e) //Botón 2
        {
            if (txtpantalla.Text == "0") txtpantalla.Text = "";
            txtpantalla.Text = txtpantalla.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e) //Botón 3
        {
            if (txtpantalla.Text == "0") txtpantalla.Text = "";
            txtpantalla.Text = txtpantalla.Text + "3";
        }

        private void btn_0_Click(object sender, EventArgs e) //Botón 0
        {
            if (txtpantalla.Text == "0") txtpantalla.Text = "";
            txtpantalla.Text = txtpantalla.Text + "0";
        }

        private void btn_punto_Click(object sender, EventArgs e) //Punto
        {
            if (txtpantalla.Text.Contains("."))
            {

            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + ".";
            }
            

        }

        private void btn_suma_Click(object sender, EventArgs e) //Suma
        {
            operador = "+";
            num1 = Convert.ToDouble(txtpantalla.Text);
            txtpantalla.Text = "0";
        }

        private void btn_mult_Click(object sender, EventArgs e) //Multiplicación
        {
            operador = "*";
            num1 = Convert.ToDouble(txtpantalla.Text);
            txtpantalla.Text = "0";
        }

        private void btn_div_Click(object sender, EventArgs e) //División
        {
            operador = "/";
            num1 = Convert.ToDouble(txtpantalla.Text);
            txtpantalla.Text = "0";
        }

        private void btn_resultado_Click(object sender, EventArgs e) //Resultado
        {
            num2 = Convert.ToDouble(txtpantalla.Text);

            switch(operador)
            {
                case "+":
                    txtpantalla.Text = $"{num1 + num2}";
                    break;

                case "-":
                    txtpantalla.Text = $"{num1 - num2}";
                    break;

                case "*":
                    txtpantalla.Text = $"{num1 * num2}";
                    break;

                case "/":
                    txtpantalla.Text = $"{num1 / num2}";
                    break;
            };
        }

        private void txtpantalla_TextChanged(object sender, EventArgs e) //Pantalla
        {

        }
    }
}
