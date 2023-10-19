using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System.Add_User
{
    public partial class Add_User : UserControl
    {
        Function fn = new Function();
        String query; 
 
        public Add_User()
        {
            InitializeComponent();
        }

        private void guna2Button1_signup_Click(object sender, EventArgs e)
        {
            String role = comboBox1_role.Text;
            String name = textBox1_name.Text;
            String dob = dateTimePicker1_dob.Text;
            Int64 mobile = Int64.Parse(textBox2_mobile.Text);
            String email = textBox3_email.Text;
            String username = textBox4_username.Text;
            String password = textBox5_password.Text;

            try
            {
                query = "INSERT INTO users(role,name,dob,mobile,email,username,password) values ('"+role+"', '"+name+"', '"+dob+"', '"+mobile+"', '"+email+"', '"+username+"', '"+password+"')";
                fn.SetData(query, "Sign Up Successful");
            }
            catch (Exception)
            {

                MessageBox.Show("Username Allready Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_clear_Click(object sender, EventArgs e)
        {
            textBox1_name.Clear();
            textBox2_mobile.Clear();
            textBox3_email.Clear();
            textBox4_username.Clear();
            textBox5_password.Clear();

        }

        private void textBox4_username_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM users WHERE username = '" + textBox4_username.Text + "'";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"E:\\USJ\\Semester 5\\ITS 3552 Software Engineering II\\Project\\Pharmacy_System\\Pharmacy_System\\Icons\tick.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"E:\\USJ\\Semester 5\\ITS 3552 Software Engineering II\\Project\\Pharmacy_System\\Pharmacy_System\\Icons\cross.png";
            }
        }

        private void comboBox1_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
