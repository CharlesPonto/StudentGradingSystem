using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradingSystem
{
    public partial class Form1 : Form
    {
        public static ArrayList studentList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            string format = "Student Name:             Grade:";
            studentList.Add(format);
        }

   
        private void btnCompute_Click(object sender, EventArgs e)
        {
            string studentName = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please input a name.");
                return;
            }

            bool isPrelimValid = double.TryParse(txtGrade1.Text, out double prelimGrade);
            bool isMidtermValid = double.TryParse(txtGrade2.Text, out double midtermGrade);
            bool isFinalsValid = double.TryParse(txtGrade3.Text, out double finalsGrade);

            if (isPrelimValid && isMidtermValid && isFinalsValid)
            {
                if (prelimGrade < 0 || prelimGrade > 100 ||
                    midtermGrade < 0 || midtermGrade > 100 ||
                    finalsGrade < 0 || finalsGrade > 100)
                {
                    MessageBox.Show("Grade should be greater than 0 and less then 100");
                    return;
                }

                double average = (prelimGrade + midtermGrade + finalsGrade) / 3;

               // labelResult.ForeColor = average > 75 ? Color.Green : Color.Red;
                //labelResult.Text = $"Average: {average:F2}%";

                string summary = $"{studentName}             {average:F2}%";
                studentList.Add(summary);
                displayObtainedMarks(studentName, prelimGrade, midtermGrade, finalsGrade, average);
            }
            else
            {
                MessageBox.Show("Please input valid numbers for all grades.");
            }
        }


        private void displayObtainedMarks(string studentName, double prelimGrade, double midtermGrade, double finalsGrade, double average)
        {
            OMname.Text = studentName;
            OMprelim.Text = prelimGrade.ToString();
            OMmidterm.Text = midtermGrade.ToString();
            OMfinals.Text = finalsGrade.ToString();
            horizontalLine.Visible = true;
            labelResult.Text = $"{average:F2}%";
            labelResult.ForeColor = average > 75 ? Color.Green : Color.Red;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtGrade1.Text = "";
            txtGrade2.Text = "";
            txtGrade3.Text = "";
            labelResult.Text = "";
        }

        private void btnShowSummary_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
