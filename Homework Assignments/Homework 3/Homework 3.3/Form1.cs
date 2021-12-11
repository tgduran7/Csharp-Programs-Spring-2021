using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            string str_input = txtInput.Text;
            double input;
            bool valid = double.TryParse(str_input, out input);
            
            if (valid && (input >= 0))
            {
                txtSales.Text = input.ToString("C2");

                if ((input >= 0) && (input <= 1000))
                {
                    double profit = (input * 0.03);
                    txtProfit.Text = profit.ToString("C2");
                    txtProfitRatio.Text = "3%";
                }
                if ((input >= 1000.01) && (input <= 5000))
                {
                    double profit2 = (input * 0.035);
                    txtProfit.Text = profit2.ToString("C2");
                    txtProfitRatio.Text = "3.5%";
                }
                if ((input >= 5000.01) && (input <= 10000))
                {
                    double profit3 = (input * 0.04);
                    txtProfit.Text = profit3.ToString("C2");
                    txtProfitRatio.Text = "4%";
                }
                if ((input >= 10000.01))
                {
                    double profit4 = (input * 0.045);
                    txtProfit.Text = profit4.ToString("C2");
                    txtProfitRatio.Text = "4.5%";
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please try again.");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtProfit.Text = "";
            txtProfitRatio.Text = "";
            txtSales.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
