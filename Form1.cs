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
    public partial class Form1 : Form
    {

        Connexion d = new Connexion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
            txtuser.PlaceholderText = "Username";
            txtpassword.PlaceholderText = "Password";
        }



        private void Loginbtn_Click(object sender, EventArgs e)
        {
            /* try
             {
                 d.CONNECTER();
                 SqlDataAdapter da = new SqlDataAdapter("Select count(*) from Employees where Username ='" + txtuser.Text + "' and Password ='" + txtpassword.Text + "'", d.cnx);
                 da.Fill(d.dt);
                 if (d.dt.Rows[0][0].ToString() == "1")
                 {
                     MainForm MF = new MainForm();
                     MF.Show();
                     this.Hide();
                 }
                 else
                 {
                     MessageBox.Show("Dkhel dakchi shih");
                 }

             }
             catch
             {
                 MessageBox.Show("Your Username or Password is not valid ");
                 txtuser.Clear();
                 txtpassword.Clear();
                 txtuser.Focus();
             }
             finally
             {
                 d.DECONNECTER();
             }*/

            string User, Password;
            User = txtuser.Text;
            Password = txtpassword.Text;
            try
            {
                d.CONNECTER();
                string query = "select * from Employees where Username='" + txtuser.Text + "' and Password='" + txtpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, d.cnx);
                DataTable dtable = new DataTable();
               sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    MainForm MF = new MainForm();
                    MF.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtuser.Clear();
                txtpassword.Clear();
            }
            finally
            {
                d.DECONNECTER();
            }
        }



    

    private void Exit_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Vouler Vous Quitter ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    

        private void ckpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckpass.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
    }   
   
}

