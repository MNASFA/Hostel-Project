namespace Hostel_Management_System
{
    partial class SupprimerClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Cincmb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPremier = new Guna.UI2.WinForms.Guna2Button();
            this.btndernier = new Guna.UI2.WinForms.Guna2Button();
            this.btnprecident = new Guna.UI2.WinForms.Guna2Button();
            this.btnsuivant = new Guna.UI2.WinForms.Guna2Button();
            this.btnsupp = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsexe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtprenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 51);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supprimer Un Client";
            // 
            // Cincmb
            // 
            this.Cincmb.BackColor = System.Drawing.Color.Transparent;
            this.Cincmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cincmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cincmb.FocusedColor = System.Drawing.Color.Empty;
            this.Cincmb.FocusedState.Parent = this.Cincmb;
            this.Cincmb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cincmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Cincmb.FormattingEnabled = true;
            this.Cincmb.HoverState.Parent = this.Cincmb;
            this.Cincmb.ItemHeight = 30;
            this.Cincmb.ItemsAppearance.Parent = this.Cincmb;
            this.Cincmb.Location = new System.Drawing.Point(182, 56);
            this.Cincmb.Name = "Cincmb";
            this.Cincmb.ShadowDecoration.Parent = this.Cincmb;
            this.Cincmb.Size = new System.Drawing.Size(151, 36);
            this.Cincmb.TabIndex = 69;
            this.Cincmb.SelectedIndexChanged += new System.EventHandler(this.Cincmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "CIN :";
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
            this.btnPremier.Location = new System.Drawing.Point(57, 304);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.ShadowDecoration.Parent = this.btnPremier;
            this.btnPremier.Size = new System.Drawing.Size(79, 28);
            this.btnPremier.TabIndex = 71;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
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
            this.btndernier.Location = new System.Drawing.Point(531, 304);
            this.btndernier.Name = "btndernier";
            this.btndernier.ShadowDecoration.Parent = this.btndernier;
            this.btndernier.Size = new System.Drawing.Size(79, 28);
            this.btndernier.TabIndex = 72;
            this.btndernier.Click += new System.EventHandler(this.btndernier_Click);
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
            this.btnprecident.Location = new System.Drawing.Point(213, 304);
            this.btnprecident.Name = "btnprecident";
            this.btnprecident.ShadowDecoration.Parent = this.btnprecident;
            this.btnprecident.Size = new System.Drawing.Size(79, 28);
            this.btnprecident.TabIndex = 73;
            this.btnprecident.Click += new System.EventHandler(this.btnprecident_Click);
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
            this.btnsuivant.Location = new System.Drawing.Point(365, 304);
            this.btnsuivant.Name = "btnsuivant";
            this.btnsuivant.ShadowDecoration.Parent = this.btnsuivant;
            this.btnsuivant.Size = new System.Drawing.Size(79, 28);
            this.btnsuivant.TabIndex = 74;
            this.btnsuivant.Click += new System.EventHandler(this.btnsuivant_Click);
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
            this.btnsupp.Location = new System.Drawing.Point(240, 348);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.ShadowDecoration.Parent = this.btnsupp;
            this.btnsupp.Size = new System.Drawing.Size(180, 45);
            this.btnsupp.TabIndex = 66;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 81;
            this.label8.Text = "Sexe :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 80;
            this.label7.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 79;
            this.label6.Text = "Telephone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 78;
            this.label5.Text = "Date Naissance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 77;
            this.label3.Text = "Nom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(47, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 76;
            this.label9.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightGray;
            this.label10.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(471, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 89;
            this.label10.Text = "Les Clients :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(384, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 159);
            this.dataGridView1.TabIndex = 90;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtsexe
            // 
            this.txtsexe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsexe.DefaultText = "";
            this.txtsexe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsexe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsexe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsexe.DisabledState.Parent = this.txtsexe;
            this.txtsexe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsexe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsexe.FocusedState.Parent = this.txtsexe;
            this.txtsexe.ForeColor = System.Drawing.Color.Black;
            this.txtsexe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsexe.HoverState.Parent = this.txtsexe;
            this.txtsexe.IconLeft = global::Hostel_Management_System.Properties.Resources.gender;
            this.txtsexe.Location = new System.Drawing.Point(166, 262);
            this.txtsexe.Name = "txtsexe";
            this.txtsexe.PasswordChar = '\0';
            this.txtsexe.PlaceholderText = "";
            this.txtsexe.ReadOnly = true;
            this.txtsexe.SelectedText = "";
            this.txtsexe.ShadowDecoration.Parent = this.txtsexe;
            this.txtsexe.Size = new System.Drawing.Size(188, 26);
            this.txtsexe.TabIndex = 87;
            // 
            // txtdate
            // 
            this.txtdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdate.DefaultText = "";
            this.txtdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdate.DisabledState.Parent = this.txtdate;
            this.txtdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdate.FocusedState.Parent = this.txtdate;
            this.txtdate.ForeColor = System.Drawing.Color.Black;
            this.txtdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdate.HoverState.Parent = this.txtdate;
            this.txtdate.IconLeft = global::Hostel_Management_System.Properties.Resources.calendar;
            this.txtdate.Location = new System.Drawing.Point(164, 166);
            this.txtdate.Name = "txtdate";
            this.txtdate.PasswordChar = '\0';
            this.txtdate.PlaceholderText = "";
            this.txtdate.ReadOnly = true;
            this.txtdate.SelectedText = "";
            this.txtdate.ShadowDecoration.Parent = this.txtdate;
            this.txtdate.Size = new System.Drawing.Size(188, 26);
            this.txtdate.TabIndex = 86;
            // 
            // txtemail
            // 
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.Parent = this.txtemail;
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.FocusedState.Parent = this.txtemail;
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.HoverState.Parent = this.txtemail;
            this.txtemail.IconLeft = global::Hostel_Management_System.Properties.Resources.email;
            this.txtemail.Location = new System.Drawing.Point(166, 230);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "";
            this.txtemail.ReadOnly = true;
            this.txtemail.SelectedText = "";
            this.txtemail.ShadowDecoration.Parent = this.txtemail;
            this.txtemail.Size = new System.Drawing.Size(186, 26);
            this.txtemail.TabIndex = 85;
            // 
            // txttel
            // 
            this.txttel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttel.DefaultText = "";
            this.txttel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttel.DisabledState.Parent = this.txttel;
            this.txttel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttel.FocusedState.Parent = this.txttel;
            this.txttel.ForeColor = System.Drawing.Color.Black;
            this.txttel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttel.HoverState.Parent = this.txttel;
            this.txttel.IconLeft = global::Hostel_Management_System.Properties.Resources.phone_call;
            this.txttel.Location = new System.Drawing.Point(166, 198);
            this.txttel.Name = "txttel";
            this.txttel.PasswordChar = '\0';
            this.txttel.PlaceholderText = "";
            this.txttel.ReadOnly = true;
            this.txttel.SelectedText = "";
            this.txttel.ShadowDecoration.Parent = this.txttel;
            this.txttel.Size = new System.Drawing.Size(186, 26);
            this.txttel.TabIndex = 84;
            // 
            // txtnom
            // 
            this.txtnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnom.DefaultText = "";
            this.txtnom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnom.DisabledState.Parent = this.txtnom;
            this.txtnom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnom.FocusedState.Parent = this.txtnom;
            this.txtnom.ForeColor = System.Drawing.Color.Black;
            this.txtnom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnom.HoverState.Parent = this.txtnom;
            this.txtnom.IconLeft = global::Hostel_Management_System.Properties.Resources.user;
            this.txtnom.Location = new System.Drawing.Point(164, 129);
            this.txtnom.Name = "txtnom";
            this.txtnom.PasswordChar = '\0';
            this.txtnom.PlaceholderText = "";
            this.txtnom.ReadOnly = true;
            this.txtnom.SelectedText = "";
            this.txtnom.ShadowDecoration.Parent = this.txtnom;
            this.txtnom.Size = new System.Drawing.Size(188, 26);
            this.txtnom.TabIndex = 83;
            // 
            // txtprenom
            // 
            this.txtprenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprenom.DefaultText = "";
            this.txtprenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprenom.DisabledState.Parent = this.txtprenom;
            this.txtprenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprenom.FocusedState.Parent = this.txtprenom;
            this.txtprenom.ForeColor = System.Drawing.Color.Black;
            this.txtprenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprenom.HoverState.Parent = this.txtprenom;
            this.txtprenom.IconLeft = global::Hostel_Management_System.Properties.Resources.user;
            this.txtprenom.Location = new System.Drawing.Point(164, 97);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.PasswordChar = '\0';
            this.txtprenom.PlaceholderText = "";
            this.txtprenom.ReadOnly = true;
            this.txtprenom.SelectedText = "";
            this.txtprenom.ShadowDecoration.Parent = this.txtprenom;
            this.txtprenom.Size = new System.Drawing.Size(188, 26);
            this.txtprenom.TabIndex = 82;
            // 
            // SupprimerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 405);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtsexe);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsuivant);
            this.Controls.Add(this.btnprecident);
            this.Controls.Add(this.btndernier);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cincmb);
            this.Controls.Add(this.btnsupp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupprimerClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupprimerClient";
            this.Load += new System.EventHandler(this.SupprimerClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox Cincmb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnPremier;
        private Guna.UI2.WinForms.Guna2Button btndernier;
        private Guna.UI2.WinForms.Guna2Button btnprecident;
        private Guna.UI2.WinForms.Guna2Button btnsuivant;
        private Guna.UI2.WinForms.Guna2Button btnsupp;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txttel;
        private Guna.UI2.WinForms.Guna2TextBox txtnom;
        private Guna.UI2.WinForms.Guna2TextBox txtprenom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtdate;
        private Guna.UI2.WinForms.Guna2TextBox txtsexe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}