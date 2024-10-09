namespace COLLEGEDATA
{
    partial class STUDENT_FORM
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
            this.STUDENTGROUPBOX = new System.Windows.Forms.GroupBox();
            this.DOBPICKER = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.STUDENTTXT = new System.Windows.Forms.TextBox();
            this.COUNTYCBO = new System.Windows.Forms.ComboBox();
            this.FEMALERDOBTN = new System.Windows.Forms.RadioButton();
            this.MALERDOBTN = new System.Windows.Forms.RadioButton();
            this.EMAILTXT = new System.Windows.Forms.TextBox();
            this.ADDRESSTXT = new System.Windows.Forms.TextBox();
            this.PHONETXT = new System.Windows.Forms.TextBox();
            this.NAMETXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SUBMITBTN = new System.Windows.Forms.Button();
            this.STUDENTGROUPBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // STUDENTGROUPBOX
            // 
            this.STUDENTGROUPBOX.Controls.Add(this.DOBPICKER);
            this.STUDENTGROUPBOX.Controls.Add(this.label10);
            this.STUDENTGROUPBOX.Controls.Add(this.STUDENTTXT);
            this.STUDENTGROUPBOX.Controls.Add(this.COUNTYCBO);
            this.STUDENTGROUPBOX.Controls.Add(this.FEMALERDOBTN);
            this.STUDENTGROUPBOX.Controls.Add(this.MALERDOBTN);
            this.STUDENTGROUPBOX.Controls.Add(this.EMAILTXT);
            this.STUDENTGROUPBOX.Controls.Add(this.ADDRESSTXT);
            this.STUDENTGROUPBOX.Controls.Add(this.PHONETXT);
            this.STUDENTGROUPBOX.Controls.Add(this.NAMETXT);
            this.STUDENTGROUPBOX.Controls.Add(this.label8);
            this.STUDENTGROUPBOX.Controls.Add(this.label7);
            this.STUDENTGROUPBOX.Controls.Add(this.label6);
            this.STUDENTGROUPBOX.Controls.Add(this.label5);
            this.STUDENTGROUPBOX.Controls.Add(this.label4);
            this.STUDENTGROUPBOX.Controls.Add(this.label3);
            this.STUDENTGROUPBOX.Controls.Add(this.label2);
            this.STUDENTGROUPBOX.Controls.Add(this.label1);
            this.STUDENTGROUPBOX.Controls.Add(this.SUBMITBTN);
            this.STUDENTGROUPBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STUDENTGROUPBOX.Location = new System.Drawing.Point(68, 12);
            this.STUDENTGROUPBOX.Name = "STUDENTGROUPBOX";
            this.STUDENTGROUPBOX.Size = new System.Drawing.Size(568, 504);
            this.STUDENTGROUPBOX.TabIndex = 0;
            this.STUDENTGROUPBOX.TabStop = false;
            this.STUDENTGROUPBOX.Text = "STUDENT INFORMATION";
            this.STUDENTGROUPBOX.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DOBPICKER
            // 
            this.DOBPICKER.AllowDrop = true;
            this.DOBPICKER.CustomFormat = "dd MMMM yyyy";
            this.DOBPICKER.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBPICKER.Location = new System.Drawing.Point(230, 152);
            this.DOBPICKER.Name = "DOBPICKER";
            this.DOBPICKER.Size = new System.Drawing.Size(199, 24);
            this.DOBPICKER.TabIndex = 16;
            this.DOBPICKER.Value = new System.DateTime(2023, 12, 11, 16, 20, 33, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 413);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "STUDENT NUMBER";
            // 
            // STUDENTTXT
            // 
            this.STUDENTTXT.Location = new System.Drawing.Point(230, 410);
            this.STUDENTTXT.Name = "STUDENTTXT";
            this.STUDENTTXT.Size = new System.Drawing.Size(158, 24);
            this.STUDENTTXT.TabIndex = 14;
            // 
            // COUNTYCBO
            // 
            this.COUNTYCBO.FormattingEnabled = true;
            this.COUNTYCBO.Location = new System.Drawing.Point(230, 366);
            this.COUNTYCBO.Name = "COUNTYCBO";
            this.COUNTYCBO.Size = new System.Drawing.Size(121, 26);
            this.COUNTYCBO.TabIndex = 13;
            // 
            // FEMALERDOBTN
            // 
            this.FEMALERDOBTN.AutoSize = true;
            this.FEMALERDOBTN.Location = new System.Drawing.Point(311, 282);
            this.FEMALERDOBTN.Name = "FEMALERDOBTN";
            this.FEMALERDOBTN.Size = new System.Drawing.Size(94, 22);
            this.FEMALERDOBTN.TabIndex = 12;
            this.FEMALERDOBTN.Text = "FEMALE";
            this.FEMALERDOBTN.UseVisualStyleBackColor = true;
            // 
            // MALERDOBTN
            // 
            this.MALERDOBTN.AutoSize = true;
            this.MALERDOBTN.Checked = true;
            this.MALERDOBTN.Location = new System.Drawing.Point(174, 282);
            this.MALERDOBTN.Name = "MALERDOBTN";
            this.MALERDOBTN.Size = new System.Drawing.Size(73, 22);
            this.MALERDOBTN.TabIndex = 11;
            this.MALERDOBTN.TabStop = true;
            this.MALERDOBTN.Text = "MALE";
            this.MALERDOBTN.UseVisualStyleBackColor = true;
            // 
            // EMAILTXT
            // 
            this.EMAILTXT.Location = new System.Drawing.Point(230, 324);
            this.EMAILTXT.Name = "EMAILTXT";
            this.EMAILTXT.Size = new System.Drawing.Size(100, 24);
            this.EMAILTXT.TabIndex = 1;
            // 
            // ADDRESSTXT
            // 
            this.ADDRESSTXT.Location = new System.Drawing.Point(230, 242);
            this.ADDRESSTXT.Name = "ADDRESSTXT";
            this.ADDRESSTXT.Size = new System.Drawing.Size(100, 24);
            this.ADDRESSTXT.TabIndex = 2;
            // 
            // PHONETXT
            // 
            this.PHONETXT.Location = new System.Drawing.Point(230, 203);
            this.PHONETXT.Name = "PHONETXT";
            this.PHONETXT.Size = new System.Drawing.Size(100, 24);
            this.PHONETXT.TabIndex = 3;
            // 
            // NAMETXT
            // 
            this.NAMETXT.Location = new System.Drawing.Point(230, 109);
            this.NAMETXT.Name = "NAMETXT";
            this.NAMETXT.Size = new System.Drawing.Size(100, 24);
            this.NAMETXT.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "COUNTY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "EMAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "GENDER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "ADDRESS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "PHONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "DOB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "NAME";
            // 
            // SUBMITBTN
            // 
            this.SUBMITBTN.Location = new System.Drawing.Point(230, 460);
            this.SUBMITBTN.Name = "SUBMITBTN";
            this.SUBMITBTN.Size = new System.Drawing.Size(100, 27);
            this.SUBMITBTN.TabIndex = 1;
            this.SUBMITBTN.Text = "SUBMIT";
            this.SUBMITBTN.UseVisualStyleBackColor = true;
            this.SUBMITBTN.Click += new System.EventHandler(this.SUBMITBTN_Click);
            // 
            // STUDENT_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 531);
            this.Controls.Add(this.STUDENTGROUPBOX);
            this.Name = "STUDENT_FORM";
            this.Text = "STUDENT_FORM";
            this.Load += new System.EventHandler(this.STUDENT_FORM_Load);
            this.STUDENTGROUPBOX.ResumeLayout(false);
            this.STUDENTGROUPBOX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox STUDENTGROUPBOX;
        private System.Windows.Forms.Button SUBMITBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MALERDOBTN;
        private System.Windows.Forms.TextBox EMAILTXT;
        private System.Windows.Forms.TextBox ADDRESSTXT;
        private System.Windows.Forms.TextBox PHONETXT;
        private System.Windows.Forms.TextBox NAMETXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox STUDENTTXT;
        private System.Windows.Forms.ComboBox COUNTYCBO;
        private System.Windows.Forms.RadioButton FEMALERDOBTN;
        private System.Windows.Forms.DateTimePicker DOBPICKER;
    }
}