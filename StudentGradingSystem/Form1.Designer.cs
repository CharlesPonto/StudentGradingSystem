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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.horizontalLine = new System.Windows.Forms.Panel();
            this.OMprelim = new System.Windows.Forms.Label();
            this.OMmidterm = new System.Windows.Forms.Label();
            this.OMfinals = new System.Windows.Forms.Label();
            this.OMname = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(221, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 45);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Information";
            // 
            // studentNameInput
            // 
            this.studentNameInput.AutoSize = true;
            this.studentNameInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.studentNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.studentNameInput.Location = new System.Drawing.Point(36, 124);
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Underline);
            this.label4.Location = new System.Drawing.Point(35, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 29);
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
            this.txtGrade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtGrade1.Location = new System.Drawing.Point(121, 210);
            this.txtGrade1.Name = "txtGrade1";
            this.txtGrade1.Size = new System.Drawing.Size(100, 22);
            this.txtGrade1.TabIndex = 8;
            // 
            // txtGrade2
            // 
            this.txtGrade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtGrade2.Location = new System.Drawing.Point(121, 242);
            this.txtGrade2.Name = "txtGrade2";
            this.txtGrade2.Size = new System.Drawing.Size(100, 22);
            this.txtGrade2.TabIndex = 9;
            // 
            // txtGrade3
            // 
            this.txtGrade3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtGrade3.Location = new System.Drawing.Point(121, 273);
            this.txtGrade3.Name = "txtGrade3";
            this.txtGrade3.Size = new System.Drawing.Size(100, 22);
            this.txtGrade3.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.txtName.Location = new System.Drawing.Point(100, 124);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 22);
            this.txtName.TabIndex = 11;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.btnCompute.Location = new System.Drawing.Point(39, 316);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(106, 46);
            this.btnCompute.TabIndex = 12;
            this.btnCompute.Text = "Calculate Grade";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnShowSummary
            // 
            this.btnShowSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.btnShowSummary.Location = new System.Drawing.Point(151, 316);
            this.btnShowSummary.Name = "btnShowSummary";
            this.btnShowSummary.Size = new System.Drawing.Size(106, 46);
            this.btnShowSummary.TabIndex = 13;
            this.btnShowSummary.Text = "Show Summary";
            this.btnShowSummary.UseVisualStyleBackColor = false;
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
            this.panel2.Location = new System.Drawing.Point(404, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 310);
            this.panel2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(492, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Obtained Marks";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.labelResult.Location = new System.Drawing.Point(606, 300);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 17);
            this.labelResult.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
            this.button1.Location = new System.Drawing.Point(263, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel3.Location = new System.Drawing.Point(0, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 8);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(495, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(434, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(434, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(434, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(495, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Finals:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label10.Location = new System.Drawing.Point(495, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Midterm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(495, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Prelim:";
            // 
            // horizontalLine
            // 
            this.horizontalLine.BackColor = System.Drawing.SystemColors.ControlText;
            this.horizontalLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 2.25F);
            this.horizontalLine.Location = new System.Drawing.Point(596, 292);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(84, 2);
            this.horizontalLine.TabIndex = 16;
            this.horizontalLine.Visible = false;
            // 
            // OMprelim
            // 
            this.OMprelim.AutoSize = true;
            this.OMprelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OMprelim.Location = new System.Drawing.Point(606, 202);
            this.OMprelim.Name = "OMprelim";
            this.OMprelim.Size = new System.Drawing.Size(0, 13);
            this.OMprelim.TabIndex = 26;
            // 
            // OMmidterm
            // 
            this.OMmidterm.AutoSize = true;
            this.OMmidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OMmidterm.Location = new System.Drawing.Point(606, 234);
            this.OMmidterm.Name = "OMmidterm";
            this.OMmidterm.Size = new System.Drawing.Size(0, 13);
            this.OMmidterm.TabIndex = 27;
            // 
            // OMfinals
            // 
            this.OMfinals.AutoSize = true;
            this.OMfinals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OMfinals.Location = new System.Drawing.Point(606, 267);
            this.OMfinals.Name = "OMfinals";
            this.OMfinals.Size = new System.Drawing.Size(0, 13);
            this.OMfinals.TabIndex = 28;
            // 
            // OMname
            // 
            this.OMname.AutoSize = true;
            this.OMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OMname.Location = new System.Drawing.Point(606, 173);
            this.OMname.Name = "OMname";
            this.OMname.Size = new System.Drawing.Size(0, 13);
            this.OMname.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label16.Location = new System.Drawing.Point(495, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Average:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.OMname);
            this.Controls.Add(this.OMfinals);
            this.Controls.Add(this.OMmidterm);
            this.Controls.Add(this.OMprelim);
            this.Controls.Add(this.horizontalLine);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel horizontalLine;
        private System.Windows.Forms.Label OMprelim;
        private System.Windows.Forms.Label OMmidterm;
        private System.Windows.Forms.Label OMfinals;
        private System.Windows.Forms.Label OMname;
        private System.Windows.Forms.Label label16;
    }
}

