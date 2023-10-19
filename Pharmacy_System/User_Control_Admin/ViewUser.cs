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
    public partial class ViewUser : UserControl
    {

        Function fn = new Function();
        String query;
        String currentUser = "";

        public ViewUser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM users";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2TextBox1_Search_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM users WHERE username like '" + guna2TextBox1_Search.Text + "%'"; //a%
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        String userName;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch 
            {

                
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != userName)
                {
                    query = "DELETE FROM users WHERE username = '" + guna2TextBox1_Search + "'";
                    fn.SetData(query, "User Records Deleted.");
                    ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are trying to delete \n Your own Profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void guna2CircleButton1_ViewUser_Click(object sender, EventArgs e)
        {
            ViewUser_Load(this, null);
        }
    }
}
