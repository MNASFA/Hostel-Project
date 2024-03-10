using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hostel_Management_System
{
    class Connexion
    {
        static string databasename = "Db_Hostel.mdf";
        public SqlConnection cnx = new SqlConnection();
        public DataSet ds = new DataSet();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();


      
        public void CONNECTER()
        {
            if (cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                cnx.ConnectionString = "Data Source=DESKTOP-36NPON6;Initial Catalog=Db_Hostel;Integrated Security=True";
                cnx.Open();
            }
        }


        //Methode deconnecter
        public void DECONNECTER()
        {

            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
    }
}
