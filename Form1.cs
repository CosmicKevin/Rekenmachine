using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class rekenmachine : Form
    {
        decimal firstNumber;
        string operation;

        public rekenmachine()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (textBox1.Text == "0")
            {
                textBox1.Text = button.Text;
            } else
            {
                textBox1.Text += button.Text;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void btntimes_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void Add()
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";
        }

        private void Subtract()
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";
        }

        private void Multiply()
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            operation = "*";
        }

        private void Divide()
        {
            firstNumber = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "0";
            operation = "/";
        }

        private void Equalize()
        {
            decimal secondNumber = Convert.ToDecimal(textBox1.Text);
            decimal result;

            if (operation == "+")
            {
                result = (firstNumber + secondNumber);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "-")
            {
                result = (firstNumber - secondNumber);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "*")
            {
                result = (firstNumber * secondNumber);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    textBox1.Text = "Kan niet door nul delen";

                }
                else
                {
                    result = (firstNumber / secondNumber);
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                }
            }
        }


        private void btneq_Click(object sender, EventArgs e)
        {
            Equalize();
        }

        private void keyboard_Input(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "1";
                    } else
                    {
                        textBox1.Text += "1";
                    }
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "2";
                    }
                    else
                    {
                        textBox1.Text += "2";
                    }
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "3";
                    }
                    else
                    {
                        textBox1.Text += "3";
                    }
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "4";
                    }
                    else
                    {
                        textBox1.Text += "4";
                    }
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "5";
                    }
                    else
                    {
                        textBox1.Text += "5";
                    }
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "6";
                    }
                    else
                    {
                        textBox1.Text += "6";
                    }
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "7";
                    }
                    else
                    {
                        textBox1.Text += "7";
                    }
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "8";
                    }
                    else
                    {
                        textBox1.Text += "8";
                    }
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "9";
                    }
                    else
                    {
                        textBox1.Text += "9";
                    }
                    break;
                case Keys.D0:
                case Keys.NumPad0:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "0";
                    }
                    else
                    {
                        textBox1.Text += "0";
                    }
                    break;
                case Keys.Oemplus:
                    Add();
                    break;
                case Keys.OemMinus:
                    Subtract();
                    break;
                case Keys.Multiply:
                    Multiply();
                    break;
                case Keys.Divide:
                    Divide();
                    break;
                case Keys.Return:
                    Equalize();
                    break;
            }
        }
    }
}
