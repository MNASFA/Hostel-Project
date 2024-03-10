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
    public partial class MoudifierClient : Form
    {
        ClassMAJ maj = new ClassMAJ();
        Connexion d = new Connexion();
        public MoudifierClient()
        {
            InitializeComponent();
        }

        private void txtCIN_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void MoudifierClient_Load(object sender, EventArgs e)
        {
            txtCIN.PlaceholderText = "Saisir Un Cin";
            RemplirComboSexe();
        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //Rechercher
        private void btnsearch_Click(object sender, EventArgs e)
        {

            d.CONNECTER();
                if (txtCIN.Text == "")
                {
                    MessageBox.Show(" Merci de saisir un Cin !!");
                }
                if (maj.nombre(txtCIN.Text) == 0)
                {
                    MessageBox.Show("Le Client n'existe pas !!");
                }
                else
                {
                    d.DECONNECTER();
                    d.CONNECTER();
                    d.cmd.CommandText = "select * from Clients where CIN ='" + txtCIN.Text + "'";
                    d.cmd.Connection = d.cnx;
                    d.dr = d.cmd.ExecuteReader();
                    if (d.dr.Read())
                    {
                        prenom.Text = d.dr[2].ToString();
                        nom.Text = d.dr[1].ToString();
                       dateTimePicker1.Text = d.dr[4].ToString();
                        phone.Text = d.dr[6].ToString();
                        email.Text = d.dr[5].ToString();
                        sexe.Text = d.dr[3].ToString();

                    }
                    d.DECONNECTER();
                
                }
          
            
        }

         

        private void btnvider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vouler Vous vider les champ ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtCIN.Text = "";
                prenom.Text = "";
                nom.Text = "";
                phone.Text = "";
                email.Text = "";
                sexe.Text = "";
                dateTimePicker1.Text = "";
            }
        }

        private void btnmdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCIN.Text == "" || prenom.Text == "" || nom.Text == "" || phone.Text == "" || email.Text == "" || sexe.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Remplir tout les champs s'il vous plais ");
                    return;
                }
                if (maj.Modifier(txtCIN.Text, prenom.Text, nom.Text, phone.Text, email.Text, dateTimePicker1.Text, sexe.Text) == true)
                {
                    MessageBox.Show("Le Client Est Modifier avec Succes");

                }
                else
                {
                    MessageBox.Show("Le Client  n'existe pas ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modification non autorisée");
            }
        }
        public void RemplirComboSexe()
        {
            d.CONNECTER();
            sexe.Items.Clear();

            d.cmd.Connection = d.cnx;
            d.cmd.CommandText = "Select distinct Sexe from Clients";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                sexe.Items.Add(d.dr[0]);
            }
            d.DECONNECTER();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
