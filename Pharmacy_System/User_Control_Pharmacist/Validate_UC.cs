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
    public partial class Validate_UC : UserControl
    {

        Function fn = new Function();
        String query;

        public Validate_UC()
        {
            InitializeComponent();
        }

        private void Validate_UC_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1_role.SelectedIndex == 0)
            {
                query = "SELECT * FROM medic WHERE eDate >= getdate()";
                setDataGridView(query, "Valid Medicine", Color.Black);
            }
            else if(comboBox1_role.SelectedIndex == 1)
            {
                query = "SELECT * FROM medic WHERE eDate <= getdate()";
                setDataGridView(query, "Expired Medicine", Color.Red);
            }
            else if(comboBox1_role.SelectedIndex == 2)
            {
                query = "SELECT * FROM medic";
                setDataGridView(query, "", Color.Black);
            }
        }

        private void setDataGridView(String query, String lableName, Color col)
        {
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            label3.Text = lableName;
            label3.ForeColor = col;
        }
    }
}
