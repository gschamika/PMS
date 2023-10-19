namespace Pharmacy_System.User_Control
{
    partial class Profile_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1_profile = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_name = new System.Windows.Forms.TextBox();
            this.comboBox1_role = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5_password = new System.Windows.Forms.TextBox();
            this.textBox3_email = new System.Windows.Forms.TextBox();
            this.textBox2_mobile = new System.Windows.Forms.TextBox();
            this.dateTimePicker1_dob = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1_profile
            // 
            this.guna2Elipse1_profile.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Profile";
            // 
            // textBox1_name
            // 
            this.textBox1_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_name.Location = new System.Drawing.Point(700, 234);
            this.textBox1_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1_name.Name = "textBox1_name";
            this.textBox1_name.Size = new System.Drawing.Size(382, 34);
            this.textBox1_name.TabIndex = 16;
            // 
            // comboBox1_role
            // 
            this.comboBox1_role.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1_role.FormattingEnabled = true;
            this.comboBox1_role.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist"});
            this.comboBox1_role.Location = new System.Drawing.Point(698, 126);
            this.comboBox1_role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1_role.Name = "comboBox1_role";
            this.comboBox1_role.Size = new System.Drawing.Size(384, 36);
            this.comboBox1_role.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(693, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "User Role";
            // 
            // textBox5_password
            // 
            this.textBox5_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_password.Location = new System.Drawing.Point(701, 675);
            this.textBox5_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5_password.Name = "textBox5_password";
            this.textBox5_password.Size = new System.Drawing.Size(381, 34);
            this.textBox5_password.TabIndex = 26;
            // 
            // textBox3_email
            // 
            this.textBox3_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_email.Location = new System.Drawing.Point(701, 566);
            this.textBox3_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3_email.Name = "textBox3_email";
            this.textBox3_email.Size = new System.Drawing.Size(381, 34);
            this.textBox3_email.TabIndex = 24;
            // 
            // textBox2_mobile
            // 
            this.textBox2_mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2_mobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_mobile.Location = new System.Drawing.Point(701, 458);
            this.textBox2_mobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2_mobile.Name = "textBox2_mobile";
            this.textBox2_mobile.Size = new System.Drawing.Size(381, 34);
            this.textBox2_mobile.TabIndex = 23;
            // 
            // dateTimePicker1_dob
            // 
            this.dateTimePicker1_dob.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1_dob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1_dob.Location = new System.Drawing.Point(700, 342);
            this.dateTimePicker1_dob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1_dob.Name = "dateTimePicker1_dob";
            this.dateTimePicker1_dob.Size = new System.Drawing.Size(381, 34);
            this.dateTimePicker1_dob.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(696, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Mobile Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(695, 634);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(695, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(695, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(750, 851);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "*Check the details before updating.\r\n";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Pharmacy_System.Properties.Resources.undo;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(902, 759);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 63);
            this.guna2Button1.TabIndex = 32;
            this.guna2Button1.Text = "Reset";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::Pharmacy_System.Properties.Resources.updating;
            this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2.Location = new System.Drawing.Point(700, 759);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 63);
            this.guna2Button2.TabIndex = 31;
            this.guna2Button2.Text = "Update";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy_System.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(134, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(134, 712);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(400, 28);
            this.label9.TabIndex = 33;
            this.label9.Text = "User Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Profile_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5_password);
            this.Controls.Add(this.textBox3_email);
            this.Controls.Add(this.textBox2_mobile);
            this.Controls.Add(this.dateTimePicker1_dob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1_name);
            this.Controls.Add(this.comboBox1_role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Profile_UC";
            this.Size = new System.Drawing.Size(1205, 905);
            this.Load += new System.EventHandler(this.Profile_UC_Load);
            this.Enter += new System.EventHandler(this.Profile_UC_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1_profile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_name;
        private System.Windows.Forms.ComboBox comboBox1_role;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5_password;
        private System.Windows.Forms.TextBox textBox3_email;
        private System.Windows.Forms.TextBox textBox2_mobile;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_dob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label9;
    }
}
