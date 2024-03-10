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
    public partial class Employees : Form
    {
        Connexion d = new Connexion();
        AdminClass maj = new AdminClass();

        public Employees()
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
            d.cmd.CommandText = "Select * from Employees ";
            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView1.DataSource = d.dt;
            d.dr.Close();
            d.DECONNECTER();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
            RemplirDataGridView();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            d.CONNECTER();
            if (txtnumber.Text == "")
            {
                MessageBox.Show(" Merci de saisir un Matricule !!");
            }
            if (maj.nombre(Convert.ToInt32(txtnumber.Text)) == 0)
            {
                MessageBox.Show("L'employee n'existe pas !!");
            }
            else
            {
                d.DECONNECTER();
                d.CONNECTER();
                d.cmd.CommandText = "select * from Employees where Matricule ='" + txtnumber.Text + "'";
                d.cmd.Connection = d.cnx;
                d.dr = d.cmd.ExecuteReader();
                if (d.dr.Read())
                {
                    txtmat.Text = d.dr[0].ToString();
                    txtnom.Text = d.dr[1].ToString();
                    txtprenom.Text = d.dr[2].ToString();
                    txttel.Text = d.dr[3].ToString();
                    txtuser.Text = d.dr[4].ToString();
                    txtpass.Text = d.dr[5].ToString();
                }
                d.DECONNECTER();
            }
        }

        private void btnvider_Click(object sender, EventArgs e)
        {
            txtpass.Text = "";
            txttel.Text = "";
            txtmat.Text = "";
            txtnom.Text = "";
            txtprenom.Text = "";
            txtuser.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmat.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtnom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtprenom.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtuser.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtpass.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void ckpass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckpass.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void btnajt_Click(object sender, EventArgs e)
        {
            //try
            //{
                d.CONNECTER();
                maj.nombre(Convert.ToInt32(txtmat.Text));

                if (txtmat.Text == "" || txtnom.Text == "" || txtprenom.Text == "" || txttel.Text == "" || txtuser.Text=="" || txtpass.Text == "")
                {
                    MessageBox.Show("Remplir tout les champs s'il vous plais ");
                    return;
                }
                if (maj.AJOUTTER(Convert.ToInt32(txtmat.Text), txtnom.Text, txtprenom.Text, txttel.Text ,txtuser.Text,txtpass.Text) == true)
                {
                    MessageBox.Show("L'employee Est Ajoutter avec Succes");
                    RemplirDataGridView();
                }
                else
                {
                    MessageBox.Show("L 'employee existe deja ");
                }
                d.DECONNECTER();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Probleme au niveau de Remplissage");
            //}
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmat.Text == "" || txtnom.Text == "" || txtprenom.Text == "" || txttel.Text == "" || txtuser.Text == "" || txtpass.Text == "")
                {
                    MessageBox.Show("Remplir tout les champs s'il vous plais ");
                    return;
                }
                if (maj.Modifier(Convert.ToInt32(txtmat.Text), txtnom.Text, txtprenom.Text, txttel.Text, txtuser.Text, txtpass.Text) == true)
                {
                    MessageBox.Show("L'employee Est Modifier avec Succes");
                    this.Controls.Clear();
                    this.InitializeComponent();
                    RemplirDataGridView();
                    
                }
                else
                {
                    MessageBox.Show("L'employee  n'existe pas ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modification non autorisée");
            }
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            if (txtmat.Text == "")
            {
                MessageBox.Show("Donner  un employee");
                return;
            }
            if (maj.Supprimer(Convert.ToInt32(txtmat.Text)) == true)
            {
                MessageBox.Show("L'employee Est Supprimer avec Succes");
                this.Controls.Clear();
                this.InitializeComponent();
                RemplirDataGridView();
                
            }
            else
            {
                MessageBox.Show("l'employee N'existe Pas");
            }
        }
    }
}
