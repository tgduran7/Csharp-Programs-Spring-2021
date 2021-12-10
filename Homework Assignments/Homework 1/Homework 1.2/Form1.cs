using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double num1, result;

            num1 = Convert.ToDouble(txtMiles.Text);

            result = num1 * 1.60934;

            txtKilometers.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMiles.Text = "";
            txtKilometers.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
