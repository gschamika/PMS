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
    public partial class Pharmacist_Form : Form
    {
        public Pharmacist_Form()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login_Form loginForm = new Login_Form();
            loginForm.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            dasboard_UC1.Visible = true;
            dasboard_UC1.BringToFront();
        }

        private void Pharmacist_Form_Load(object sender, EventArgs e)
        {
            dasboard_UC1.Visible=false;
            add_Medicine_UC1.Visible = false;
            view_Medicine_UC1.Visible = false;
            mod_Medicine_UC1.Visible = false;
            validate_UC1.Visible = false;
            sell_UC1.Visible = false;
            guna2Button6.PerformClick();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            add_Medicine_UC1.Visible = true;
            add_Medicine_UC1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            view_Medicine_UC1.Visible = true;
            view_Medicine_UC1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            mod_Medicine_UC1.Visible = true;
            mod_Medicine_UC1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            validate_UC1.Visible = true;
            validate_UC1.BringToFront();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            sell_UC1.Visible = true;
            sell_UC1.BringToFront();
        }
    }
}
