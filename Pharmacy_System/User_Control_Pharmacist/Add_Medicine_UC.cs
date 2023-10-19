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
    public partial class Add_Medicine_UC : UserControl
    {

        Function fn = new Function();
        String query;

        public Add_Medicine_UC()
        {
            InitializeComponent();
        }

        private void guna2Button1_signup_Click(object sender, EventArgs e)
        {
            if(textBox1_medID.Text != "" && textBox1_Mname.Text != "" && textBox2_Mnum.Text !="" &&textBox2_qtty.Text != "" && textBox3_price.Text != "")
            {
                String mid = textBox1_medID.Text;
                String mname = textBox1_Mname.Text;
                String mnumber = textBox2_Mnum.Text;
                String mdate  = dateTimePicker1_Manu.Text;
                String edate = dateTimePicker1_expire.Text;
                Int64 quantity = Int64.Parse(textBox2_qtty.Text);
                Int64 perunit = Int64.Parse(textBox3_price.Text);

                query = "INSERT INTO medic (mid,mname,mnumber,mDate,eDate,quantity,perUnit) VALUES ('"+mid+"' , '"+mname+ "' , '"+mnumber+ "' , '"+mdate+ "' , '"+edate+ "' , '"+quantity+ "' , '"+perunit+"')";
                fn.SetData(query, "Medicine Added to Database");
            }
            else
            {
                MessageBox.Show("Enter all Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2Button2_clear_Click(object sender, EventArgs e)
        {
            textBox1_medID.Clear();
            textBox1_Mname.Clear();
            textBox2_Mnum.Clear();
            textBox2_qtty.Clear();
            textBox3_price.Clear();
            
        }
    }
}
