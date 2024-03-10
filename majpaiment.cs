using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hostel_Management_System
{
    class majpaiment
    {
        Connexion d = new Connexion();



        //Start Button Ajoutter
        //Methode Nombre 
        public int nombre(int cmbidp)
        {
            d.CONNECTER();
            int cpt;
            d.cmd.CommandText = "Select count(IdReservation) from Reservation where IdReservation ='" + cmbidp + "'";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
            d.DECONNECTER();
        }
        //Declaeration de la methode Ajoutter
        public bool AJOUTTER(int cmbid,int cmbidp, double montant, string type)
        {
            d.CONNECTER();
            if (nombre(cmbidp) == 0)
            {
                d.cmd.CommandText = "insert into Paiment values ('" + cmbidp + "','" + type + "','" + montant + "','" + cmbid + "')";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
            d.DECONNECTER();
        }

        //End Buttton Ajoutter

        
        ////methode moudifier
        //public bool Modifier(int cmbid, int cmbidp, string type, double montant)
        //{
        //    if (nombre(cmbidp) != 0)
        //    {
        //        d.cmd.CommandText = "update Paiment set Type_Paiment='" + type + "',Montant='" + montant +"',Id_Reservation='" + cmbid+ "' where Id_Paiment='" + cmbidp + "'";
        //        d.cmd.Connection = d.cnx;
        //        d.cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    return false;
        //}
        ////methode Supprimer
        //public bool Supprimer(int cmbidp)
        //{
        //    if (nombre(cmbidp) != 0)
        //    {
        //        d.cmd.CommandText = "delete from Paiment where Id_Paiment ='" + cmbidp + "'";
        //        d.cmd.Connection = d.cnx;
        //        d.cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    return false;
        //}
    }
}
