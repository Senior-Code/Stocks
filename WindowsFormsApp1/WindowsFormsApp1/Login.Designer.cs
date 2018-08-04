namespace WindowsFormsApp1
{
    partial class Login
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
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Passsword = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(73, 32);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(172, 20);
            this.textBoxpassword.TabIndex = 1;
            this.textBoxpassword.Text = "admin123";
            this.textBoxpassword.TextChanged += new System.EventHandler(this.textBoxpassword_TextChanged);
            this.textBoxpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxpassword_KeyDown);
            this.textBoxpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxpassword_KeyPress);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(12, 9);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Passsword
            // 
            this.Passsword.AutoSize = true;
            this.Passsword.Location = new System.Drawing.Point(12, 36);
            this.Passsword.Name = "Passsword";
            this.Passsword.Size = new System.Drawing.Size(53, 13);
            this.Passsword.TabIndex = 1;
            this.Passsword.Text = "Password";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(153, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(73, 84);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(75, 34);
            this.buttonclear.TabIndex = 3;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(170, 84);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(75, 34);
            this.buttonlogin.TabIndex = 4;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // textBoxuser
            // 
            this.textBoxuser.Location = new System.Drawing.Point(73, 6);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(172, 20);
            this.textBoxuser.TabIndex = 0;
            this.textBoxuser.Text = "admin";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 134);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Passsword);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBoxpassword);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Passsword;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textBoxuser;
    }
}