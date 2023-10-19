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
    public partial class Sell_UC : UserControl
    {

        Function fn = new Function();
        String query;
        DataSet ds;

        public Sell_UC()
        {
            InitializeComponent();
        }

        private void Sell_UC_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "SELECT mname FROM medic WHERE eDate >= getdate() AND quantity > '0'";
            ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_ViewUser_Click(object sender, EventArgs e)
        {
            Sell_UC_Load(this, null);
        }

        private void textBox1_search_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            query = "SELECT mname FROM medic WHERE mname LIKE '" + textBox1_search.Text + "%' AND eDate >= getdate() AND quantity > '0'";
            ds = fn.GetData(query);

            for (int i=0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5_numOfunits.Clear();

            String name = listBox1.GetItemText(listBox1.SelectedItem);
            textBox3_mName.Text = name;

            query = "SELECT mid, eDate, perUnit FROM medic WHERE mname = '" + name + "'";
            ds = fn.GetData(query);
            textBox2_medID.Text = ds.Tables[0].Rows[0][0].ToString();
            dateTimePicker1_expire.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox4_Price.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void textBox5_numOfunits_TextChanged(object sender, EventArgs e)
        {
            if (textBox5_numOfunits.Text != "")
            {
                Int64 unitPrice = Int64.Parse(textBox4_Price.Text);
                Int64 noOfUnit = Int64.Parse(textBox5_numOfunits.Text);
                Int64 totalAmount = unitPrice * noOfUnit;
                textBox6_TotPrice.Text = totalAmount.ToString();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void guna2Button2_clear_Click(object sender, EventArgs e)
        {
            if (textBox2_medID.Text != "")
            {
                query = "SELECT quantity FROM medic WHERE mid = '" + textBox2_medID.Text + "'";
                ds = fn.GetData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(textBox5_numOfunits.Text);

                if (newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = textBox2_medID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = textBox3_mName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = dateTimePicker1_expire.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = textBox4_Price.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = textBox5_numOfunits.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = textBox6_TotPrice.Text;

                    totalAmount = totalAmount + int.Parse(textBox6_TotPrice.Text);
                    label9_price.Text = "RS. " + totalAmount.ToString();

                    query = "UPDATE medic SET quantity = '" + newQuantity + "' WHERE mid = '" + textBox2_medID.Text + "'";
                    fn.SetData(query, "Medicine Added");
                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock. \n Only " +quantity+ " Left", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                clearAll();
                Sell_UC_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First." , "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int valueAmount;
        String valueId;
        protected Int64 noOfunit;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()); 
            }
            catch (Exception)
            {
                
            }
        }

        private void textBox2_medID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(valueId != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch 
                {

                }
                finally 
                {
                    query = "SELECT quantity FROM medic WHERE mid = '" + valueId + "'";
                    ds = fn.GetData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfunit;

                    query = "UPDATE medic SET quantity = '" + newQuantity + "' WHERE mid = '" + valueId + "'";
                    fn.SetData(query, "Medicine Removed from Cart");
                    totalAmount = totalAmount - valueAmount;
                    label9_price.Text = "Rs. " + totalAmount.ToString();
                }

                Sell_UC_Load(this, null);
            }
        }

        private void clearAll()
        {
            textBox2_medID.Clear();
            textBox3_mName.Clear();
            dateTimePicker1_expire.ResetText();
            textBox4_Price.Clear();
            textBox5_numOfunits.Clear();
        }
    }
}
