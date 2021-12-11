using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_7._3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double FederalTax(double x) // 18%
        {
            double total = 0.18 * x;
            return total;
        }
        double Retirement(double x) // %15
        {
            double total = 0.15 * x;
            return total;
        }
        double SocialSecurity(double x) // 9%
        {
            double total = 0.09 * x;
            return total;
        }

        private void btnTakeHomePay_Click(object sender, EventArgs e)
        {
            string name = txtEmName.Text;
            string str_weekSales = txtEmWeeklySales.Text;

            bool valid = double.TryParse(str_weekSales, out double weeklySales);
            if (valid && weeklySales >= 0)
            {
                double commission = 0.7 * weeklySales;

                double fedTax = Math.Round(FederalTax(commission), 2);
                txtFedTax.Text = fedTax.ToString();
                double retire = Math.Round(Retirement(commission), 2);
                txtRetirement.Text = retire.ToString();
                double social = Math.Round(SocialSecurity(commission), 2);
                txtSocialSecurity.Text = social.ToString();

                double netPay = Math.Round((commission - fedTax - retire - social), 2);
                txtTotal.Text = netPay.ToString();
            }
            else
            {
                MessageBox.Show("Total weekly sales must be a positive dollar amount. Please re-enter.");
                txtEmWeeklySales.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmName.Text = "";
            txtEmWeeklySales.Text = "";
            txtFedTax.Text = "";
            txtRetirement.Text = "";
            txtSocialSecurity.Text = "";
            txtTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
