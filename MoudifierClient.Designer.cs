namespace Hostel_Management_System
{
    partial class MoudifierClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoudifierClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sexe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnmdf = new Guna.UI2.WinForms.Guna2Button();
            this.btnvider = new Guna.UI2.WinForms.Guna2Button();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.prenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnsearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtCIN = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 51);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modifier Un Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // sexe
            // 
            this.sexe.BackColor = System.Drawing.SystemColors.Window;
            this.sexe.FormattingEnabled = true;
            this.sexe.Location = new System.Drawing.Point(328, 287);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(149, 21);
            this.sexe.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Sexe :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(129, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Telephone :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Date Naissance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Prenom :";
            //this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnmdf
            // 
            this.btnmdf.BackColor = System.Drawing.Color.Transparent;
            this.btnmdf.BorderRadius = 10;
            this.btnmdf.CheckedState.Parent = this.btnmdf;
            this.btnmdf.CustomImages.Parent = this.btnmdf;
            this.btnmdf.FillColor = System.Drawing.Color.OrangeRed;
            this.btnmdf.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmdf.ForeColor = System.Drawing.Color.White;
            this.btnmdf.HoverState.Parent = this.btnmdf;
            this.btnmdf.Location = new System.Drawing.Point(169, 324);
            this.btnmdf.Name = "btnmdf";
            this.btnmdf.ShadowDecoration.Parent = this.btnmdf;
            this.btnmdf.Size = new System.Drawing.Size(180, 45);
            this.btnmdf.TabIndex = 51;
            this.btnmdf.Text = "Modifier";
            this.btnmdf.Click += new System.EventHandler(this.btnmdf_Click);
            // 
            // btnvider
            // 
            this.btnvider.BackColor = System.Drawing.Color.Transparent;
            this.btnvider.BorderRadius = 10;
            this.btnvider.CheckedState.Parent = this.btnvider;
            this.btnvider.CustomImages.Parent = this.btnvider;
            this.btnvider.FillColor = System.Drawing.Color.OrangeRed;
            this.btnvider.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvider.ForeColor = System.Drawing.Color.White;
            this.btnvider.HoverState.Parent = this.btnvider;
            this.btnvider.Location = new System.Drawing.Point(390, 324);
            this.btnvider.Name = "btnvider";
            this.btnvider.ShadowDecoration.Parent = this.btnvider;
            this.btnvider.Size = new System.Drawing.Size(180, 45);
            this.btnvider.TabIndex = 53;
            this.btnvider.Text = "Vider";
            this.btnvider.Click += new System.EventHandler(this.btnvider_Click);
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.Parent = this.email;
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.FocusedState.Parent = this.email;
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.HoverState.Parent = this.email;
            this.email.IconLeft = global::Hostel_Management_System.Properties.Resources.email;
            this.email.Location = new System.Drawing.Point(246, 254);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "";
            this.email.SelectedText = "";
            this.email.ShadowDecoration.Parent = this.email;
            this.email.Size = new System.Drawing.Size(336, 26);
            this.email.TabIndex = 49;
            // 
            // phone
            // 
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.DefaultText = "";
            this.phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone.DisabledState.Parent = this.phone;
            this.phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone.FocusedState.Parent = this.phone;
            this.phone.ForeColor = System.Drawing.Color.Black;
            this.phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone.HoverState.Parent = this.phone;
            this.phone.IconLeft = global::Hostel_Management_System.Properties.Resources.phone_call;
            this.phone.Location = new System.Drawing.Point(246, 222);
            this.phone.Name = "phone";
            this.phone.PasswordChar = '\0';
            this.phone.PlaceholderText = "";
            this.phone.SelectedText = "";
            this.phone.ShadowDecoration.Parent = this.phone;
            this.phone.Size = new System.Drawing.Size(336, 26);
            this.phone.TabIndex = 48;
            // 
            // nom
            // 
            this.nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nom.DefaultText = "";
            this.nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.DisabledState.Parent = this.nom;
            this.nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.FocusedState.Parent = this.nom;
            this.nom.ForeColor = System.Drawing.Color.Black;
            this.nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nom.HoverState.Parent = this.nom;
            this.nom.IconLeft = global::Hostel_Management_System.Properties.Resources.user;
            this.nom.Location = new System.Drawing.Point(244, 153);
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.PlaceholderText = "";
            this.nom.SelectedText = "";
            this.nom.ShadowDecoration.Parent = this.nom;
            this.nom.Size = new System.Drawing.Size(338, 26);
            this.nom.TabIndex = 46;
            // 
            // prenom
            // 
            this.prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prenom.DefaultText = "";
            this.prenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.DisabledState.Parent = this.prenom;
            this.prenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom.FocusedState.Parent = this.prenom;
            this.prenom.ForeColor = System.Drawing.Color.Black;
            this.prenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom.HoverState.Parent = this.prenom;
            this.prenom.IconLeft = global::Hostel_Management_System.Properties.Resources.user;
            this.prenom.Location = new System.Drawing.Point(244, 121);
            this.prenom.Name = "prenom";
            this.prenom.PasswordChar = '\0';
            this.prenom.PlaceholderText = "";
            this.prenom.SelectedText = "";
            this.prenom.ShadowDecoration.Parent = this.prenom;
            this.prenom.Size = new System.Drawing.Size(338, 26);
            this.prenom.TabIndex = 45;
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
            this.btnsearch.Location = new System.Drawing.Point(420, 76);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.ShadowDecoration.Parent = this.btnsearch;
            this.btnsearch.Size = new System.Drawing.Size(106, 25);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Rechercher";
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtCIN
            // 
            this.txtCIN.BorderColor = System.Drawing.Color.Black;
            this.txtCIN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtCIN.BorderThickness = 0;
            this.txtCIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCIN.DefaultText = "";
            this.txtCIN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCIN.DisabledState.Parent = this.txtCIN;
            this.txtCIN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCIN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCIN.FocusedState.Parent = this.txtCIN;
            this.txtCIN.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCIN.HoverState.Parent = this.txtCIN;
            this.txtCIN.IconLeft = global::Hostel_Management_System.Properties.Resources.driver_license;
            this.txtCIN.Location = new System.Drawing.Point(178, 76);
            this.txtCIN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.PasswordChar = '\0';
            this.txtCIN.PlaceholderText = "";
            this.txtCIN.SelectedText = "";
            this.txtCIN.ShadowDecoration.Parent = this.txtCIN;
            this.txtCIN.Size = new System.Drawing.Size(253, 25);
            this.txtCIN.TabIndex = 2;
            this.txtCIN.TextChanged += new System.EventHandler(this.txtCIN_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(336, 20);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // MoudifierClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(782, 399);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnvider);
            this.Controls.Add(this.btnmdf);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtCIN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoudifierClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MoudifierClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCIN;
        private Guna.UI2.WinForms.Guna2Button btnsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sexe;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2TextBox phone;
        private Guna.UI2.WinForms.Guna2TextBox nom;
        private Guna.UI2.WinForms.Guna2TextBox prenom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnmdf;
        private Guna.UI2.WinForms.Guna2Button btnvider;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}