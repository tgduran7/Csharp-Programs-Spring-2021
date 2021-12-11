using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string str_n = txtInput.Text;
            bool valid = Int32.TryParse(str_n, out int n);

            if (!valid || n < 0)
            {
                MessageBox.Show("Invalid Input. Please try again.");
            }
            else
            {
                double mathe = 0;
                int i = 0;
                long fac = 1;
                lstOutput.Items.Clear();
                

                do
                {
                    if (i == 0)
                    {
                        fac = 1;
                    }
                    else
                    {

                        fac *= i;

                        
                        
                    }
                    mathe = (Convert.ToDouble(1) / fac) + mathe;
                    lstOutput.Items.Add(i.ToString() + "! = " + fac.ToString());
                    i++;

                    
                }
                while (i <= n);
                lstOutput.Items.Add("");
                lstOutput.Items.Add("e = " + Math.Round(mathe, 6));
                
                
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            lstOutput.Items.Clear();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
