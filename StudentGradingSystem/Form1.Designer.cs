namespace StudentGradingSystem
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.studentNameInput = new System.Windows.Forms.Label();
            this.grade1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grade2 = new System.Windows.Forms.Label();
            this.grade3 = new System.Windows.Forms.Label();
            this.txtGrade1 = new System.Windows.Forms.TextBox();
            this.txtGrade2 = new System.Windows.Forms.TextBox();
            this.txtGrade3 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnShowSummary = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxTemp = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Grading System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 60);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Information";
            // 
            // studentNameInput
            // 
            this.studentNameInput.AutoSize = true;
            this.studentNameInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.studentNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.studentNameInput.Location = new System.Drawing.Point(35, 125);
            this.studentNameInput.Name = "studentNameInput";
            this.studentNameInput.Size = new System.Drawing.Size(58, 20);
            this.studentNameInput.TabIndex = 3;
            this.studentNameInput.Text = "Name:";
            // 
            // grade1
            // 
            this.grade1.AutoSize = true;
            this.grade1.Cursor = System.Windows.Forms.Cursors.Default;
            this.grade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.grade1.Location = new System.Drawing.Point(37, 208);
            this.grade1.Name = "grade1";
            this.grade1.Size = new System.Drawing.Size(62, 20);
            this.grade1.TabIndex = 5;
            this.grade1.Text = "Prelim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(35, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Semester Marks";
            // 
            // grade2
            // 
            this.grade2.AutoSize = true;
            this.grade2.Cursor = System.Windows.Forms.Cursors.Default;
            this.grade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.grade2.Location = new System.Drawing.Point(37, 240);
            this.grade2.Name = "grade2";
            this.grade2.Size = new System.Drawing.Size(75, 20);
            this.grade2.TabIndex = 6;
            this.grade2.Text = "Midterm:";
            // 
            // grade3
            // 
            this.grade3.AutoSize = true;
            this.grade3.Cursor = System.Windows.Forms.Cursors.Default;
            this.grade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.grade3.Location = new System.Drawing.Point(37, 271);
            this.grade3.Name = "grade3";
            this.grade3.Size = new System.Drawing.Size(59, 20);
            this.grade3.TabIndex = 7;
            this.grade3.Text = "Finals:";
            // 
            // txtGrade1
            // 
            this.txtGrade1.Location = new System.Drawing.Point(121, 210);
            this.txtGrade1.Name = "txtGrade1";
            this.txtGrade1.Size = new System.Drawing.Size(100, 20);
            this.txtGrade1.TabIndex = 8;
            // 
            // txtGrade2
            // 
            this.txtGrade2.Location = new System.Drawing.Point(121, 242);
            this.txtGrade2.Name = "txtGrade2";
            this.txtGrade2.Size = new System.Drawing.Size(100, 20);
            this.txtGrade2.TabIndex = 9;
            // 
            // txtGrade3
            // 
            this.txtGrade3.Location = new System.Drawing.Point(121, 273);
            this.txtGrade3.Name = "txtGrade3";
            this.txtGrade3.Size = new System.Drawing.Size(100, 20);
            this.txtGrade3.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 127);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 11;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(39, 316);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(106, 46);
            this.btnCompute.TabIndex = 12;
            this.btnCompute.Text = "Calculate Grade";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnShowSummary
            // 
            this.btnShowSummary.Location = new System.Drawing.Point(151, 316);
            this.btnShowSummary.Name = "btnShowSummary";
            this.btnShowSummary.Size = new System.Drawing.Size(106, 46);
            this.btnShowSummary.TabIndex = 13;
            this.btnShowSummary.Text = "Show Summary";
            this.btnShowSummary.UseVisualStyleBackColor = true;
            this.btnShowSummary.Click += new System.EventHandler(this.btnShowSummary_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 393);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F);
            this.panel2.Location = new System.Drawing.Point(404, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 310);
            this.panel2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label3.Location = new System.Drawing.Point(476, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Obtained Marks";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.labelResult.Location = new System.Drawing.Point(500, 201);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 29);
            this.labelResult.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxTemp
            // 
            this.listBoxTemp.FormattingEnabled = true;
            this.listBoxTemp.Location = new System.Drawing.Point(505, 202);
            this.listBoxTemp.Name = "listBoxTemp";
            this.listBoxTemp.Size = new System.Drawing.Size(196, 160);
            this.listBoxTemp.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.listBoxTemp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnShowSummary);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtGrade3);
            this.Controls.Add(this.txtGrade2);
            this.Controls.Add(this.txtGrade1);
            this.Controls.Add(this.grade3);
            this.Controls.Add(this.grade2);
            this.Controls.Add(this.grade1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.studentNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label studentNameInput;
        private System.Windows.Forms.Label grade1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label grade2;
        private System.Windows.Forms.Label grade3;
        private System.Windows.Forms.TextBox txtGrade1;
        private System.Windows.Forms.TextBox txtGrade2;
        private System.Windows.Forms.TextBox txtGrade3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnShowSummary;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxTemp;
    }
}

