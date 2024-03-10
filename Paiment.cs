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
    public partial class Paiment : Form
    {
        Connexion d = new Connexion();
        majpaiment maj =new  majpaiment();

        public Paiment()
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
            d.cmd.CommandText = " select  Paiment.*,Clients.Prenom,Clients.Nom,Reservation.DateEntree,Reservation.DateSortie,Reservation.Num_Chambres from Paiment inner join Reservation on Paiment.Id_reservation = Reservation.IdReservation  inner join Clients on Reservation.Cin_Client = Clients.Cin ";


            d.cmd.Connection = d.cnx;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            dataGridView1.DataSource = d.dt;
            d.dr.Close();
            d.DECONNECTER();
        }

        public void Remplircmbres()
        {
            d.CONNECTER();
            string Payees = "No";
            cmbres.Items.Clear();
            d.cmd.Connection = d.cnx;
            d.cmd.CommandText = "Select distinct IdReservation from Reservation where Payees = '"+ Payees +"'";
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                cmbres.Items.Add(d.dr[0]);
            }
            d.DECONNECTER();
        }

        private void Paiment_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();
            Remplircmbres();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            d.CONNECTER();
            if (txtnumber.Text == "")
            {
                MessageBox.Show(" Merci de saisir un Id !!");
            }
            if (maj.nombre(Convert.ToInt32(txtnumber.Text)) == 0)
            {
                MessageBox.Show(" Paiment n'existe pas !!");
            }
            else
            {
                d.DECONNECTER();
                d.CONNECTER();
                d.cmd.CommandText = "select * from Paiment where Id_reservation ='" + txtnumber.Text + "'";
                d.cmd.Connection = d.cnx;
                d.dr = d.cmd.ExecuteReader();
                if (d.dr.Read())
                {
                    txtPaiment.Text = d.dr[0].ToString();
                    cmbtype.Text = d.dr[1].ToString();
                    txtmontant.Text = d.dr[2].ToString();
                    cmbres.Text = d.dr[3].ToString();
                }
                d.DECONNECTER();

            }
        }

        public double montanttotal()
        {
            d.CONNECTER();
            double total;
            d.cmd.CommandText = " select SUM(Prix*(DATEDIFF(DAY,DateEntree ,  DateSortie)))as MontantTotal from Chambres inner join Reservation on Chambres.Numero = Reservation.Num_Chambres where IdReservation ='" + cmbres.Text + "'";
            d.cmd.Connection = d.cnx;
            total = Convert.ToDouble(d.cmd.ExecuteScalar());
            return total;
            d.DECONNECTER();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPaiment.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmbtype.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtmontant.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();      
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {
                d.CONNECTER();
                maj.nombre(Convert.ToInt32(txtPaiment.Text));

                if ( txtPaiment.Text==""|| cmbres.Text == "" || cmbtype.Text == "" )
                {
                    MessageBox.Show("Remplir tout les champs s'il vous plais ");
                    return;
                }
                if (maj.AJOUTTER(Convert.ToInt32(cmbres.Text), Convert.ToInt32(txtPaiment.Text), montanttotal(), cmbtype.Text) == true)
                {
                    MessageBox.Show("Paiment Est Ajoutter avec Succes");
                    this.Controls.Clear();
                    this.InitializeComponent();
                    RemplirDataGridView();
                    Remplircmbres();              
                }
                else
                {
                    MessageBox.Show(" Paiment existe deja ");
                }
                d.DECONNECTER();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probleme au niveau de Remplissage");
            }
        }

       

        private void Vider_Click(object sender, EventArgs e)
        {
            cmbres.Text = "";
            txtmontant.Text = "";
            txtnumber.Text = "";
            txtPaiment.Text = "";
            cmbtype.Text = "";
        }
 

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("\n\n\n " +
                "                                  Bienvenue sur L'AUBERGE \n\n\n", new Font("Georgia", 20, FontStyle.Bold), Brushes.Gray, new Point(10, 10));
            e.Graphics.DrawString(
               "          Bonjour     " + dataGridView1.CurrentRow.Cells[4].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "\n\n" +
               "          Vous avez Reserve la chambre Numero :      " + dataGridView1.CurrentRow.Cells[8].Value.ToString() + " .\n\n " +
               "          Votre Id de Reservation est :            " + cmbres.Text + " .\n\n " +
               "          Date de Entree     :                     " +dataGridView1.CurrentRow.Cells[6].Value.ToString() + " .\n\n " +
               "          Date de Sortie     :                     " + dataGridView1.CurrentRow.Cells[7].Value.ToString() + " . \n\n\n " +
               "______________________________________________________________________________________________________________________________________\n" +
               "______________________________________________________________________________________________________________________________________\n\n\n" +
               "          Vous avez payé la réservation Numero " + cmbres.Text + " .\n\n" +
               "          Id de Paiment   : " +txtPaiment.Text+" .\n\n" +
               "          Type de Paiment : "+cmbtype.Text+" .\n\n" +
               "          Montant Total   : " +  txtmontant.Text + " DH  \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n",

                   new Font("Georgia", 10, FontStyle.Bold),
                   Brushes.Black, new Point(10, 150)
                   );
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtPaiment.Text == "" || cmbres.Text == "" || cmbtype.Text == "")
            {
                MessageBox.Show("Les champs est vide !!");
            }
            else
            {
                PrintDialog printdialog1 = new PrintDialog();
                printdialog1.Document = printDocument1;
                DialogResult result = printdialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }
    }
}
