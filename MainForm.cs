using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vouler Vous Quitter ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
             
        }

        //Main Panel

        public void loadform(object Form)
        {
            if (this.ClientMianpanel.Controls.Count > 0)
            {
                this.ClientMianpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.ClientMianpanel.Controls.Add(f);
            this.ClientMianpanel.Tag = f;
            f.Show();
        }

        //Main panel 2
        public void loadform2(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.TopMost = true;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Clientbtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = true;
            loadform(new Clients());
            if (menuStrip1.Visible == false)
            {
                menuStrip1.Visible = true;
            }
            

        }

        private void chambrebtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = true;
            menuStrip1.Visible = false;
            loadform(new Room());
           
        }

        private void reservebtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = true;
            menuStrip1.Visible = false;
            loadform(new Reservation());
           
        }

        private void adminbtn_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = true;
            menuStrip1.Visible = false;
            loadform(new Employees());
            
        }

        

        private void ajoutterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new AjoutterClient());
        }

        private void moudifierClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new MoudifierClient());
        }

        private void supprimerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new SupprimerClient());
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = true;
            menuStrip1.Visible = false;
            loadform(new Paiment());
        }
    }
}
