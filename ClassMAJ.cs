using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hostel_Management_System
{
    
    class ClassMAJ
    {
        Connexion d = new Connexion();


       
        //Start Button Ajoutter
        //Methode Nombre 
        public int nombre( string txtcin )
        {
            d.CONNECTER();
            int cpt;
            d.cmd.CommandText = "Select count(CIN) from Clients where CIN ='" + txtcin + "'";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
            d.DECONNECTER();
        }
        //Declaeration de la methode Ajoutter
        public bool AJOUTTER(string txtcin, string txtprenom, string txtnom, string txttel, string txtemail, string dtp , string cmbsexe)
        {
            d.CONNECTER();
            if (nombre(txtcin) == 0)
            {
                d.cmd.CommandText = "insert into Clients values ('" + txtcin + "','" + txtnom + "','" + txtprenom  + "','"  + cmbsexe + "','"  + dtp + "','"  + txtemail + "','" + txttel +"')" ;
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
            d.DECONNECTER();
        }

        //End Buttton Ajoutter

        //methode moudifier
        public bool Modifier(string txtcin, string txtprenom, string txtnom, string txttel, string txtemail,  string dtp, string cmbsexe)
        {
            if (nombre(txtcin) != 0)
            {
                d.cmd.CommandText = "update Clients set Nom='" +  txtnom + "',Prenom='" + txtprenom + "',Sexe='" + cmbsexe + "',Datenaissance='" + dtp + "',Email='" + txtemail + "',Telephone='" + txttel + "' where CIN ='" + txtcin + "'";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        //methode Supprimer
        public bool Supprimer(string txtcin)
        {
            if (nombre(txtcin) != 0)
            {
                d.cmd.CommandText = "delete from Clients where Cin ='" + txtcin + "'";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }




    }
}
