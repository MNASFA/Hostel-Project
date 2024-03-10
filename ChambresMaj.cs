using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hostel_Management_System
{
    class ChambresMaj
    {

        Connexion d = new Connexion();



        //Start Button Ajoutter
        //Methode Nombre 
        public int nombre(int txtnum)
        {
            d.CONNECTER();
            int cpt;
            d.cmd.CommandText = "Select count(Numero) from Chambres where numero ='" + txtnum + "'";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
            d.DECONNECTER();
        }
        //Declaeration de la methode Ajoutter
        public bool AJOUTTER(int txtnum, int txtcap, Double txtprix, string txtsta )
        {
            d.CONNECTER();
            if (nombre(txtnum) == 0)
            {
                d.cmd.CommandText = "insert into Chambres values ('" + txtnum + "','" + txtcap + "','" +  txtprix + "','" + txtsta + "')";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
            d.DECONNECTER();
        }

        //End Buttton Ajoutter

        //methode moudifier
        public bool Modifier(int txtnum, int txtcap, double txtprix, string txtsta)
        {
            if (nombre(txtnum) != 0)
            {
                d.cmd.CommandText = "update Chambres set Capacity='" + txtcap + "',Prix='" + txtprix + "',Status='" + txtsta + "' where Numero ='" + txtnum + "'";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        //methode Supprimer
        public bool Supprimer(int txtnum)
        {
            if (nombre(txtnum) != 0)
            {
                d.cmd.CommandText = "delete from Chambres where Numero ='" + txtnum + "'";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }


    }
}
