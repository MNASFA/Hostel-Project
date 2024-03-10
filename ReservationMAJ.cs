using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hostel_Management_System
{
    class ReservationMAJ
    {

        Connexion d = new Connexion();



        //Start Button Ajoutter
        //Methode Nombre 
        public int nombre(string txtnum)
        {
            d.CONNECTER();
            int cpt;
            d.cmd.CommandText = "Select count(IdREservation) from Reservation where IdReservation ='" + txtnum + "'";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
            d.DECONNECTER();
        }

        public int nombre2(string cin)
        {
            d.CONNECTER();
            int cpt;
            d.cmd.CommandText = "Select count(Cin_Client) from Reservation where Cin_Client ='" + cin + "'";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
            d.DECONNECTER();
        }
        //Declaeration de la methode Ajoutter
        public bool AJOUTTER(string txtid , string dateentree, string datesortie,string cinclient,int numchambre ,string Payees)
        {
            d.CONNECTER();
            if (nombre(txtid) == 0)
            {
                d.cmd.CommandText = "insert into Reservation values ('" + dateentree + "','" + datesortie + "','" + cinclient + "','" + numchambre + "','" + Payees + "')";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
            d.DECONNECTER();
        }

        //End Buttton Ajoutter

        //methode moudifier
        public bool Modifier(string txtid , string dateentree, string datesortie, string cinclient, int numchambre,string Payees )
        {
            if (nombre(txtid) != 0)
            {
                d.cmd.CommandText = "update Reservation set DateEntree='" + dateentree + "',DateSortie='" + datesortie + "',Cin_Client='" + cinclient+ "',Num_Chambres='" + numchambre + "',Payees='" + Payees + "' where IdReservation ='" + txtid + "'";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        //methode Supprimer
        //public bool Supprimer(string txtid)
        //{
        //    if (nombre(txtid) != 0)
        //    {
        //        d.cmd.CommandText = "delete from Reservation where IdReservation ='" + txtid + "'";
        //        d.cmd.Connection = d.cnx;
        //        d.cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    return false;
        //}
    }
}
