using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add
            double num1, num2, result;
            num1 = Convert.ToDouble(txtFirstNumber.Text);
            num2 = Convert.ToDouble(txtSecondNumber.Text);

            result = num1 + num2;

            
            if (num2 < 0)
            {
                
                txtResult.Text = txtFirstNumber.Text + " + (" + txtSecondNumber.Text + ") = " + result;
            }
            else
            {
                txtResult.Text = txtFirstNumber.Text + " + " + txtSecondNumber.Text + " = " + result;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Subtract
            double num1, num2, result;
            num1 = Convert.ToDouble(txtFirstNumber.Text);
            num2 = Convert.ToDouble(txtSecondNumber.Text);

            result = num1 - num2;

            if (num2 < 0)
            {

                txtResult.Text = txtFirstNumber.Text + " - (" + txtSecondNumber.Text + ") = " + result;
            }
            else
            {
                txtResult.Text = txtFirstNumber.Text + " - " + txtSecondNumber.Text + " = " + result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Multiply
            double num1, num2, result;
            num1 = Convert.ToDouble(txtFirstNumber.Text);
            num2 = Convert.ToDouble(txtSecondNumber.Text);

            result = num1 * num2;

            if (num2 < 0)
            {

                txtResult.Text = txtFirstNumber.Text + " * (" + txtSecondNumber.Text + ") = " + result;
            }
            else
            {
                txtResult.Text = txtFirstNumber.Text + " * " + txtSecondNumber.Text + " = " + result;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Average
            double num1, num2, result;
            num1 = Convert.ToDouble(txtFirstNumber.Text);
            num2 = Convert.ToDouble(txtSecondNumber.Text);

            result = (num1 + num2)/2;

            if (num2 < 0)
            {

                txtResult.Text = txtFirstNumber.Text + " avg (" + txtSecondNumber.Text + ") = " + result;
            }
            else
            {
                txtResult.Text = txtFirstNumber.Text + " avg " + txtSecondNumber.Text + " = " + result;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";
            txtResult.Text = "";
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
