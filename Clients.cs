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
    public partial class Clients : Form
    {
        Connexion d = new Connexion();

        public Clients()
        {
            InitializeComponent();
        }

        public void RemplirDataGridView()
        {
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

        

        private void Clients_Load(object sender, EventArgs e)
        {
            d.CONNECTER();
            RemplirDataGridView();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
