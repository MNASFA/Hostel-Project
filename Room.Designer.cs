namespace Hostel_Management_System
{
    partial class Room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsuivant = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnvider = new Guna.UI2.WinForms.Guna2Button();
            this.txtcapacite = new System.Windows.Forms.TextBox();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbnum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnprecident = new Guna.UI2.WinForms.Guna2Button();
            this.btndernier = new Guna.UI2.WinForms.Guna2Button();
            this.btnPremier = new Guna.UI2.WinForms.Guna2Button();
            this.btnsearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnsupp = new Guna.UI2.WinForms.Guna2Button();
            this.btnmodif = new Guna.UI2.WinForms.Guna2Button();
            this.btnajt = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 51);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chambres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(361, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 183);
            this.dataGridView1.TabIndex = 91;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnsuivant
            // 
            this.btnsuivant.CheckedState.Parent = this.btnsuivant;
            this.btnsuivant.CustomImages.Parent = this.btnsuivant;
            this.btnsuivant.FillColor = System.Drawing.Color.Transparent;
            this.btnsuivant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsuivant.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnsuivant.HoverState.Parent = this.btnsuivant;
            this.btnsuivant.Image = global::Hostel_Management_System.Properties.Resources.right_arrow;
            this.btnsuivant.Location = new System.Drawing.Point(389, 305);
            this.btnsuivant.Name = "btnsuivant";
            this.btnsuivant.ShadowDecoration.Parent = this.btnsuivant;
            this.btnsuivant.Size = new System.Drawing.Size(79, 28);
            this.btnsuivant.TabIndex = 112;
            this.btnsuivant.Click += new System.EventHandler(this.btnsuivant_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnvider);
            this.groupBox1.Controls.Add(this.txtcapacite);
            this.groupBox1.Controls.Add(this.txtprix);
            this.groupBox1.Controls.Add(this.cmbstatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbnum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 232);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chambre Infos";
            // 
            // btnvider
            // 
            this.btnvider.BackColor = System.Drawing.Color.Transparent;
            this.btnvider.CheckedState.Parent = this.btnvider;
            this.btnvider.CustomImages.Parent = this.btnvider;
            this.btnvider.FillColor = System.Drawing.Color.Transparent;
            this.btnvider.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvider.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnvider.HoverState.Parent = this.btnvider;
            this.btnvider.Image = global::Hostel_Management_System.Properties.Resources.archeology;
            this.btnvider.Location = new System.Drawing.Point(87, 179);
            this.btnvider.Name = "btnvider";
            this.btnvider.ShadowDecoration.Parent = this.btnvider;
            this.btnvider.Size = new System.Drawing.Size(162, 34);
            this.btnvider.TabIndex = 117;
            this.btnvider.Text = "Vider Les Champs";
            this.btnvider.Click += new System.EventHandler(this.btnvider_Click_1);
            // 
            // txtcapacite
            // 
            this.txtcapacite.Location = new System.Drawing.Point(133, 64);
            this.txtcapacite.Name = "txtcapacite";
            this.txtcapacite.Size = new System.Drawing.Size(188, 20);
            this.txtcapacite.TabIndex = 116;
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(133, 104);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(188, 20);
            this.txtprix.TabIndex = 115;
            // 
            // cmbstatus
            // 
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Disponible",
            "Indisponible"});
            this.cmbstatus.Location = new System.Drawing.Point(133, 143);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(188, 21);
            this.cmbstatus.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 14);
            this.label6.TabIndex = 113;
            this.label6.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 112;
            this.label5.Text = "Prix :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 14);
            this.label4.TabIndex = 111;
            this.label4.Text = "Capacité :";
            // 
            // cmbnum
            // 
            this.cmbnum.FormattingEnabled = true;
            this.cmbnum.Location = new System.Drawing.Point(133, 22);
            this.cmbnum.Name = "cmbnum";
            this.cmbnum.Size = new System.Drawing.Size(188, 21);
            this.cmbnum.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 14);
            this.label3.TabIndex = 109;
            this.label3.Text = "Numero de chambre :";
            // 
            // btnprecident
            // 
            this.btnprecident.CheckedState.Parent = this.btnprecident;
            this.btnprecident.CustomImages.Parent = this.btnprecident;
            this.btnprecident.FillColor = System.Drawing.Color.Transparent;
            this.btnprecident.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnprecident.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnprecident.HoverState.Parent = this.btnprecident;
            this.btnprecident.Image = global::Hostel_Management_System.Properties.Resources.right_arrow__1_;
            this.btnprecident.Location = new System.Drawing.Point(237, 305);
            this.btnprecident.Name = "btnprecident";
            this.btnprecident.ShadowDecoration.Parent = this.btnprecident;
            this.btnprecident.Size = new System.Drawing.Size(79, 28);
            this.btnprecident.TabIndex = 111;
            this.btnprecident.Click += new System.EventHandler(this.btnprecident_Click);
            // 
            // btndernier
            // 
            this.btndernier.CheckedState.Parent = this.btndernier;
            this.btndernier.CustomImages.Parent = this.btndernier;
            this.btndernier.FillColor = System.Drawing.Color.Transparent;
            this.btndernier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btndernier.ForeColor = System.Drawing.Color.OrangeRed;
            this.btndernier.HoverState.Parent = this.btndernier;
            this.btndernier.Image = global::Hostel_Management_System.Properties.Resources.right_arrow__2_;
            this.btndernier.Location = new System.Drawing.Point(555, 305);
            this.btndernier.Name = "btndernier";
            this.btndernier.ShadowDecoration.Parent = this.btndernier;
            this.btndernier.Size = new System.Drawing.Size(79, 28);
            this.btndernier.TabIndex = 110;
            this.btndernier.Click += new System.EventHandler(this.btndernier_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.CheckedState.Parent = this.btnPremier;
            this.btnPremier.CustomImages.Parent = this.btnPremier;
            this.btnPremier.FillColor = System.Drawing.Color.Transparent;
            this.btnPremier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPremier.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnPremier.HoverState.Parent = this.btnPremier;
            this.btnPremier.Image = global::Hostel_Management_System.Properties.Resources.right_arrow__3_;
            this.btnPremier.Location = new System.Drawing.Point(81, 305);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.ShadowDecoration.Parent = this.btnPremier;
            this.btnPremier.Size = new System.Drawing.Size(79, 28);
            this.btnPremier.TabIndex = 109;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnsearch.CheckedState.Parent = this.btnsearch;
            this.btnsearch.CustomImages.Parent = this.btnsearch;
            this.btnsearch.FillColor = System.Drawing.Color.OrangeRed;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Black;
            this.btnsearch.HoverState.Parent = this.btnsearch;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(574, 75);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.ShadowDecoration.Parent = this.btnsearch;
            this.btnsearch.Size = new System.Drawing.Size(100, 25);
            this.btnsearch.TabIndex = 107;
            this.btnsearch.Text = "Rechercher";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtnumber
            // 
            this.txtnumber.BorderColor = System.Drawing.Color.Black;
            this.txtnumber.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtnumber.BorderThickness = 0;
            this.txtnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnumber.DefaultText = "";
            this.txtnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumber.DisabledState.Parent = this.txtnumber;
            this.txtnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumber.FocusedState.Parent = this.txtnumber;
            this.txtnumber.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnumber.HoverState.Parent = this.txtnumber;
            this.txtnumber.IconLeft = global::Hostel_Management_System.Properties.Resources.numbers;
            this.txtnumber.Location = new System.Drawing.Point(370, 75);
            this.txtnumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.PasswordChar = '\0';
            this.txtnumber.PlaceholderText = " Saisir numero de chambre";
            this.txtnumber.SelectedText = "";
            this.txtnumber.ShadowDecoration.Parent = this.txtnumber;
            this.txtnumber.Size = new System.Drawing.Size(239, 25);
            this.txtnumber.TabIndex = 106;
            // 
            // btnsupp
            // 
            this.btnsupp.BackColor = System.Drawing.Color.Transparent;
            this.btnsupp.BorderRadius = 10;
            this.btnsupp.CheckedState.Parent = this.btnsupp;
            this.btnsupp.CustomImages.Parent = this.btnsupp;
            this.btnsupp.FillColor = System.Drawing.Color.OrangeRed;
            this.btnsupp.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupp.ForeColor = System.Drawing.Color.White;
            this.btnsupp.HoverState.Parent = this.btnsupp;
            this.btnsupp.Image = global::Hostel_Management_System.Properties.Resources.trash;
            this.btnsupp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsupp.Location = new System.Drawing.Point(495, 353);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.ShadowDecoration.Parent = this.btnsupp;
            this.btnsupp.Size = new System.Drawing.Size(140, 35);
            this.btnsupp.TabIndex = 95;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // btnmodif
            // 
            this.btnmodif.BackColor = System.Drawing.Color.Transparent;
            this.btnmodif.BorderRadius = 10;
            this.btnmodif.CheckedState.Parent = this.btnmodif;
            this.btnmodif.CustomImages.Parent = this.btnmodif;
            this.btnmodif.FillColor = System.Drawing.Color.OrangeRed;
            this.btnmodif.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodif.ForeColor = System.Drawing.Color.White;
            this.btnmodif.HoverState.Parent = this.btnmodif;
            this.btnmodif.Image = global::Hostel_Management_System.Properties.Resources.system_update1;
            this.btnmodif.Location = new System.Drawing.Point(301, 353);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.ShadowDecoration.Parent = this.btnmodif;
            this.btnmodif.Size = new System.Drawing.Size(140, 35);
            this.btnmodif.TabIndex = 94;
            this.btnmodif.Text = "Modifier ";
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // btnajt
            // 
            this.btnajt.BackColor = System.Drawing.Color.Transparent;
            this.btnajt.BorderRadius = 10;
            this.btnajt.CheckedState.Parent = this.btnajt;
            this.btnajt.CustomImages.Parent = this.btnajt;
            this.btnajt.FillColor = System.Drawing.Color.OrangeRed;
            this.btnajt.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajt.ForeColor = System.Drawing.Color.White;
            this.btnajt.HoverState.Parent = this.btnajt;
            this.btnajt.Image = global::Hostel_Management_System.Properties.Resources.add_user;
            this.btnajt.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnajt.Location = new System.Drawing.Point(109, 353);
            this.btnajt.Name = "btnajt";
            this.btnajt.ShadowDecoration.Parent = this.btnajt;
            this.btnajt.Size = new System.Drawing.Size(140, 35);
            this.btnajt.TabIndex = 93;
            this.btnajt.Text = " Ajoutter ";
            this.btnajt.Click += new System.EventHandler(this.btnajt_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(817, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsuivant);
            this.Controls.Add(this.btnprecident);
            this.Controls.Add(this.btndernier);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.btnsupp);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.btnajt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnajt;
        private Guna.UI2.WinForms.Guna2Button btnmodif;
        private Guna.UI2.WinForms.Guna2Button btnsupp;
        private Guna.UI2.WinForms.Guna2Button btnsearch;
        private Guna.UI2.WinForms.Guna2TextBox txtnumber;
        private Guna.UI2.WinForms.Guna2Button btnsuivant;
        private Guna.UI2.WinForms.Guna2Button btnprecident;
        private Guna.UI2.WinForms.Guna2Button btndernier;
        private Guna.UI2.WinForms.Guna2Button btnPremier;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnvider;
        private System.Windows.Forms.TextBox txtcapacite;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbnum;
        private System.Windows.Forms.Label label3;
    }
}