using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System
{
    public partial class Login_Form : Form
    {

        Function fn = new Function();
        String query;
        DataSet ds;

        public Login_Form()
        {
            InitializeComponent();
        }

     

        private void guna2Button1_login_Click(object sender, EventArgs e)
        {
            //query for get username and password
            query = "SELECT * FROM users WHERE username = '" + textBox1_name.Text+"' AND password = '"+textBox2_password.Text+"' ";
            ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                String role = ds.Tables[0].Rows[0][1].ToString();
                //check role admin or pharmacist
                if (role == "Admin")
                {
                    //load admin form
                    Admin_Form admin_Form = new Admin_Form(textBox1_name.Text);
                    admin_Form.Show();
                    this.Hide();
                }
                //check role admin or pharmacist
                else if (role == "Pharmacist")
                {
                    //load pharmacist form
                    Pharmacist_Form pharmacist_Form = new Pharmacist_Form();
                    pharmacist_Form.Show();
                    this.Hide();
                }
            }
            else 
            { 
                MessageBox.Show("Username or Password Incorrect!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_clear_Click(object sender, EventArgs e)
        {
            textBox1_name.Clear();
            textBox2_password.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
