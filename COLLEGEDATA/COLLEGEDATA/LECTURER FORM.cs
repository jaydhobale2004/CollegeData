using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLLEGEDATA
{
    public partial class LECTURER_FORM : Form
    {
        public LECTURER_FORM()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""\\DBS-FS.student.dbs.ie\CTX.XA.Profiles.Data.New\10635231\Desktop\OOPS ASSIGNMENT 10635231\COLLEGEDATA\COLLEGEDATA\OOPSASSIGNMENTDATABASE.mdf"";Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {


        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void SUBMIT_Click(object sender, EventArgs e)
        {
            string nm1 = NAMETXT1.Text;
            string dob1=DOBPICKER1.Text;
            string phn1 = PHONENUMBERTXT1.Text;
            string add1=ADDRESSTXT1.Text;
            string gen1 = "MALE";
            if (FEMALERDOBTN1.Checked)
                gen1 = "FEMALE";
            string em1=EMAILTXT1.Text;
            string cy1=CBOCOUNTY1.Text;
            string py=PAYTXT1.Text;
            string insert = "INSERT INTO Lecturerdatabase(NAME,DOB,PHONE,ADDRESS,GENDER,EMAIL,COUNTY,PAY) VALUES(@nm1,@dob1,@phn1,@add1,@gen1,@em1,@cy1,@py)";
            SqlCommand cmd = new SqlCommand(insert,con);
            cmd.Parameters.AddWithValue("@nm1", nm1);
            cmd.Parameters.AddWithValue("@dob1", dob1);
            cmd.Parameters.AddWithValue("@phn1", phn1);
            cmd.Parameters.AddWithValue("@add1", add1);
            cmd.Parameters.AddWithValue("@gen1", gen1);
            cmd.Parameters.AddWithValue("@em1", em1);
            cmd.Parameters.AddWithValue("@cy1", cy1);
            cmd.Parameters.AddWithValue("@py", py);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            NAMETXT1.Clear();
            PHONENUMBERTXT1.Clear();
            EMAILTXT1.Clear();
            PAYTXT1.Clear();
            EMAILTXT1.Clear();



        }

        private void LECTURER_FORM_Load(object sender, EventArgs e)
        {
            CBOCOUNTY1.DataSource =Enum.GetValues(typeof(COUNTIES1));

        }

        private void NAMETXT1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
