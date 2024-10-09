namespace COLLEGEDATA
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
            this.ADDSTUDENTBTN = new System.Windows.Forms.Button();
            this.ADDLECTURERBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VIEWDATABTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADDSTUDENTBTN
            // 
            this.ADDSTUDENTBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDSTUDENTBTN.Location = new System.Drawing.Point(39, 206);
            this.ADDSTUDENTBTN.Name = "ADDSTUDENTBTN";
            this.ADDSTUDENTBTN.Size = new System.Drawing.Size(123, 66);
            this.ADDSTUDENTBTN.TabIndex = 0;
            this.ADDSTUDENTBTN.Text = "ADD STUDENT";
            this.ADDSTUDENTBTN.UseVisualStyleBackColor = true;
            this.ADDSTUDENTBTN.Click += new System.EventHandler(this.ADDSTUDENTBTN_Click);
            // 
            // ADDLECTURERBTN
            // 
            this.ADDLECTURERBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDLECTURERBTN.Location = new System.Drawing.Point(603, 210);
            this.ADDLECTURERBTN.Name = "ADDLECTURERBTN";
            this.ADDLECTURERBTN.Size = new System.Drawing.Size(138, 62);
            this.ADDLECTURERBTN.TabIndex = 1;
            this.ADDLECTURERBTN.Text = "ADD LECTURER";
            this.ADDLECTURERBTN.UseVisualStyleBackColor = true;
            this.ADDLECTURERBTN.Click += new System.EventHandler(this.ADDLECTURERBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "COLLEGE";
            // 
            // VIEWDATABTN
            // 
            this.VIEWDATABTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VIEWDATABTN.Location = new System.Drawing.Point(330, 299);
            this.VIEWDATABTN.Name = "VIEWDATABTN";
            this.VIEWDATABTN.Size = new System.Drawing.Size(111, 61);
            this.VIEWDATABTN.TabIndex = 3;
            this.VIEWDATABTN.Text = "VIEW DATA";
            this.VIEWDATABTN.UseVisualStyleBackColor = true;
            this.VIEWDATABTN.Click += new System.EventHandler(this.VIEWDATABTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VIEWDATABTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ADDLECTURERBTN);
            this.Controls.Add(this.ADDSTUDENTBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADDSTUDENTBTN;
        private System.Windows.Forms.Button ADDLECTURERBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VIEWDATABTN;
    }
}

