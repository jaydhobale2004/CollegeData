namespace COLLEGEDATA
{
    partial class VIEW
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.VIEWBTN = new System.Windows.Forms.Button();
            this.ABOVE25CHECKBOX = new System.Windows.Forms.CheckBox();
            this.SELECTBTN = new System.Windows.Forms.Button();
            this.ALLLECTUREBTN = new System.Windows.Forms.Button();
            this.SELECTBTN1 = new System.Windows.Forms.Button();
            this.CBOGENDER = new System.Windows.Forms.ComboBox();
            this.CBOCOUNTY = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(647, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // VIEWBTN
            // 
            this.VIEWBTN.Location = new System.Drawing.Point(39, 41);
            this.VIEWBTN.Name = "VIEWBTN";
            this.VIEWBTN.Size = new System.Drawing.Size(104, 46);
            this.VIEWBTN.TabIndex = 1;
            this.VIEWBTN.Text = "VIEW STUDENTS";
            this.VIEWBTN.UseVisualStyleBackColor = true;
            this.VIEWBTN.Click += new System.EventHandler(this.VIEWBTN_Click);
            // 
            // ABOVE25CHECKBOX
            // 
            this.ABOVE25CHECKBOX.AutoSize = true;
            this.ABOVE25CHECKBOX.Location = new System.Drawing.Point(172, 55);
            this.ABOVE25CHECKBOX.Name = "ABOVE25CHECKBOX";
            this.ABOVE25CHECKBOX.Size = new System.Drawing.Size(201, 20);
            this.ABOVE25CHECKBOX.TabIndex = 2;
            this.ABOVE25CHECKBOX.Text = "ABOVE 25 AGE STUDENTS";
            this.ABOVE25CHECKBOX.UseVisualStyleBackColor = true;
            // 
            // SELECTBTN
            // 
            this.SELECTBTN.Location = new System.Drawing.Point(573, 45);
            this.SELECTBTN.Name = "SELECTBTN";
            this.SELECTBTN.Size = new System.Drawing.Size(108, 42);
            this.SELECTBTN.TabIndex = 3;
            this.SELECTBTN.Text = "SELECT";
            this.SELECTBTN.UseVisualStyleBackColor = true;
            this.SELECTBTN.Click += new System.EventHandler(this.SELECTBTN_Click);
            // 
            // ALLLECTUREBTN
            // 
            this.ALLLECTUREBTN.Location = new System.Drawing.Point(39, 355);
            this.ALLLECTUREBTN.Name = "ALLLECTUREBTN";
            this.ALLLECTUREBTN.Size = new System.Drawing.Size(120, 42);
            this.ALLLECTUREBTN.TabIndex = 4;
            this.ALLLECTUREBTN.Text = "VIEW LECTURER";
            this.ALLLECTUREBTN.UseVisualStyleBackColor = true;
            this.ALLLECTUREBTN.Click += new System.EventHandler(this.ALLLECTUREBTN_Click);
            // 
            // SELECTBTN1
            // 
            this.SELECTBTN1.Location = new System.Drawing.Point(539, 362);
            this.SELECTBTN1.Name = "SELECTBTN1";
            this.SELECTBTN1.Size = new System.Drawing.Size(104, 35);
            this.SELECTBTN1.TabIndex = 5;
            this.SELECTBTN1.Text = "SELECT";
            this.SELECTBTN1.UseVisualStyleBackColor = true;
            this.SELECTBTN1.Click += new System.EventHandler(this.SELECTBTN1_Click);
            // 
            // CBOGENDER
            // 
            this.CBOGENDER.FormattingEnabled = true;
            this.CBOGENDER.Location = new System.Drawing.Point(312, 362);
            this.CBOGENDER.Name = "CBOGENDER";
            this.CBOGENDER.Size = new System.Drawing.Size(121, 24);
            this.CBOGENDER.TabIndex = 6;
            // 
            // CBOCOUNTY
            // 
            this.CBOCOUNTY.FormattingEnabled = true;
            this.CBOCOUNTY.Location = new System.Drawing.Point(401, 55);
            this.CBOCOUNTY.Name = "CBOCOUNTY";
            this.CBOCOUNTY.Size = new System.Drawing.Size(121, 24);
            this.CBOCOUNTY.TabIndex = 7;
            // 
            // VIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBOCOUNTY);
            this.Controls.Add(this.CBOGENDER);
            this.Controls.Add(this.SELECTBTN1);
            this.Controls.Add(this.ALLLECTUREBTN);
            this.Controls.Add(this.SELECTBTN);
            this.Controls.Add(this.ABOVE25CHECKBOX);
            this.Controls.Add(this.VIEWBTN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VIEW";
            this.Text = "VIEW";
            this.Load += new System.EventHandler(this.VIEW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button VIEWBTN;
        private System.Windows.Forms.CheckBox ABOVE25CHECKBOX;
        private System.Windows.Forms.Button SELECTBTN;
        private System.Windows.Forms.Button ALLLECTUREBTN;
        private System.Windows.Forms.Button SELECTBTN1;
        private System.Windows.Forms.ComboBox CBOGENDER;
        private System.Windows.Forms.ComboBox CBOCOUNTY;
    }
}