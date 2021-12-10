using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1._3_WF
{
    public partial class frmFinalGradeCalculator : Form
    {
        public frmFinalGradeCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculateGrade_Click(object sender, EventArgs e)
        {
            double homework, quizzes, projects, exams, finalexam, finalgrade;
            double homework1, quizzes1, projects1, exams1, finalexam1;

            homework = Convert.ToDouble(txtHomework.Text);
            homework1 = homework * 0.1;

            quizzes = Convert.ToDouble(txtQuizzes.Text);
            quizzes1 = quizzes * 0.2;

            projects = Convert.ToDouble(txtProjects.Text);
            projects1 = projects * 0.25;

            exams = Convert.ToDouble(txtExams.Text);
            exams1 = exams * 0.2;

            finalexam = Convert.ToDouble(txtFinalExam.Text);
            finalexam1 = finalexam * 0.25;

            finalgrade = homework1 + quizzes1 + projects1 + exams1 + finalexam1;

            txtFinalGrade.Text = finalgrade.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHomework.Text = "";
            txtQuizzes.Text = "";
            txtProjects.Text = "";
            txtExams.Text = "";
            txtFinalExam.Text = "";
            txtFinalGrade.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
