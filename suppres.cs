using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hostel_Management_System
{
   
    class suppres
    {
        Connexion d = new Connexion();

        public int nombre(string txtid)
        {
            d.CONNECTER();
            int cpt;
            d.cmd.CommandText = "Select count(Id) from Reserve where Id ='" + txtid + "'";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
            d.DECONNECTER();
        }

        public bool Supprimer(string txtid)
        {
            if (nombre(txtid) != 0)
            {
                d.cmd.CommandText = "delete from Reserve where Id ='" + txtid + "'";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }


    }
}
