namespace Pharmacy_System
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.textBox1_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1_login = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2_clear = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // textBox2_password
            // 
            this.textBox2_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2_password.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_password.Location = new System.Drawing.Point(348, 185);
            this.textBox2_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.PasswordChar = '*';
            this.textBox2_password.Size = new System.Drawing.Size(365, 38);
            this.textBox2_password.TabIndex = 9;
            // 
            // textBox1_name
            // 
            this.textBox1_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_name.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_name.Location = new System.Drawing.Point(348, 110);
            this.textBox1_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1_name.Name = "textBox1_name";
            this.textBox1_name.Size = new System.Drawing.Size(365, 38);
            this.textBox1_name.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name";
            // 
            // guna2Button1_login
            // 
            this.guna2Button1_login.BorderRadius = 15;
            this.guna2Button1_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1_login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1_login.ForeColor = System.Drawing.Color.White;
            this.guna2Button1_login.Location = new System.Drawing.Point(211, 306);
            this.guna2Button1_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1_login.Name = "guna2Button1_login";
            this.guna2Button1_login.Size = new System.Drawing.Size(180, 63);
            this.guna2Button1_login.TabIndex = 10;
            this.guna2Button1_login.Text = "Login";
            this.guna2Button1_login.Click += new System.EventHandler(this.guna2Button1_login_Click);
            // 
            // guna2Button2_clear
            // 
            this.guna2Button2_clear.BorderRadius = 15;
            this.guna2Button2_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2_clear.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2_clear.ForeColor = System.Drawing.Color.White;
            this.guna2Button2_clear.Location = new System.Drawing.Point(489, 306);
            this.guna2Button2_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2_clear.Name = "guna2Button2_clear";
            this.guna2Button2_clear.Size = new System.Drawing.Size(180, 63);
            this.guna2Button2_clear.TabIndex = 11;
            this.guna2Button2_clear.Text = "Clear";
            this.guna2Button2_clear.Click += new System.EventHandler(this.guna2Button2_clear_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 484);
            this.Controls.Add(this.guna2Button2_clear);
            this.Controls.Add(this.guna2Button1_login);
            this.Controls.Add(this.textBox2_password);
            this.Controls.Add(this.textBox1_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.TextBox textBox1_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1_login;
        private Guna.UI2.WinForms.Guna2Button guna2Button2_clear;
    }
}