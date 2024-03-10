using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Hostel_Management_System
{
    public partial class SupprimerClient : Form
    {
        Connexion d = new Connexion();
        ClassMAJ maj = new ClassMAJ();

            public SupprimerClient()
        {
            InitializeComponent();
        }

        public void RemplirComboCin()
        {
            d.CONNECTER();
            Cincmb.Items.Clear();

            d.cmd.Connection = d.cnx;
            d.cmd.CommandText = "Select distinct CIN from Clients";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
               Cincmb .Items.Add(d.dr[0]);
            }
            d.DECONNECTER();
        }

        private void SupprimerClient_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
            RemplirComboCin();
            RemplirDataGridView();
            d.DECONNECTER();
        }


        //Combobox precharge et rempli datagrid
        

        private void btnsupp_Click(object sender, EventArgs e)
        {
            if (Cincmb.Text == "")
            {
                MessageBox.Show("Donner un Cin");
                return;
            }
            if (maj.Supprimer(Cincmb.Text) == true)
            {
                MessageBox.Show("Le Clients Est Supprimer avec Succes");
                this.Controls.Clear();
                this.InitializeComponent();
                RemplirDataGridView();
                RemplirComboCin();
  
            }
            else
            {
                MessageBox.Show("Cette Clients N'existe Pas");
            }
        }
        //Datagridview
        public void RemplirDataGridView()
        {
            d.CONNECTER();
            if (d.dt.Rows != null)
            {
                d.dt.Clear();
            }
            d.cmd.CommandText = "Select * from Clients ";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView1.DataSource = d.dt;
            d.dr.Close();
        }
        //BUTTON DE NAVIGATION
        public static int position;
        public void naviger()
        { 
            Cincmb.Text = d.dt.Rows[position][0].ToString();
            txtnom.Text = d.dt.Rows[position][1].ToString();
            txtprenom.Text = d.dt.Rows[position][2].ToString();
            txtsexe.Text = d.dt.Rows[position][3].ToString();
            txtdate.Text = d.dt.Rows[position][4].ToString();
            txtemail.Text = d.dt.Rows[position][5].ToString();
            txttel.Text = d.dt.Rows[position][6].ToString();
        }
 

        private void Cincmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                d.DECONNECTER();
                d.CONNECTER();
                d.cmd.CommandText = "select * from Clients where CIN ='" + Cincmb.Text + "'";
                d.cmd.Connection = d.cnx;
                d.dr = d.cmd.ExecuteReader();
                if (d.dr.Read())
                {
                    txtprenom.Text = d.dr[2].ToString();
                    txtnom.Text = d.dr[1].ToString();
                    txtdate.Text = d.dr[4].ToString();
                    txttel.Text = d.dr[6].ToString();
                    txtemail.Text = d.dr[5].ToString();
                    txtsexe.Text = d.dr[3].ToString();
                }
                d.DECONNECTER();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Probleme au niveau de comcin");
            }
        }

     

        private void btnPremier_Click(object sender, EventArgs e)
        {
            position = 0;
            naviger();
        }

        private void btndernier_Click(object sender, EventArgs e)
        {
            position = d.dt.Rows.Count - 1;
            naviger();
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
                MessageBox.Show("Vous etes dans le dernier Clients");
            }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cincmb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtdate.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtnom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtprenom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtsexe.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtemail.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txttel.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pas D'information ici !!");
            }
        }
    }
}
