namespace Hostel_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.ckpass = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Loginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtuser = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.Controls.Add(this.ckpass);
            this.LoginPanel.Controls.Add(this.label3);
            this.LoginPanel.Controls.Add(this.Loginbtn);
            this.LoginPanel.Controls.Add(this.txtpassword);
            this.LoginPanel.Controls.Add(this.txtuser);
            this.LoginPanel.Controls.Add(this.gunaCirclePictureBox1);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Location = new System.Drawing.Point(181, 94);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(546, 292);
            this.LoginPanel.TabIndex = 0;
            // 
            // ckpass
            // 
            this.ckpass.AutoSize = true;
            this.ckpass.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckpass.ForeColor = System.Drawing.Color.OrangeRed;
            this.ckpass.Location = new System.Drawing.Point(331, 226);
            this.ckpass.Name = "ckpass";
            this.ckpass.Size = new System.Drawing.Size(122, 18);
            this.ckpass.TabIndex = 152;
            this.ckpass.Text = "Show Password";
            this.ckpass.UseVisualStyleBackColor = true;
            this.ckpass.CheckedChanged += new System.EventHandler(this.ckpass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(220, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "*Good Luck User .*";
            // 
            // Loginbtn
            // 
            this.Loginbtn.BorderRadius = 22;
            this.Loginbtn.CheckedState.Parent = this.Loginbtn;
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.CustomImages.Parent = this.Loginbtn;
            this.Loginbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.Loginbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.HoverState.Parent = this.Loginbtn;
            this.Loginbtn.Location = new System.Drawing.Point(292, 171);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.ShadowDecoration.Parent = this.Loginbtn;
            this.Loginbtn.Size = new System.Drawing.Size(201, 45);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "LOGIN";
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BorderRadius = 18;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.Parent = this.txtpassword;
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FillColor = System.Drawing.Color.DimGray;
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedState.Parent = this.txtpassword;
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.HoverState.Parent = this.txtpassword;
            this.txtpassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtpassword.IconLeft")));
            this.txtpassword.Location = new System.Drawing.Point(272, 129);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtpassword.PlaceholderText = "Password";
            this.txtpassword.SelectedText = "";
            this.txtpassword.ShadowDecoration.Parent = this.txtpassword;
            this.txtpassword.Size = new System.Drawing.Size(232, 36);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.White;
            this.txtuser.BorderRadius = 18;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.DefaultText = "";
            this.txtuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuser.DisabledState.Parent = this.txtuser;
            this.txtuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuser.FillColor = System.Drawing.Color.DimGray;
            this.txtuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuser.FocusedState.Parent = this.txtuser;
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuser.HoverState.Parent = this.txtuser;
            this.txtuser.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtuser.IconLeft")));
            this.txtuser.Location = new System.Drawing.Point(272, 87);
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtuser.PlaceholderText = "";
            this.txtuser.SelectedText = "";
            this.txtuser.ShadowDecoration.Parent = this.txtuser;
            this.txtuser.Size = new System.Drawing.Size(232, 36);
            this.txtuser.TabIndex = 2;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(50, 44);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(199, 200);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 1;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(314, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER LOGIN";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.CheckedState.Parent = this.Exit;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.HoverState.Parent = this.Exit;
            this.Exit.Location = new System.Drawing.Point(818, 12);
            this.Exit.Name = "Exit";
            this.Exit.PressedState.Parent = this.Exit;
            this.Exit.Size = new System.Drawing.Size(40, 40);
            this.Exit.TabIndex = 8;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 484);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtuser;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2Button Loginbtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ImageButton Exit;
        private System.Windows.Forms.CheckBox ckpass;
    }
}

