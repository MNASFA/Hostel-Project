namespace Hostel_Management_System
{
    partial class AjoutterClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbsexe = new System.Windows.Forms.ComboBox();
            this.btnajt = new Guna.UI2.WinForms.Guna2Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvider = new Guna.UI2.WinForms.Guna2Button();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtphone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtprenom = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajoutter Un Client";
            // 
            // cmbsexe
            // 
            this.cmbsexe.BackColor = System.Drawing.SystemColors.Window;
            this.cmbsexe.FormattingEnabled = true;
            this.cmbsexe.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbsexe.Location = new System.Drawing.Point(322, 272);
            this.cmbsexe.Name = "cmbsexe";
            this.cmbsexe.Size = new System.Drawing.Size(149, 21);
            this.cmbsexe.TabIndex = 36;
            this.cmbsexe.SelectedIndexChanged += new System.EventHandler(this.cmbsexe_SelectedIndexChanged);
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
            this.btnajt.Location = new System.Drawing.Point(151, 322);
            this.btnajt.Name = "btnajt";
            this.btnajt.ShadowDecoration.Parent = this.btnajt;
            this.btnajt.Size = new System.Drawing.Size(180, 45);
            this.btnajt.TabIndex = 30;
            this.btnajt.Text = "Ajoutter";
            this.btnajt.Click += new System.EventHandler(this.btnajt_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(235, 182);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(336, 20);
            this.dtp.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Sexe :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Telephone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Date Naissance :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "CIN :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Prenom :";
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
            this.btnvider.Location = new System.Drawing.Point(360, 322);
            this.btnvider.Name = "btnvider";
            this.btnvider.ShadowDecoration.Parent = this.btnvider;
            this.btnvider.Size = new System.Drawing.Size(180, 45);
            this.btnvider.TabIndex = 37;
            this.btnvider.Text = "Vider";
            this.btnvider.Click += new System.EventHandler(this.btnvider_Click);
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
            this.txtemail.Location = new System.Drawing.Point(235, 240);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.ShadowDecoration.Parent = this.txtemail;
            this.txtemail.Size = new System.Drawing.Size(336, 26);
            this.txtemail.TabIndex = 35;
            // 
            // txtphone
            // 
            this.txtphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtphone.DefaultText = "";
            this.txtphone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtphone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtphone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphone.DisabledState.Parent = this.txtphone;
            this.txtphone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtphone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.FocusedState.Parent = this.txtphone;
            this.txtphone.ForeColor = System.Drawing.Color.Black;
            this.txtphone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtphone.HoverState.Parent = this.txtphone;
            this.txtphone.IconLeft = global::Hostel_Management_System.Properties.Resources.phone_call;
            this.txtphone.Location = new System.Drawing.Point(235, 208);
            this.txtphone.Name = "txtphone";
            this.txtphone.PasswordChar = '\0';
            this.txtphone.PlaceholderText = "";
            this.txtphone.SelectedText = "";
            this.txtphone.ShadowDecoration.Parent = this.txtphone;
            this.txtphone.Size = new System.Drawing.Size(336, 26);
            this.txtphone.TabIndex = 34;
            // 
            // txtcin
            // 
            this.txtcin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcin.DefaultText = "";
            this.txtcin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcin.DisabledState.Parent = this.txtcin;
            this.txtcin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcin.FocusedState.Parent = this.txtcin;
            this.txtcin.ForeColor = System.Drawing.Color.Black;
            this.txtcin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcin.HoverState.Parent = this.txtcin;
            this.txtcin.IconLeft = global::Hostel_Management_System.Properties.Resources.driver_license;
            this.txtcin.Location = new System.Drawing.Point(233, 144);
            this.txtcin.Name = "txtcin";
            this.txtcin.PasswordChar = '\0';
            this.txtcin.PlaceholderText = "";
            this.txtcin.SelectedText = "";
            this.txtcin.ShadowDecoration.Parent = this.txtcin;
            this.txtcin.Size = new System.Drawing.Size(338, 26);
            this.txtcin.TabIndex = 33;
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
            this.txtnom.Location = new System.Drawing.Point(233, 112);
            this.txtnom.Name = "txtnom";
            this.txtnom.PasswordChar = '\0';
            this.txtnom.PlaceholderText = "";
            this.txtnom.SelectedText = "";
            this.txtnom.ShadowDecoration.Parent = this.txtnom;
            this.txtnom.Size = new System.Drawing.Size(338, 26);
            this.txtnom.TabIndex = 32;
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
            this.txtprenom.Location = new System.Drawing.Point(233, 80);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.PasswordChar = '\0';
            this.txtprenom.PlaceholderText = "";
            this.txtprenom.SelectedText = "";
            this.txtprenom.ShadowDecoration.Parent = this.txtprenom;
            this.txtprenom.Size = new System.Drawing.Size(338, 26);
            this.txtprenom.TabIndex = 31;
            // 
            // AjoutterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 393);
            this.Controls.Add(this.btnvider);
            this.Controls.Add(this.cmbsexe);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtcin);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.btnajt);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjoutterClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AjoutterClient";
            this.Load += new System.EventHandler(this.AjoutterClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbsexe;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txtphone;
        private Guna.UI2.WinForms.Guna2TextBox txtcin;
        private Guna.UI2.WinForms.Guna2TextBox txtnom;
        private Guna.UI2.WinForms.Guna2TextBox txtprenom;
        private Guna.UI2.WinForms.Guna2Button btnajt;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnvider;
    }
}