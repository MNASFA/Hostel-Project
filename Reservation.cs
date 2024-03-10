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


    public partial class Reservation : Form
    {

        Connexion d = new Connexion();
        ReservationMAJ maj = new ReservationMAJ();

        public Reservation()
        {
            InitializeComponent();
        }

        //Datagridview
        public void RemplirDataGridView()
        {
            d.CONNECTER();
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = " select  Reservation.*,Prenom,Nom from Reservation inner join Clients on Reservation.Cin_Client = Clients.Cin ";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView1.DataSource = d.dt;
            d.dr.Close();
        }
         
        public void RemplirCmbcin()
        {
            
            d.CONNECTER();
            cinclient.Items.Clear();
            d.cmd.Connection = d.cnx;
            d.cmd.CommandText = "Select distinct Cin from Clients";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                cinclient.Items.Add(d.dr[0]);
            }
         
            d.DECONNECTER();
        }
        public void RemplirCmbnumchambre()
        {
            string dispo;
            dispo="Disponible";
            d.CONNECTER();
            numchambre.Items.Clear();
            d.cmd.Connection = d.cnx;
            d.cmd.CommandText = "Select distinct Numero from Chambres where Status = '"+ dispo+"' ";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                numchambre.Items.Add(d.dr[0]);
            }
      
            d.DECONNECTER();
        }
        

        private void Reservation_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
            RemplirDataGridView();
            RemplirCmbnumchambre();
            RemplirCmbcin();
           
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            d.CONNECTER();
            if (txtidsearch.Text == "")
            {
                MessageBox.Show(" Merci de saisir un Numero !!");
            }
            if (maj.nombre(txtidsearch.Text)== 0)
            {
                MessageBox.Show("La Reservation n'existe pas !!");
            }
            else
            {
                d.DECONNECTER();
                d.CONNECTER();
                d.cmd.CommandText = "select * from Reservation where IdReservation ='" + txtidsearch.Text + "'";
                d.cmd.Connection = d.cnx;
                d.dr = d.cmd.ExecuteReader();
                if (d.dr.Read())
                {
                    cmbidres.Text = d.dr[0].ToString();
                    dateentree.Text = d.dr[1].ToString();
                    datesortie.Text = d.dr[2].ToString();
                    cinclient.Text = d.dr[3].ToString();
                    numchambre.Text = d.dr[4].ToString();
                    cmbpayees.Text = d.dr[5].ToString();
                }
                d.DECONNECTER();
            }
        }

        private void btnvider_Click(object sender, EventArgs e)
        {
            txtidsearch.Text = "";
            cmbidres.Text = "";
            cmbpayees.Text = "No";
            dateentree.Text = "";
            datesortie.Text = "";
            cinclient.Text = "";
            numchambre.Text = "";

            

        }
        public static int position;
        public void naviger()
        {
            cmbidres.Text = d.dt.Rows[position][0].ToString();
            dateentree.Text = d.dt.Rows[position][1].ToString();
            datesortie.Text = d.dt.Rows[position][2].ToString();
            cinclient.Text = d.dt.Rows[position][3].ToString();
            numchambre.Text = d.dt.Rows[position][4].ToString();
            cmbpayees.Text = d.dt.Rows[position][5].ToString();

        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            position = 0;
            naviger();
        }

        private void btnprecident_Click(object sender, EventArgs e)
        {
            try
            {
                position--;
                naviger();
            }
            catch
            {
                MessageBox.Show("Vous etes dans la premier Reservation");
            }
        }

        private void btnsuivant_Click(object sender, EventArgs e)
        {
            try
            {
                position++;
                naviger();
            }
            catch
            {
                MessageBox.Show("Vous etes dans la Dernier Reservation");
            }
        }

        private void btndernier_Click(object sender, EventArgs e)
        {
            position = d.dt.Rows.Count - 1;
            naviger();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                cmbidres.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                dateentree.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                datesortie.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cinclient.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                numchambre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cmbpayees.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
 
        }

        private void btnajt_Click(object sender, EventArgs e)
        {
            try
            {
                d.CONNECTER();
                maj.nombre(cmbidres.Text);

                if (  dateentree.Text == "" || datesortie.Text == "" || numchambre.Text == "" || cinclient.Text == "" || cmbpayees.Text =="")
                {
                    MessageBox.Show("Remplir tout les champs s'il vous plais ");
                    return;
                }
                if (maj.AJOUTTER(cmbidres.Text  , dateentree.Text , datesortie.Text , cinclient.Text, Convert.ToInt32(numchambre.Text),cmbpayees.Text) == true)
                {
                    MessageBox.Show("La Reservation Est Ajoutter avec Succes");
                    this.Controls.Clear();
                    this.InitializeComponent();
                    RemplirDataGridView();
                    RemplirCmbcin();
                    RemplirCmbnumchambre();

                }
                else
                {
                    MessageBox.Show("La Reservation existe deja ");
                }
                d.DECONNECTER();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probleme au niveau de Remplissage");
            }
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            try
            {
                if (  dateentree.Text == "" || datesortie.Text == "" || numchambre.Text == "" || cinclient.Text == "" || cmbpayees.Text =="")
                {
                    MessageBox.Show("Remplir tout les champs s'il vous plais ");
                    return;
                }
                if (maj.Modifier(cmbidres.Text , dateentree.Text, datesortie.Text, cinclient.Text, Convert.ToInt32(numchambre.Text),cmbpayees.Text) == true)
                {
                    MessageBox.Show("La Reservation Est Modifier avec Succes");
                    this.Controls.Clear();
                    this.InitializeComponent();
                    RemplirDataGridView();
                    RemplirCmbcin();
                    RemplirCmbnumchambre();
                }
                else
                {
                    MessageBox.Show("La Reservation  n'existe pas ");
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Modification non autorisée");
            }
}

        private void btnsupp_Click(object sender, EventArgs e)
        {
            //if (cmbidres.Text == "")
            //{
            //    MessageBox.Show("Donner une Reservation");
            //    return;
            //}
            //if (maj.Supprimer(cmbidres.Text) == true)
            //{
            //    MessageBox.Show("La Reservation Est Supprimer avec Succes");
            //    this.Controls.Clear();
            //    this.InitializeComponent();
            //    RemplirDataGridView();
            //    RemplirCmbcin();
            //    RemplirCmbnumchambre();

            //}
            //else
            //{
            //    MessageBox.Show("Cette Reservation N'existe Pas");
            //}
           

        }

       
    }
}
