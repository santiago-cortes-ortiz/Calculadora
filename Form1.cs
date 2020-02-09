using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Suma suma = new Suma();
        Resta resta = new Resta();
        Multiplicacion mult = new Multiplicacion();
        Division div = new Division();

        public Form1()
        {
            InitializeComponent();
        }
        private void button1btn_Click(object sender, EventArgs e)
        {
            if (textBox1txt.Text == "" )
            {
                error2.SetError(textBox1txt, "Error, debes ingresar datos");
                textBox1txt.Focus();             
                return;
            }

            error2.SetError(textBox1txt, "");

            if ( textBox2txt.Text == "")
            {
                error3.SetError(textBox2txt, "Error, debes ingresar datos");
                textBox2txt.Focus();
                return;
            }

            
            error3.SetError(textBox2txt,"");

            decimal numero;
            if (!Decimal.TryParse(textBox1txt.Text, out numero))
            {
                error2.SetError(textBox1txt, "Error, debes ingresar numeros");
                textBox1txt.Focus();
                return;
            }
           

            else if (!Decimal.TryParse(textBox2txt.Text, out numero))
            {
                error3.SetError(textBox2txt, "Error, debes ingresar numeros");
                textBox2txt.Focus();
                return;
            }
            error3.SetError(textBox2txt, "");
            error2.SetError(textBox1txt, "");


            suma.Numero = Convert.ToDecimal(textBox1txt.Text);
                suma.Numero2 = Convert.ToDecimal(textBox2txt.Text);
                resta.Numero1 = Convert.ToDecimal(textBox1txt.Text);
                resta.Numero2 = Convert.ToDecimal(textBox2txt.Text);
                mult.Numero1 = Convert.ToDecimal(textBox1txt.Text);
                mult.Numero2 = Convert.ToDecimal(textBox2txt.Text);
                div.Numero1 = Convert.ToDecimal(textBox1txt.Text);
                div.Numero2 = Convert.ToDecimal(textBox2txt.Text);
                MessageBox.Show("SE GUARDO");
                       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = suma.Resultado(suma.Numero, suma.Numero2).ToString();
            error1.SetError(textBox1, "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = resta.Resultado(resta.Numero1,resta.Numero2).ToString();
            error1.SetError(textBox1, "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = mult.Resultado(mult.Numero1, mult.Numero2).ToString();
            error1.SetError(textBox1, "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (div.Numero2 == 0)
            {
                error1.SetError(textBox1,"Error pendejo");
                textBox1.Focus();
                return;
            }

            error1.SetError(textBox1, "");

            textBox1.Text = div.Resultado(div.Numero1, div.Numero2).ToString();
            
        
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1txt.Clear();
            textBox2txt.Clear();
            textBox1.Clear();
            suma.Numero = 0;
            suma.Numero2 = 0;
            resta.Numero1 = 0;
            resta.Numero2 = 0;
            mult.Numero1 = 0;
            mult.Numero2 = 0;
            div.Numero1 = 0;
            div.Numero2 = 0;
            error1.SetError(textBox1, "");

        }

        private void button6salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
