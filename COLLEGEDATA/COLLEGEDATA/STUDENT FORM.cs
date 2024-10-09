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
    public partial class STUDENT_FORM : Form
    {
        public STUDENT_FORM()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""\\DBS-FS.student.dbs.ie\CTX.XA.Profiles.Data.New\10635231\Desktop\OOPS ASSIGNMENT 10635231\COLLEGEDATA\COLLEGEDATA\OOPSASSIGNMENTDATABASE.mdf"";Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void STUDENT_FORM_Load(object sender, EventArgs e)
        {
            COUNTYCBO.DataSource=Enum.GetValues(typeof(COUNTIES));
        }

        private void SUBMITBTN_Click(object sender, EventArgs e)
        {
            string nm=NAMETXT.Text;
            string dob = DOBPICKER.Text;
            string cy=COUNTYCBO.Text;
            string gen = "MALE";
            if (FEMALERDOBTN.Checked)
                gen = "FEMALE";
            string phn=PHONETXT.Text;
            string add=ADDRESSTXT.Text;
            string em=EMAILTXT.Text;
            string stn=STUDENTTXT.Text;
            string insert = "INSERT INTO Studentdatabese(NAME,DOB,PHONE,ADDRESS,GENDER,EMAIL,COUNTY,STUDENTNUMBER) VALUES(@nm,@dob,@phn,@add,@gen,@em,@cy,@stn)";

            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@nm", nm);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@gen", gen);
            cmd.Parameters.AddWithValue("@phn", phn);
            cmd.Parameters.AddWithValue("@add", add);
            cmd.Parameters.AddWithValue("@em", em);
            cmd.Parameters.AddWithValue("@stn", stn);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            NAMETXT.Clear();
            PHONETXT.Clear();
            ADDRESSTXT.Clear();
            EMAILTXT.Clear();
            STUDENTTXT.Clear();

        }
    }
}
