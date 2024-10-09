using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace COLLEGEDATA
{
    internal class DAO
    {
        SqlConnection con;
        public DAO()
        {
            con= new SqlConnection(ConfigurationManager.ConnectionStrings["DBcon"].ConnectionString);
        }

        public SqlConnection OPENC()
        {
            if (con.State==ConnectionState.Closed|| con.State==ConnectionState.Open)
            {
                con.Open();
            }
            return con;
        }
        public void CLOSEC()
        {
            if(con!=null)
            {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

    }
   

}
