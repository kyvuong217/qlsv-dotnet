namespace QLSinhVien
{
    partial class loginForm
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
            this.logoLogin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnIconClose = new FontAwesome.Sharp.IconButton();
            this.btnIconMinimize = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.logoLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // logoLogin
            // 
            this.logoLogin.Image = global::QLSinhVien.Properties.Resources.logoLogin;
            this.logoLogin.Location = new System.Drawing.Point(85, 29);
            this.logoLogin.Name = "logoLogin";
            this.logoLogin.Size = new System.Drawing.Size(320, 239);
            this.logoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoLogin.TabIndex = 0;
            this.logoLogin.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(82, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(82, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 1);
            this.panel2.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(121, 328);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(280, 20);
            this.txtUser.TabIndex = 4;
            // 
            // txtPasswd
            // 
            this.txtPasswd.BackColor = System.Drawing.SystemColors.Control;
            this.txtPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswd.Location = new System.Drawing.Point(121, 373);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(280, 20);
            this.txtPasswd.TabIndex = 5;
            this.txtPasswd.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Teal;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.Location = new System.Drawing.Point(82, 425);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(320, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Sign in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Teal;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Teal;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(85, 324);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Teal;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Teal;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(85, 369);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 8;
            this.iconPictureBox2.TabStop = false;
            // 
            // linkExit
            // 
            this.linkExit.AutoSize = true;
            this.linkExit.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkExit.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkExit.Location = new System.Drawing.Point(370, 468);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(28, 16);
            this.linkExit.TabIndex = 10;
            this.linkExit.Text = "Exit";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Teal;
            this.labelTitle.Location = new System.Drawing.Point(88, 271);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(234, 29);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Quản Lí Sinh Viên";
            // 
            // btnIconClose
            // 
            this.btnIconClose.FlatAppearance.BorderSize = 0;
            this.btnIconClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnIconClose.IconColor = System.Drawing.Color.Teal;
            this.btnIconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconClose.IconSize = 36;
            this.btnIconClose.Location = new System.Drawing.Point(451, 1);
            this.btnIconClose.Name = "btnIconClose";
            this.btnIconClose.Size = new System.Drawing.Size(28, 23);
            this.btnIconClose.TabIndex = 12;
            this.btnIconClose.UseVisualStyleBackColor = true;
            this.btnIconClose.Click += new System.EventHandler(this.btnIconClose_Click);
            // 
            // btnIconMinimize
            // 
            this.btnIconMinimize.FlatAppearance.BorderSize = 0;
            this.btnIconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnIconMinimize.IconColor = System.Drawing.Color.Teal;
            this.btnIconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIconMinimize.IconSize = 36;
            this.btnIconMinimize.Location = new System.Drawing.Point(422, 1);
            this.btnIconMinimize.Name = "btnIconMinimize";
            this.btnIconMinimize.Size = new System.Drawing.Size(28, 23);
            this.btnIconMinimize.TabIndex = 13;
            this.btnIconMinimize.UseVisualStyleBackColor = true;
            this.btnIconMinimize.Click += new System.EventHandler(this.btnIconMinimize_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 552);
            this.Controls.Add(this.btnIconMinimize);
            this.Controls.Add(this.btnIconClose);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.linkExit);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Button btnLogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.LinkLabel linkExit;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton btnIconClose;
        private FontAwesome.Sharp.IconButton btnIconMinimize;
    }
}