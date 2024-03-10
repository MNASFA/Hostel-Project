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
    public partial class AjoutterClient : Form
    {
        Connexion d = new Connexion();
        ClassMAJ MAJ = new ClassMAJ();

        public AjoutterClient()
        {
            InitializeComponent();
        }

        

        private void AjoutterClient_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void btnajt_Click(object sender, EventArgs e)
        {
            try
            {
                d.CONNECTER();
                MAJ.nombre( txtcin.Text);

                if (txtcin.Text == "" || txtprenom.Text == "" || txtnom.Text == "" || txtphone.Text == "" || txtemail.Text == "" || cmbsexe.Text == "" || dtp.Text == "")
                {
                    MessageBox.Show("Remplir tout les champs s'il vous plais ");
                    return;
                }
                if (MAJ.AJOUTTER(txtcin.Text, txtprenom.Text, txtnom.Text, txtphone.Text, txtemail.Text, dtp.Text, cmbsexe.Text) == true)
                {
                    MessageBox.Show("Le Client Est Ajoutter avec Succes");

                }
                else
                {
                    MessageBox.Show("Le Client existe deja ");
                }
                d.DECONNECTER();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Chi haja machi hiya hadik !!");
            }
           
        }

        private void btnvider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vouler Vous vider les champ ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtcin.Text = "";
                txtprenom.Text = "";
                txtnom.Text = "";
                txtphone.Text = "";
                txtemail.Text = "";
                cmbsexe.Text = "";
                dtp.Text = "";
            }
        }

        private void cmbsexe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

         



        /*private void btnvider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vouler Vous vider les champ ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtcin.Text = "";
                txtprenom.Text = "";
                txtnom.Text = "";
                txtphone.Text = "";
                txtemail.Text = "";
                cmbsexe.Text = "";
                dtp.Text = "";
            }
        }*/
    }
}
