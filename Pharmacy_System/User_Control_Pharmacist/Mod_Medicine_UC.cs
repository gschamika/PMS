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
    public partial class Mod_Medicine_UC : UserControl
    {

        Function fn = new Function();
        String query;

        public Mod_Medicine_UC()
        {
            InitializeComponent();
        }

        private void guna2Button1_signup_Click(object sender, EventArgs e)
        {
             if (textBox1_medID.Text != "")
            {
                query = "SELECT * FROM medic WHERE mid = '" + textBox1_medID.Text + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    textBox1_Mname.Text = ds.Tables[0].Rows[0][2].ToString();
                    textBox3_medNum.Text = ds.Tables[0].Rows[0][3].ToString();
                    dateTimePicker1_ManuDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    dateTimePicker2_ExpDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    textBox4_Qtty.Text = ds.Tables[0].Rows[0][6].ToString();
                    textBox5_Price.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with ID : " + textBox1_medID.Text + " exitst.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }

        private void clearAll()
        {
            textBox1_medID.Clear();
            textBox1_Mname.Clear();
            textBox3_medNum.Clear();
            dateTimePicker1_ManuDate.ResetText();
            dateTimePicker2_ExpDate.ResetText();
            textBox4_Qtty.Clear();
            textBox5_Price.Clear();

            if (guna2TextBox1.Text != "0")
            {
                guna2TextBox1.Text = "0";
            }
            else
            {
                guna2TextBox1.Text = "0"; 
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQuantity;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            String mname = textBox1_Mname.Text;
            String mnumber = textBox3_medNum.Text;
            String mdate = dateTimePicker1_ManuDate.Text;
            String edate = dateTimePicker2_ExpDate.Text;
            Int64 quantity = Int64.Parse(textBox4_Qtty.Text);
            Int64 addQuantity = Int64.Parse(guna2TextBox1.Text);
            Int64 unitprice = Int64.Parse(textBox5_Price.Text);

            totalQuantity = quantity + addQuantity;

            query = "UPDATE medic SET mname = '" + mname + "' , mnumber = '" + mnumber + "' , mDate = '" + mdate + "' , eDate = '" + edate + "' , quantity = '" + totalQuantity + "' , perUnit = '" + unitprice + "' WHERE  mid = '"+textBox1_medID.Text+"'";
            fn.SetData(query, "Medicine Details Updated.");
        }
    }
}
