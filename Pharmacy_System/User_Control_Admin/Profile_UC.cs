using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System.User_Control
{
    public partial class Profile_UC : UserControl
    {
        Function fn = new Function();
        String query;

        public Profile_UC()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { label9.Text = value; }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String role = comboBox1_role.Text;
            String name = textBox1_name.Text;
            String dob = dateTimePicker1_dob.Text;
            Int64 mobile = Int64.Parse(textBox2_mobile.Text);
            String email = textBox3_email.Text;
            String username = label9.Text;
            String password = textBox5_password.Text;

            query = "UPDATE users SET role = '" + role + "' ,name = '" + name + "' ,dob = '" + dob + "' ,mobile = '" + mobile + "' ,email = '" + email + "' ,password = '" + password + "' WHERE username = '" + username + "'";
            fn.SetData(query, "Profile Updated Successful");

        }

        private void Profile_UC_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM users WHERE username = '" + label9.Text + "'";
            DataSet ds = fn.GetData(query);
            comboBox1_role.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox1_name.Text = ds.Tables[0].Rows[0][2].ToString();
            dateTimePicker1_dob.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox2_mobile.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox3_email.Text = ds.Tables[0].Rows[0][5].ToString();
            textBox5_password.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void Profile_UC_Enter(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Profile_UC_Load(this, null);
        }
    }
}
