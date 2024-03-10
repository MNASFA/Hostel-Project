namespace Hostel_Management_System
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.InfoGb = new System.Windows.Forms.GroupBox();
            this.cmbpayees = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbidres = new System.Windows.Forms.TextBox();
            this.numchambre = new System.Windows.Forms.ComboBox();
            this.btnvider = new Guna.UI2.WinForms.Guna2Button();
            this.cinclient = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.datesortie = new System.Windows.Forms.DateTimePicker();
            this.dateentree = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsuivant = new Guna.UI2.WinForms.Guna2Button();
            this.btnprecident = new Guna.UI2.WinForms.Guna2Button();
            this.btndernier = new Guna.UI2.WinForms.Guna2Button();
            this.btnPremier = new Guna.UI2.WinForms.Guna2Button();
            this.btnmodif = new Guna.UI2.WinForms.Guna2Button();
            this.btnajt = new Guna.UI2.WinForms.Guna2Button();
            this.btnsearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtidsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.InfoGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 51);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation";
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
            this.dataGridView1.Location = new System.Drawing.Point(22, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 84);
            this.dataGridView1.TabIndex = 108;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // InfoGb
            // 
            this.InfoGb.Controls.Add(this.cmbpayees);
            this.InfoGb.Controls.Add(this.label4);
            this.InfoGb.Controls.Add(this.cmbidres);
            this.InfoGb.Controls.Add(this.numchambre);
            this.InfoGb.Controls.Add(this.btnvider);
            this.InfoGb.Controls.Add(this.cinclient);
            this.InfoGb.Controls.Add(this.label10);
            this.InfoGb.Controls.Add(this.label9);
            this.InfoGb.Controls.Add(this.datesortie);
            this.InfoGb.Controls.Add(this.dateentree);
            this.InfoGb.Controls.Add(this.label8);
            this.InfoGb.Controls.Add(this.label5);
            this.InfoGb.Controls.Add(this.label3);
            this.InfoGb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoGb.Location = new System.Drawing.Point(12, 88);
            this.InfoGb.Name = "InfoGb";
            this.InfoGb.Size = new System.Drawing.Size(684, 141);
            this.InfoGb.TabIndex = 122;
            this.InfoGb.TabStop = false;
            this.InfoGb.Text = "Reservation Infos";
            // 
            // cmbpayees
            // 
            this.cmbpayees.Enabled = false;
            this.cmbpayees.FormattingEnabled = true;
            this.cmbpayees.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbpayees.Location = new System.Drawing.Point(484, 69);
            this.cmbpayees.Name = "cmbpayees";
            this.cmbpayees.Size = new System.Drawing.Size(188, 21);
            this.cmbpayees.TabIndex = 146;
            this.cmbpayees.Text = "No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 145;
            this.label4.Text = "Payees :";
            // 
            // cmbidres
            // 
            this.cmbidres.Enabled = false;
            this.cmbidres.Location = new System.Drawing.Point(126, 21);
            this.cmbidres.Name = "cmbidres";
            this.cmbidres.Size = new System.Drawing.Size(188, 20);
            this.cmbidres.TabIndex = 144;
            // 
            // numchambre
            // 
            this.numchambre.FormattingEnabled = true;
            this.numchambre.Items.AddRange(new object[] {
            "0"});
            this.numchambre.Location = new System.Drawing.Point(484, 45);
            this.numchambre.Name = "numchambre";
            this.numchambre.Size = new System.Drawing.Size(188, 21);
            this.numchambre.TabIndex = 143;
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
            this.btnvider.Location = new System.Drawing.Point(254, 107);
            this.btnvider.Name = "btnvider";
            this.btnvider.ShadowDecoration.Parent = this.btnvider;
            this.btnvider.Size = new System.Drawing.Size(162, 34);
            this.btnvider.TabIndex = 121;
            this.btnvider.Text = "Vider Les Champs";
            this.btnvider.Click += new System.EventHandler(this.btnvider_Click);
            // 
            // cinclient
            // 
            this.cinclient.FormattingEnabled = true;
            this.cinclient.Items.AddRange(new object[] {
            "Disponible",
            "Indisponible"});
            this.cinclient.Location = new System.Drawing.Point(484, 20);
            this.cinclient.Name = "cinclient";
            this.cinclient.Size = new System.Drawing.Size(188, 21);
            this.cinclient.TabIndex = 142;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(364, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 14);
            this.label10.TabIndex = 141;
            this.label10.Text = "Numero de chambre :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(365, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 14);
            this.label9.TabIndex = 140;
            this.label9.Text = "Cin Client :";
            // 
            // datesortie
            // 
            this.datesortie.Location = new System.Drawing.Point(126, 73);
            this.datesortie.Name = "datesortie";
            this.datesortie.Size = new System.Drawing.Size(188, 20);
            this.datesortie.TabIndex = 139;
            // 
            // dateentree
            // 
            this.dateentree.Location = new System.Drawing.Point(127, 47);
            this.dateentree.Name = "dateentree";
            this.dateentree.Size = new System.Drawing.Size(188, 20);
            this.dateentree.TabIndex = 138;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 14);
            this.label8.TabIndex = 136;
            this.label8.Text = "Date Sortie :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 133;
            this.label5.Text = "Date Entree :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 14);
            this.label3.TabIndex = 130;
            this.label3.Text = "Id Reservation :";
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
            this.btnsuivant.Location = new System.Drawing.Point(408, 325);
            this.btnsuivant.Name = "btnsuivant";
            this.btnsuivant.ShadowDecoration.Parent = this.btnsuivant;
            this.btnsuivant.Size = new System.Drawing.Size(60, 20);
            this.btnsuivant.TabIndex = 129;
            this.btnsuivant.Click += new System.EventHandler(this.btnsuivant_Click);
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
            this.btnprecident.Location = new System.Drawing.Point(256, 325);
            this.btnprecident.Name = "btnprecident";
            this.btnprecident.ShadowDecoration.Parent = this.btnprecident;
            this.btnprecident.Size = new System.Drawing.Size(60, 20);
            this.btnprecident.TabIndex = 128;
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
            this.btndernier.Location = new System.Drawing.Point(574, 325);
            this.btndernier.Name = "btndernier";
            this.btndernier.ShadowDecoration.Parent = this.btndernier;
            this.btndernier.Size = new System.Drawing.Size(60, 20);
            this.btndernier.TabIndex = 127;
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
            this.btnPremier.Location = new System.Drawing.Point(100, 325);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.ShadowDecoration.Parent = this.btnPremier;
            this.btnPremier.Size = new System.Drawing.Size(60, 20);
            this.btnPremier.TabIndex = 126;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
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
            this.btnmodif.Location = new System.Drawing.Point(368, 351);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.ShadowDecoration.Parent = this.btnmodif;
            this.btnmodif.Size = new System.Drawing.Size(239, 35);
            this.btnmodif.TabIndex = 124;
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
            this.btnajt.Location = new System.Drawing.Point(100, 351);
            this.btnajt.Name = "btnajt";
            this.btnajt.ShadowDecoration.Parent = this.btnajt;
            this.btnajt.Size = new System.Drawing.Size(239, 35);
            this.btnajt.TabIndex = 123;
            this.btnajt.Text = " Ajoutter ";
            this.btnajt.Click += new System.EventHandler(this.btnajt_Click);
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
            this.btnsearch.Location = new System.Drawing.Point(392, 57);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.ShadowDecoration.Parent = this.btnsearch;
            this.btnsearch.Size = new System.Drawing.Size(93, 25);
            this.btnsearch.TabIndex = 111;
            this.btnsearch.Text = "Rechercher";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtidsearch
            // 
            this.txtidsearch.BorderColor = System.Drawing.Color.Black;
            this.txtidsearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtidsearch.BorderThickness = 0;
            this.txtidsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidsearch.DefaultText = "";
            this.txtidsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidsearch.DisabledState.Parent = this.txtidsearch;
            this.txtidsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidsearch.FocusedState.Parent = this.txtidsearch;
            this.txtidsearch.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidsearch.HoverState.Parent = this.txtidsearch;
            this.txtidsearch.IconLeft = global::Hostel_Management_System.Properties.Resources.numbers;
            this.txtidsearch.Location = new System.Drawing.Point(207, 57);
            this.txtidsearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtidsearch.Name = "txtidsearch";
            this.txtidsearch.PasswordChar = '\0';
            this.txtidsearch.PlaceholderText = " Saisir id de reservation";
            this.txtidsearch.SelectedText = "";
            this.txtidsearch.ShadowDecoration.Parent = this.txtidsearch;
            this.txtidsearch.Size = new System.Drawing.Size(234, 25);
            this.txtidsearch.TabIndex = 110;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(763, 405);
            this.Controls.Add(this.btnsuivant);
            this.Controls.Add(this.btnprecident);
            this.Controls.Add(this.btndernier);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.btnajt);
            this.Controls.Add(this.InfoGb);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtidsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.InfoGb.ResumeLayout(false);
            this.InfoGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnsearch;
        private Guna.UI2.WinForms.Guna2TextBox txtidsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnvider;
        private System.Windows.Forms.GroupBox InfoGb;
        private System.Windows.Forms.ComboBox numchambre;
        private System.Windows.Forms.ComboBox cinclient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datesortie;
        private System.Windows.Forms.DateTimePicker dateentree;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnmodif;
        private Guna.UI2.WinForms.Guna2Button btnajt;
        private Guna.UI2.WinForms.Guna2Button btnsuivant;
        private Guna.UI2.WinForms.Guna2Button btnprecident;
        private Guna.UI2.WinForms.Guna2Button btndernier;
        private Guna.UI2.WinForms.Guna2Button btnPremier;
        private System.Windows.Forms.TextBox cmbidres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbpayees;
    }
}