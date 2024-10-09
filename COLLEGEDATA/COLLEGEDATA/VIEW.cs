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
    public partial class VIEW : Form
    {
        public VIEW()
        {
            InitializeComponent();
        }
        DAO dao = new DAO();
        SqlDataAdapter da;
        DataTable dt;

        private void VIEW_Load(object sender, EventArgs e)
        {
            CBOCOUNTY.DataSource=Enum.GetValues(typeof(COUNTIES));
            CBOGENDER.DataSource= Enum.GetValues(typeof(GENDER));
        }
        


        void LoadStudentData()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OPENC().CreateCommand();
            cmd.CommandText = "USPGETSTUDENT";
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dao.CLOSEC();
        }

        void LoadLecturerData()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OPENC().CreateCommand();
            cmd.CommandText = "USPGETLECTURER";
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dao.CLOSEC();
        }

        private void VIEWBTN_Click(object sender, EventArgs e)
        {
            LoadStudentData();

            if (ABOVE25CHECKBOX.Checked)
            {
                int sd = 25;
                da = new SqlDataAdapter();
                dt = new DataTable();

                SqlCommand cmd = dao.OPENC().CreateCommand();
                cmd.CommandText = "USPSTARTDATE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sd", sd);

                da.SelectCommand = cmd;
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dao.CLOSEC();
            }
        }

        private void SELECTBTN1_Click(object sender, EventArgs e)
        {
            string gen = CBOGENDER.SelectedItem.ToString();

            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OPENC().CreateCommand();
            cmd.CommandText = "USPGEN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@gen", gen);

            da.SelectCommand = cmd;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dao.CLOSEC();
        }

        private void SELECTBTN_Click(object sender, EventArgs e)
        {
            string cy = CBOCOUNTY.SelectedItem.ToString();


            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = dao.OPENC().CreateCommand();
            cmd.CommandText = "USPSELECTCOUNTY";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cy", cy);

            da.SelectCommand = cmd;
            da.Fill(dt);
             dataGridView1.DataSource = dt;
            dao.CLOSEC();
        }

        private void ALLLECTUREBTN_Click(object sender, EventArgs e)
        {
            LoadLecturerData();
        }
    }
}
