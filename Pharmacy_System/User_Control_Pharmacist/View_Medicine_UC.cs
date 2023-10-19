using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_System.User_Control_Pharmacist
{
    public partial class View_Medicine_UC : UserControl
    {
        Function fn = new Function();
        String query;

        public View_Medicine_UC()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Medicine_UC_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM medic";
            setDataGridView(query);
        }

        private void guna2TextBox1_Search_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM medic WHERE mname LIKE '" + guna2TextBox1_Search.Text + "%'";
            setDataGridView(query);
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        String medicineId;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch 
            {

                
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM medic WHERE mid = '" + medicineId + "'";
                fn.SetData(query, "Medicine Record Deleted.");
                View_Medicine_UC_Load(this, null);
            }
        }

        private void guna2CircleButton1_ViewUser_Click(object sender, EventArgs e)
        {
            View_Medicine_UC_Load(this, null);
        }
    }
}
