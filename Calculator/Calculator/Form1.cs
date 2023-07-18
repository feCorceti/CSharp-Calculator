using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal n1 = 0;
        decimal n2 = 0;
        string operacao = "";
        

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(txtResult.Text != "")
            {
                n1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operacao = "subtraction";
                lblOperation.Text = "-";
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if(txtResult.Text != "")
            {
                n1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operacao = "addition";
                lblOperation.Text = "+";
            }
            
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOperation.Text = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(n1 != 0)
            {
                n2 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                if (operacao == "addition")
                {
                    txtResult.Text = Convert.ToString(n1 + n2);
                }

                if (operacao == "subtraction")
                {
                    txtResult.Text = Convert.ToString(n1 - n2);
                }

                if (operacao == "multiplication")
                {
                    txtResult.Text = Convert.ToString(n1 * n2);
                }

                if (operacao == "division")
                {
                    txtResult.Text = Convert.ToString(n1 / n2);
                }

            }



        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                n1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operacao = "multiplication";
                lblOperation.Text = "x";
            }
            
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if(txtResult.Text != "")
            {
                n1 = decimal.Parse(txtResult.Text, CultureInfo.InvariantCulture);
                txtResult.Text = "";
                operacao = "division";
                lblOperation.Text = "÷";
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            txtResult.Text = "";
            lblOperation.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3.14";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResult.Text))
            {
                StringBuilder sb = new StringBuilder(txtResult.Text);
                sb.Remove(sb.Length - 1, 1); 
                txtResult.Text = sb.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            if(txtResult.Text.StartsWith("-"))
            {
                txtResult.Text = txtResult.Text.Substring(1);
            }

            else
            {
                txtResult.Text = "-" + txtResult.Text;
            }
            
        }
    }
}
