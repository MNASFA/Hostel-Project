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
using System.Data;

namespace Hostel_Management_System
{
    
    public partial class Room : Form
    {
        Connexion d = new Connexion();
        ChambresMaj maj = new ChambresMaj();
        

        public Room()
        {
            InitializeComponent();
        }
        public void RemplirDataGridView()
        {
            d.CONNECTER();
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = "Select * from Chambres where Numero != '"+0+"'"; 
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView1.DataSource = d.dt;
            d.dr.Close();
            d.DECONNECTER();
        }

        public void RemplirCmbnumero()
        {
            d.CONNECTER();
            cmbnum.Items.Clear();
            d.cmd.Connection = d.cnx;
            d.cmd.CommandText = "Select distinct Numero from Chambres";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                cmbnum.Items.Add(d.dr[0]);
            }
            d.DECONNECTER();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
            RemplirDataGridView();
            RemplirCmbnumero();
           
        }

        

        private void btnsearch_Click(object sender, EventArgs e)
        {
            d.CONNECTER();
            if (txtnumber.Text == "")
            {
                MessageBox.Show(" Merci de saisir un Numero !!");
            }
            if (maj.nombre(Convert.ToInt32(txtnumber.Text)) == 0)
            {
                MessageBox.Show("La Chambre n'existe pas !!");
            }
            else
            {
                d.DECONNECTER();
                d.CONNECTER();
                d.cmd.CommandText = "select * from Chambres where Numero ='" + txtnumber.Text + "'";
                d.cmd.Connection = d.cnx;
                d.dr = d.cmd.ExecuteReader();
                if (d.dr.Read())
                {
                    cmbnum.Text = d.dr[0].ToString();
                    txtcapacite.Text = d.dr[1].ToString();
                    txtprix.Text = d.dr[2].ToString();
                    cmbstatus.Text = d.dr[3].ToString();
                }
                d.DECONNECTER();

            }
        }
 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                cmbnum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtcapacite.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtprix.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbstatus.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           
            
        }

        private void btnajt_Click(object sender, EventArgs e)
        {
            try
            {
                d.CONNECTER();
                maj.nombre(Convert.ToInt32(cmbnum.Text));

                if (cmbnum.Text == "" || txtcapacite.Text == "" || txtprix.Text == "" || cmbstatus.Text == "")
                {
                    MessageBox.Show("Remplir tout les champs s'il vous plais ");
                    return;
                }
                if (maj.AJOUTTER(Convert.ToInt32(cmbnum.Text), Convert.ToInt32(txtcapacite.Text), Convert.ToDouble(txtprix.Text), cmbstatus.Text) == true)
                {
                    MessageBox.Show("La Chambre Est Ajoutter avec Succes");
                    RemplirDataGridView();
                }
                else
                {
                    MessageBox.Show("La Chambre existe deja ");
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
                if (cmbnum.Text == "" || txtcapacite.Text == "" || txtprix.Text == "" || cmbstatus.Text == "")
                {
                    MessageBox.Show("Remplir tout les champs s'il vous plais ");
                    return;
                }
                if (maj.Modifier(Convert.ToInt32(cmbnum.Text), Convert.ToInt32(txtcapacite.Text), Convert.ToDouble(txtprix.Text), cmbstatus.Text) == true)
                {
                    MessageBox.Show("La Chambre Est Modifier avec Succes");
                    this.Controls.Clear();
                    this.InitializeComponent();
                    RemplirDataGridView();
                    RemplirCmbnumero();
                }
                else
                {
                    MessageBox.Show("La chambre  n'existe pas ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modification non autorisée");
            }
        }

        private void btnsupp_Click(object sender, EventArgs e)
        { 
                if (cmbnum.Text == "")
                {
                    MessageBox.Show("Donner une Chambre");
                    return;
                }
                if (maj.Supprimer(Convert.ToInt32(cmbnum.Text)) == true)
                {
                    MessageBox.Show("La Chambre Est Supprimer avec Succes");
                        this.Controls.Clear();
                        this.InitializeComponent();
                        RemplirDataGridView();
                        RemplirCmbnumero();   
                }
                else
                {
                    MessageBox.Show("Cette Chambres N'existe Pas");
                }
            
        }

        public static int position;
        public void naviger()
        {
            cmbnum.Text = d.dt.Rows[position][0].ToString();
            txtcapacite.Text = d.dt.Rows[position][1].ToString();
            txtprix.Text = d.dt.Rows[position][2].ToString();
            cmbstatus.Text = d.dt.Rows[position][3].ToString();
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
                MessageBox.Show("Vous etes dans le premier Clients");
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
                MessageBox.Show("Vous etes dans le premier Clients");
            }
        }

        private void btndernier_Click(object sender, EventArgs e)
        {
            position = d.dt.Rows.Count - 1;
            naviger();
        }

        private void btnvider_Click_1(object sender, EventArgs e)
        {
            cmbnum.Text = "";
            txtcapacite.Text = "";
            txtprix.Text = "";
            cmbstatus.Text = "";
            txtnumber.Text = "";
        }

        
    }
}
