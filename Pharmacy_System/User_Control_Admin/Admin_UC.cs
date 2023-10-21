using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System.Administrator_UC
{
    public partial class Admin_UC : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;

        public Admin_UC()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Admin_UC_Load(object sender, EventArgs e)
        {
            query = "SELECT COUNT(role) FROM users WHERE role = 'Admin'";
            ds = fn.GetData(query);
            setLable(ds, label7_num1);

            query = "SELECT COUNT(role) FROM users WHERE role = 'Pharmacist'";
            ds = fn.GetData(query);
            setLable(ds, label8_num2);
        }

        private void setLable(DataSet ds, Label label)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                label.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                label.Text = "0";
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Admin_UC_Load(this, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
