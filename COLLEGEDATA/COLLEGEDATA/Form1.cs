using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLLEGEDATA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ADDSTUDENTBTN_Click(object sender, EventArgs e)
        {
            STUDENT_FORM sTUDENT = new STUDENT_FORM();
            sTUDENT.ShowDialog();
        }

        private void ADDLECTURERBTN_Click(object sender, EventArgs e)
        {
            LECTURER_FORM lECTURER = new LECTURER_FORM();
            lECTURER.ShowDialog();

        }

        private void VIEWDATABTN_Click(object sender, EventArgs e)
        {
            VIEW vIEW=new VIEW();
            vIEW.ShowDialog();
        }
    }
}
