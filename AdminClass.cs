using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hostel_Management_System
{
    class AdminClass
    {
        Connexion d = new Connexion();



        //Start Button Ajoutter
        //Methode Nombre 
        public int nombre(int txtmat)
        {
            d.CONNECTER();
            int cpt;
            d.cmd.CommandText = "Select count(Matricule) from Employees where Matricule ='" + txtmat + "'";
            d.cmd.Connection = d.cnx;
            cpt = (int)d.cmd.ExecuteScalar();
            return cpt;
            d.DECONNECTER();
        }
        //Declaeration de la methode Ajoutter
        public bool AJOUTTER(int txtmat, string txtnom, string txtprenom, string txttel, string txtuser, string mdp)
        {
            d.CONNECTER();
            if (nombre(txtmat) == 0)
            {
                d.cmd.CommandText = "insert into Employees values ('" + txtmat + "','" + txtnom + "','" + txtprenom + "','" + txttel + "','" + txtuser + "','" + mdp + "')";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
            d.DECONNECTER();
        }

        //End Buttton Ajoutter

        //methode moudifier
        public bool Modifier(int txtmat, string txtnom, string txtprenom, string txttel, string txtuser, string mdp)
        {
            if (nombre(txtmat) != 0)
            {
                d.cmd.CommandText = "update Employees set Nom='" + txtnom + "',Prenom='" + txtprenom + "',Telephone='" + txttel + "',Username='" + txtuser + "',Password='" + mdp + "' where Matricule ='" + txtmat + "'";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
        //methode Supprimer
        public bool Supprimer(int  txtmat)
        {
            if (nombre(txtmat) != 0)
            {
                d.cmd.CommandText = "delete from Employees where Matricule ='" + txtmat + "'";
                d.cmd.Connection = d.cnx;
                d.cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }
    }
}
