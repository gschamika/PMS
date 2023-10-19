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
    public partial class Dasboard_UC : UserControl
    {

        Function fn = new Function();
        String query;
        DataSet ds;
        Int64 count;

        public Dasboard_UC()
        {
            InitializeComponent();
        }

        private void Dasboard_UC_Load(object sender, EventArgs e)
        {
            loadChart();
        }

        public void loadChart()
        {
            query = "SELECT COUNT(mname) FROM medic WHERE eDate >= getdate()";
            ds = fn.GetData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicine"].Points.AddXY("Medicine Validity Chart", count);

            query = "SELECT COUNT(mname) FROM medic WHERE eDate <= getdate()";
            ds = fn.GetData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicine"].Points.AddXY("Medicine Validity Chart", count);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Valid Medicine"].Points.Clear();
            chart1.Series["Expired Medicine"].Points.Clear();
            loadChart();
        }
    }
}
