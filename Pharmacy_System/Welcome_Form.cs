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
    public partial class Welcome_Form : Form
    {
        public Welcome_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_Form Login_Form = new Login_Form();
            Login_Form.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Login_Form Login_Form = new Login_Form();
            Login_Form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
