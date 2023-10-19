using Pharmacy_System.Administrator_UC;
using Pharmacy_System.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System
{
    public partial class Admin_Form : Form
    {

        String user = "";

        public Admin_Form()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }

        public Admin_Form(String username)
        {
            InitializeComponent();
            label2_name.Text = username;
            user = username;
            viewUser1.ID = ID;
            profile_UC1.ID = ID;
        }

        private void guna2Button5_logout_Click(object sender, EventArgs e)
        {
            Login_Form loginForm = new Login_Form();
            loginForm.Show();
            this.Hide();
        }

        private void guna2Button1_dashbord_Click(object sender, EventArgs e)
        {
            admin_UC1.Visible = true;
            admin_UC1.BringToFront();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            admin_UC1.Visible = false;
            add_User1.Visible = false;
            viewUser1.Visible = false;
            profile_UC1.Visible = false;
            guna2Button1_dashbord.PerformClick();
        }

        private void guna2Button2_add_user_Click(object sender, EventArgs e)
        {
            add_User1.Visible = true;
            add_User1.BringToFront();
        }

        private void add_User1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_view_user_Click(object sender, EventArgs e)
        {
            viewUser1.Visible = true;
            viewUser1.BringToFront();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            profile_UC1.Visible = true;
            profile_UC1.BringToFront();
        }

        private void profile_UC1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
