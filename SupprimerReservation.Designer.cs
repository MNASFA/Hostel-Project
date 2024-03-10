namespace Hostel_Management_System
{
    partial class SupprimerReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupprimerReservation));
            this.btnsearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtidsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.numchambre = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnmodif = new Guna.UI2.WinForms.Guna2Button();
            this.cmbidres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnsearch.Location = new System.Drawing.Point(435, 46);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.ShadowDecoration.Parent = this.btnsearch;
            this.btnsearch.Size = new System.Drawing.Size(93, 25);
            this.btnsearch.TabIndex = 113;
            this.btnsearch.Text = "Rechercher";
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
            this.txtidsearch.Location = new System.Drawing.Point(250, 46);
            this.txtidsearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtidsearch.Name = "txtidsearch";
            this.txtidsearch.PasswordChar = '\0';
            this.txtidsearch.PlaceholderText = " Saisir id de reservation";
            this.txtidsearch.SelectedText = "";
            this.txtidsearch.ShadowDecoration.Parent = this.txtidsearch;
            this.txtidsearch.Size = new System.Drawing.Size(234, 25);
            this.txtidsearch.TabIndex = 112;
            // 
            // numchambre
            // 
            this.numchambre.FormattingEnabled = true;
            this.numchambre.Location = new System.Drawing.Point(317, 143);
            this.numchambre.Name = "numchambre";
            this.numchambre.Size = new System.Drawing.Size(333, 21);
            this.numchambre.TabIndex = 145;
            this.numchambre.SelectedIndexChanged += new System.EventHandler(this.numchambre_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 25);
            this.label10.TabIndex = 144;
            this.label10.Text = "Numero de chambre :";
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
            this.btnmodif.Image = global::Hostel_Management_System.Properties.Resources.trash;
            this.btnmodif.Location = new System.Drawing.Point(183, 226);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.ShadowDecoration.Parent = this.btnmodif;
            this.btnmodif.Size = new System.Drawing.Size(420, 35);
            this.btnmodif.TabIndex = 146;
            this.btnmodif.Text = "Supprimer la Reservation";
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // cmbidres
            // 
            this.cmbidres.Location = new System.Drawing.Point(317, 99);
            this.cmbidres.Name = "cmbidres";
            this.cmbidres.Size = new System.Drawing.Size(333, 20);
            this.cmbidres.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 14);
            this.label3.TabIndex = 147;
            this.label3.Text = "ID :";
            // 
            // SupprimerReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 354);
            this.Controls.Add(this.cmbidres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnmodif);
            this.Controls.Add(this.numchambre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtidsearch);
            this.Name = "SupprimerReservation";
            this.Text = "SupprimerReservation";
            this.Load += new System.EventHandler(this.SupprimerReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnsearch;
        private Guna.UI2.WinForms.Guna2TextBox txtidsearch;
        private System.Windows.Forms.ComboBox numchambre;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnmodif;
        private System.Windows.Forms.TextBox cmbidres;
        private System.Windows.Forms.Label label3;
    }
}