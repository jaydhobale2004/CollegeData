namespace COLLEGEDATA
{
    partial class LECTURER_FORM
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBOCOUNTY1 = new System.Windows.Forms.ComboBox();
            this.MALERDOBTN1 = new System.Windows.Forms.RadioButton();
            this.FEMALERDOBTN1 = new System.Windows.Forms.RadioButton();
            this.DOBPICKER1 = new System.Windows.Forms.DateTimePicker();
            this.PAYTXT1 = new System.Windows.Forms.TextBox();
            this.NAMETXT1 = new System.Windows.Forms.TextBox();
            this.ADDRESSTXT1 = new System.Windows.Forms.TextBox();
            this.PHONENUMBERTXT1 = new System.Windows.Forms.TextBox();
            this.EMAILTXT1 = new System.Windows.Forms.TextBox();
            this.SUBMIT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADDRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "GENDER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "COUNTY";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "PAY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "PHONE NUMBER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "EMAIL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBOCOUNTY1);
            this.groupBox1.Controls.Add(this.MALERDOBTN1);
            this.groupBox1.Controls.Add(this.FEMALERDOBTN1);
            this.groupBox1.Controls.Add(this.DOBPICKER1);
            this.groupBox1.Controls.Add(this.PAYTXT1);
            this.groupBox1.Controls.Add(this.NAMETXT1);
            this.groupBox1.Controls.Add(this.ADDRESSTXT1);
            this.groupBox1.Controls.Add(this.PHONENUMBERTXT1);
            this.groupBox1.Controls.Add(this.EMAILTXT1);
            this.groupBox1.Controls.Add(this.SUBMIT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(141, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 459);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LECTURER INFORMATION";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CBOCOUNTY1
            // 
            this.CBOCOUNTY1.FormattingEnabled = true;
            this.CBOCOUNTY1.Location = new System.Drawing.Point(194, 209);
            this.CBOCOUNTY1.Name = "CBOCOUNTY1";
            this.CBOCOUNTY1.Size = new System.Drawing.Size(121, 26);
            this.CBOCOUNTY1.TabIndex = 17;
            // 
            // MALERDOBTN1
            // 
            this.MALERDOBTN1.AutoSize = true;
            this.MALERDOBTN1.Checked = true;
            this.MALERDOBTN1.Location = new System.Drawing.Point(175, 173);
            this.MALERDOBTN1.Name = "MALERDOBTN1";
            this.MALERDOBTN1.Size = new System.Drawing.Size(73, 22);
            this.MALERDOBTN1.TabIndex = 16;
            this.MALERDOBTN1.TabStop = true;
            this.MALERDOBTN1.Text = "MALE";
            this.MALERDOBTN1.UseVisualStyleBackColor = true;
            this.MALERDOBTN1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // FEMALERDOBTN1
            // 
            this.FEMALERDOBTN1.AutoSize = true;
            this.FEMALERDOBTN1.Location = new System.Drawing.Point(311, 175);
            this.FEMALERDOBTN1.Name = "FEMALERDOBTN1";
            this.FEMALERDOBTN1.Size = new System.Drawing.Size(94, 22);
            this.FEMALERDOBTN1.TabIndex = 15;
            this.FEMALERDOBTN1.Text = "FEMALE";
            this.FEMALERDOBTN1.UseVisualStyleBackColor = true;
            // 
            // DOBPICKER1
            // 
            this.DOBPICKER1.Location = new System.Drawing.Point(167, 88);
            this.DOBPICKER1.Name = "DOBPICKER1";
            this.DOBPICKER1.Size = new System.Drawing.Size(290, 24);
            this.DOBPICKER1.TabIndex = 14;
            // 
            // PAYTXT1
            // 
            this.PAYTXT1.Location = new System.Drawing.Point(206, 356);
            this.PAYTXT1.Name = "PAYTXT1";
            this.PAYTXT1.Size = new System.Drawing.Size(100, 24);
            this.PAYTXT1.TabIndex = 13;
            // 
            // NAMETXT1
            // 
            this.NAMETXT1.Location = new System.Drawing.Point(206, 43);
            this.NAMETXT1.Name = "NAMETXT1";
            this.NAMETXT1.Size = new System.Drawing.Size(100, 24);
            this.NAMETXT1.TabIndex = 12;
            this.NAMETXT1.TextChanged += new System.EventHandler(this.NAMETXT1_TextChanged);
            // 
            // ADDRESSTXT1
            // 
            this.ADDRESSTXT1.Location = new System.Drawing.Point(206, 124);
            this.ADDRESSTXT1.Name = "ADDRESSTXT1";
            this.ADDRESSTXT1.Size = new System.Drawing.Size(100, 24);
            this.ADDRESSTXT1.TabIndex = 11;
            // 
            // PHONENUMBERTXT1
            // 
            this.PHONENUMBERTXT1.Location = new System.Drawing.Point(206, 255);
            this.PHONENUMBERTXT1.Name = "PHONENUMBERTXT1";
            this.PHONENUMBERTXT1.Size = new System.Drawing.Size(100, 24);
            this.PHONENUMBERTXT1.TabIndex = 10;
            // 
            // EMAILTXT1
            // 
            this.EMAILTXT1.Location = new System.Drawing.Point(206, 305);
            this.EMAILTXT1.Name = "EMAILTXT1";
            this.EMAILTXT1.Size = new System.Drawing.Size(100, 24);
            this.EMAILTXT1.TabIndex = 9;
            // 
            // SUBMIT
            // 
            this.SUBMIT.Location = new System.Drawing.Point(194, 406);
            this.SUBMIT.Name = "SUBMIT";
            this.SUBMIT.Size = new System.Drawing.Size(121, 33);
            this.SUBMIT.TabIndex = 8;
            this.SUBMIT.Text = "SUBMIT";
            this.SUBMIT.UseVisualStyleBackColor = true;
            this.SUBMIT.Click += new System.EventHandler(this.SUBMIT_Click);
            // 
            // LECTURER_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.groupBox1);
            this.Name = "LECTURER_FORM";
            this.Text = "LECTURER_FORM";
            this.Load += new System.EventHandler(this.LECTURER_FORM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DOBPICKER1;
        private System.Windows.Forms.TextBox PAYTXT1;
        private System.Windows.Forms.TextBox NAMETXT1;
        private System.Windows.Forms.TextBox ADDRESSTXT1;
        private System.Windows.Forms.TextBox PHONENUMBERTXT1;
        private System.Windows.Forms.TextBox EMAILTXT1;
        private System.Windows.Forms.Button SUBMIT;
        private System.Windows.Forms.RadioButton MALERDOBTN1;
        private System.Windows.Forms.RadioButton FEMALERDOBTN1;
        private System.Windows.Forms.ComboBox CBOCOUNTY1;
    }
}