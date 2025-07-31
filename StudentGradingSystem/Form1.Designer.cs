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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Grading System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 74);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(47, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Information";
            // 
            // studentNameInput
            // 
            this.studentNameInput.AutoSize = true;
            this.studentNameInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.studentNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.studentNameInput.Location = new System.Drawing.Point(48, 153);
            this.studentNameInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentNameInput.Name = "studentNameInput";
            this.studentNameInput.Size = new System.Drawing.Size(74, 25);
            this.studentNameInput.TabIndex = 3;
            this.studentNameInput.Text = "Name:";
            // 
            // grade1
            // 
            this.grade1.AutoSize = true;
            this.grade1.Cursor = System.Windows.Forms.Cursors.Default;
            this.grade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.grade1.Location = new System.Drawing.Point(49, 256);
            this.grade1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grade1.Name = "grade1";
            this.grade1.Size = new System.Drawing.Size(78, 25);
            this.grade1.TabIndex = 5;
            this.grade1.Text = "Prelim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(47, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Semester Marks";
            // 
            // grade2
            // 
            this.grade2.AutoSize = true;
            this.grade2.Cursor = System.Windows.Forms.Cursors.Default;
            this.grade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.grade2.Location = new System.Drawing.Point(49, 295);
            this.grade2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grade2.Name = "grade2";
            this.grade2.Size = new System.Drawing.Size(95, 25);
            this.grade2.TabIndex = 6;
            this.grade2.Text = "Midterm:";
            // 
            // grade3
            // 
            this.grade3.AutoSize = true;
            this.grade3.Cursor = System.Windows.Forms.Cursors.Default;
            this.grade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.grade3.Location = new System.Drawing.Point(49, 334);
            this.grade3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grade3.Name = "grade3";
            this.grade3.Size = new System.Drawing.Size(76, 25);
            this.grade3.TabIndex = 7;
            this.grade3.Text = "Finals:";
            // 
            // txtGrade1
            // 
            this.txtGrade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtGrade1.Location = new System.Drawing.Point(161, 258);
            this.txtGrade1.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrade1.Name = "txtGrade1";
            this.txtGrade1.Size = new System.Drawing.Size(132, 26);
            this.txtGrade1.TabIndex = 8;
            // 
            // txtGrade2
            // 
            this.txtGrade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtGrade2.Location = new System.Drawing.Point(161, 298);
            this.txtGrade2.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrade2.Name = "txtGrade2";
            this.txtGrade2.Size = new System.Drawing.Size(132, 26);
            this.txtGrade2.TabIndex = 9;
            // 
            // txtGrade3
            // 
            this.txtGrade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtGrade3.Location = new System.Drawing.Point(161, 336);
            this.txtGrade3.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrade3.Name = "txtGrade3";
            this.txtGrade3.Size = new System.Drawing.Size(132, 26);
            this.txtGrade3.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtName.Location = new System.Drawing.Point(132, 156);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 26);
            this.txtName.TabIndex = 11;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.btnCompute.Location = new System.Drawing.Point(52, 389);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(141, 57);
            this.btnCompute.TabIndex = 12;
            this.btnCompute.Text = "Calculate Grade";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnShowSummary
            // 
            this.btnShowSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.btnShowSummary.Location = new System.Drawing.Point(201, 389);
            this.btnShowSummary.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowSummary.Name = "btnShowSummary";
            this.btnShowSummary.Size = new System.Drawing.Size(141, 57);
            this.btnShowSummary.TabIndex = 13;
            this.btnShowSummary.Text = "Show Summary";
            this.btnShowSummary.UseVisualStyleBackColor = false;
            this.btnShowSummary.Click += new System.EventHandler(this.btnShowSummary_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 484);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F);
            this.panel2.Location = new System.Drawing.Point(539, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 382);
            this.panel2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(635, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 51);
            this.label3.TabIndex = 16;
            this.label3.Text = "Obtained Marks";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.labelResult.Location = new System.Drawing.Point(667, 247);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 35);
            this.labelResult.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.button1.Location = new System.Drawing.Point(351, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 57);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Location = new System.Drawing.Point(0, 474);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1079, 10);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 484);
            this.Controls.Add(this.panel3);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel panel3;
    }
}

