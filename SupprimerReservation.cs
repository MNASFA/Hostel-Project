using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hostel_Management_System
{
    public partial class SupprimerReservation : Form
    {
        public SupprimerReservation()
        {
            InitializeComponent();
        }
        Connexion d = new Connexion();
        suppres maj = new suppres();

        public void RemplirCmbnumchambre()
        {
            string dispo;
            dispo = "Indisponible";
            d.CONNECTER();
            numchambre.Items.Clear();
            d.cmd.Connection = d.cnx;
            d.cmd.CommandText = "Select distinct Numero from Chambres where Status = '" + dispo + "' ";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                numchambre.Items.Add(d.dr[0]);
            }
            d.DECONNECTER();
        }



        private void numchambre_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void SupprimerReservation_Load(object sender, EventArgs e)
        {
            RemplirCmbnumchambre();
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            if (cmbidres.Text == "")
            {
                MessageBox.Show("Donner une Reservation");
                return;
            }
            if (maj.Supprimer(cmbidres.Text) == true)
            {
                MessageBox.Show("La Reservation Est Supprimer avec Succes");
                this.Controls.Clear();
                this.InitializeComponent();
                RemplirCmbnumchambre();

            }
            else
            {
                MessageBox.Show("Cette Reservation N'existe Pas");
            }

        }
    }
}
