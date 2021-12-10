
namespace Homework_1._3_WF
{
    partial class frmFinalGradeCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelProjects = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculateGrade = new System.Windows.Forms.Button();
            this.txtHomework = new System.Windows.Forms.TextBox();
            this.txtProjects = new System.Windows.Forms.TextBox();
            this.txtQuizzes = new System.Windows.Forms.TextBox();
            this.txtExams = new System.Windows.Forms.TextBox();
            this.txtFinalExam = new System.Windows.Forms.TextBox();
            this.txtFinalGrade = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Homework (10%): ";
            // 
            // labelProjects
            // 
            this.labelProjects.AutoSize = true;
            this.labelProjects.Location = new System.Drawing.Point(59, 125);
            this.labelProjects.Name = "labelProjects";
            this.labelProjects.Size = new System.Drawing.Size(80, 13);
            this.labelProjects.TabIndex = 1;
            this.labelProjects.Text = "Projects (25%): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quizzes (20%): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exams (20%): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Final Exam: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Final Grade: ";
            // 
            // btnCalculateGrade
            // 
            this.btnCalculateGrade.Location = new System.Drawing.Point(325, 227);
            this.btnCalculateGrade.Name = "btnCalculateGrade";
            this.btnCalculateGrade.Size = new System.Drawing.Size(143, 55);
            this.btnCalculateGrade.TabIndex = 6;
            this.btnCalculateGrade.Text = "Calculate Grade";
            this.btnCalculateGrade.UseVisualStyleBackColor = true;
            this.btnCalculateGrade.Click += new System.EventHandler(this.btnCalculateGrade_Click);
            // 
            // txtHomework
            // 
            this.txtHomework.Location = new System.Drawing.Point(158, 47);
            this.txtHomework.Name = "txtHomework";
            this.txtHomework.Size = new System.Drawing.Size(110, 20);
            this.txtHomework.TabIndex = 7;
            // 
            // txtProjects
            // 
            this.txtProjects.Location = new System.Drawing.Point(158, 122);
            this.txtProjects.Name = "txtProjects";
            this.txtProjects.Size = new System.Drawing.Size(110, 20);
            this.txtProjects.TabIndex = 8;
            // 
            // txtQuizzes
            // 
            this.txtQuizzes.Location = new System.Drawing.Point(526, 47);
            this.txtQuizzes.Name = "txtQuizzes";
            this.txtQuizzes.Size = new System.Drawing.Size(110, 20);
            this.txtQuizzes.TabIndex = 9;
            // 
            // txtExams
            // 
            this.txtExams.Location = new System.Drawing.Point(526, 122);
            this.txtExams.Name = "txtExams";
            this.txtExams.Size = new System.Drawing.Size(110, 20);
            this.txtExams.TabIndex = 10;
            // 
            // txtFinalExam
            // 
            this.txtFinalExam.Location = new System.Drawing.Point(348, 183);
            this.txtFinalExam.Name = "txtFinalExam";
            this.txtFinalExam.Size = new System.Drawing.Size(110, 20);
            this.txtFinalExam.TabIndex = 11;
            // 
            // txtFinalGrade
            // 
            this.txtFinalGrade.Location = new System.Drawing.Point(348, 321);
            this.txtFinalGrade.Name = "txtFinalGrade";
            this.txtFinalGrade.Size = new System.Drawing.Size(110, 20);
            this.txtFinalGrade.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 369);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 69);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(690, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 69);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmFinalGradeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtFinalGrade);
            this.Controls.Add(this.txtFinalExam);
            this.Controls.Add(this.txtExams);
            this.Controls.Add(this.txtQuizzes);
            this.Controls.Add(this.txtProjects);
            this.Controls.Add(this.txtHomework);
            this.Controls.Add(this.btnCalculateGrade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelProjects);
            this.Controls.Add(this.label1);
            this.Name = "frmFinalGradeCalculator";
            this.Text = "Final Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculateGrade;
        private System.Windows.Forms.TextBox txtHomework;
        private System.Windows.Forms.TextBox txtProjects;
        private System.Windows.Forms.TextBox txtQuizzes;
        private System.Windows.Forms.TextBox txtExams;
        private System.Windows.Forms.TextBox txtFinalExam;
        private System.Windows.Forms.TextBox txtFinalGrade;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

