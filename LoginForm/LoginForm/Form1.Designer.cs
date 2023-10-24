namespace LoginForm
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
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.forgotPasswordLbl = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.emailField = new System.Windows.Forms.TextBox();
            this.sendEmailBtn = new System.Windows.Forms.Button();
            this.emailLbl = new System.Windows.Forms.Label();
            this.signinBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.Location = new System.Drawing.Point(98, 61);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(76, 16);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLbl.ForeColor = System.Drawing.Color.White;
            this.passwordLbl.Location = new System.Drawing.Point(99, 96);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(75, 16);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "password";
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(184, 60);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(140, 20);
            this.usernameField.TabIndex = 2;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(184, 95);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(140, 20);
            this.passwordField.TabIndex = 3;
            // 
            // forgotPasswordLbl
            // 
            this.forgotPasswordLbl.AutoSize = true;
            this.forgotPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.forgotPasswordLbl.LinkColor = System.Drawing.Color.Black;
            this.forgotPasswordLbl.Location = new System.Drawing.Point(109, 196);
            this.forgotPasswordLbl.Name = "forgotPasswordLbl";
            this.forgotPasswordLbl.Size = new System.Drawing.Size(189, 16);
            this.forgotPasswordLbl.TabIndex = 4;
            this.forgotPasswordLbl.TabStop = true;
            this.forgotPasswordLbl.Text = "Did you forgot your password?";
            this.forgotPasswordLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLbl_LinkClicked);
            // 
            // loginBtn
            // 
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(97, 145);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(111, 27);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(34, 265);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(232, 20);
            this.emailField.TabIndex = 6;
            this.emailField.Visible = false;
            // 
            // sendEmailBtn
            // 
            this.sendEmailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendEmailBtn.ForeColor = System.Drawing.Color.White;
            this.sendEmailBtn.Location = new System.Drawing.Point(290, 262);
            this.sendEmailBtn.Name = "sendEmailBtn";
            this.sendEmailBtn.Size = new System.Drawing.Size(90, 25);
            this.sendEmailBtn.TabIndex = 7;
            this.sendEmailBtn.Text = "Send";
            this.sendEmailBtn.UseVisualStyleBackColor = true;
            this.sendEmailBtn.Visible = false;
            this.sendEmailBtn.Click += new System.EventHandler(this.sendEmailBtn_Click);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(31, 249);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(85, 13);
            this.emailLbl.TabIndex = 8;
            this.emailLbl.Text = "Enter your e-mail";
            this.emailLbl.Visible = false;
            // 
            // signinBtn
            // 
            this.signinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.signinBtn.ForeColor = System.Drawing.Color.White;
            this.signinBtn.Location = new System.Drawing.Point(214, 145);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(111, 27);
            this.signinBtn.TabIndex = 9;
            this.signinBtn.Text = "Register";
            this.signinBtn.UseVisualStyleBackColor = true;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LoginForm.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(382, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginForm.Properties.Resources.earth;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Accasia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(168, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Home Page";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(415, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.signinBtn);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.sendEmailBtn);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.forgotPasswordLbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.LinkLabel forgotPasswordLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Button sendEmailBtn;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Button signinBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

