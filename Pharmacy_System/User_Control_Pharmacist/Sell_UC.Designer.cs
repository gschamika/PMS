namespace Pharmacy_System.User_Control_Pharmacist
{
    partial class Sell_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1_expire = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2_medID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3_mName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5_numOfunits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1_search = new System.Windows.Forms.TextBox();
            this.guna2CircleButton1_ViewUser = new Guna.UI2.WinForms.Guna2CircleButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox6_TotPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label9_price = new System.Windows.Forms.Label();
            this.guna2Elipse1_sell = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button2_clear = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1_expire
            // 
            this.dateTimePicker1_expire.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1_expire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1_expire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1_expire.Location = new System.Drawing.Point(386, 426);
            this.dateTimePicker1_expire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1_expire.Name = "dateTimePicker1_expire";
            this.dateTimePicker1_expire.Size = new System.Drawing.Size(323, 34);
            this.dateTimePicker1_expire.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 28);
            this.label6.TabIndex = 34;
            this.label6.Text = "Expire Date";
            // 
            // textBox2_medID
            // 
            this.textBox2_medID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2_medID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_medID.Location = new System.Drawing.Point(385, 222);
            this.textBox2_medID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2_medID.Name = "textBox2_medID";
            this.textBox2_medID.ReadOnly = true;
            this.textBox2_medID.Size = new System.Drawing.Size(324, 34);
            this.textBox2_medID.TabIndex = 33;
            this.textBox2_medID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2_medID.TextChanged += new System.EventHandler(this.textBox2_medID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "Medicine ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sell Medicine";
            // 
            // textBox3_mName
            // 
            this.textBox3_mName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3_mName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_mName.Location = new System.Drawing.Point(385, 324);
            this.textBox3_mName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3_mName.Name = "textBox3_mName";
            this.textBox3_mName.ReadOnly = true;
            this.textBox3_mName.Size = new System.Drawing.Size(324, 34);
            this.textBox3_mName.TabIndex = 39;
            this.textBox3_mName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3_mName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "Medicine Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox5_numOfunits
            // 
            this.textBox5_numOfunits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5_numOfunits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5_numOfunits.Location = new System.Drawing.Point(814, 324);
            this.textBox5_numOfunits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5_numOfunits.Name = "textBox5_numOfunits";
            this.textBox5_numOfunits.Size = new System.Drawing.Size(323, 34);
            this.textBox5_numOfunits.TabIndex = 41;
            this.textBox5_numOfunits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5_numOfunits.TextChanged += new System.EventHandler(this.textBox5_numOfunits_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(809, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Number of Units";
            // 
            // textBox4_Price
            // 
            this.textBox4_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4_Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_Price.Location = new System.Drawing.Point(814, 222);
            this.textBox4_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4_Price.Name = "textBox4_Price";
            this.textBox4_Price.ReadOnly = true;
            this.textBox4_Price.Size = new System.Drawing.Size(324, 34);
            this.textBox4_Price.TabIndex = 43;
            this.textBox4_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(810, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "Price Per Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 28);
            this.label7.TabIndex = 44;
            this.label7.Text = "Search";
            // 
            // textBox1_search
            // 
            this.textBox1_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_search.Location = new System.Drawing.Point(29, 222);
            this.textBox1_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1_search.Name = "textBox1_search";
            this.textBox1_search.Size = new System.Drawing.Size(292, 34);
            this.textBox1_search.TabIndex = 46;
            this.textBox1_search.TextChanged += new System.EventHandler(this.textBox1_search_TextChanged);
            // 
            // guna2CircleButton1_ViewUser
            // 
            this.guna2CircleButton1_ViewUser.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1_ViewUser.BorderColor = System.Drawing.Color.White;
            this.guna2CircleButton1_ViewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton1_ViewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1_ViewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1_ViewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1_ViewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1_ViewUser.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1_ViewUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1_ViewUser.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1_ViewUser.Location = new System.Drawing.Point(350, 58);
            this.guna2CircleButton1_ViewUser.Name = "guna2CircleButton1_ViewUser";
            this.guna2CircleButton1_ViewUser.PressedColor = System.Drawing.Color.White;
            this.guna2CircleButton1_ViewUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1_ViewUser.Size = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1_ViewUser.TabIndex = 48;
            this.guna2CircleButton1_ViewUser.Text = "guna2CircleButton1";
            this.guna2CircleButton1_ViewUser.UseTransparentBackground = true;
            this.guna2CircleButton1_ViewUser.Click += new System.EventHandler(this.guna2CircleButton1_ViewUser_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(29, 293);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 564);
            this.listBox1.TabIndex = 49;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox6_TotPrice
            // 
            this.textBox6_TotPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6_TotPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6_TotPrice.Location = new System.Drawing.Point(814, 426);
            this.textBox6_TotPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6_TotPrice.Name = "textBox6_TotPrice";
            this.textBox6_TotPrice.ReadOnly = true;
            this.textBox6_TotPrice.Size = new System.Drawing.Size(324, 34);
            this.textBox6_TotPrice.TabIndex = 51;
            this.textBox6_TotPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(810, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 28);
            this.label8.TabIndex = 50;
            this.label8.Text = "Total Price";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.guna2DataGridView1.ColumnHeadersHeight = 30;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(359, 555);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(810, 242);
            this.guna2DataGridView1.TabIndex = 52;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // label9_price
            // 
            this.label9_price.BackColor = System.Drawing.Color.White;
            this.label9_price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9_price.Location = new System.Drawing.Point(686, 835);
            this.label9_price.Name = "label9_price";
            this.label9_price.Size = new System.Drawing.Size(144, 45);
            this.label9_price.TabIndex = 55;
            this.label9_price.Text = "Rs. 00";
            this.label9_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1_sell
            // 
            this.guna2Elipse1_sell.TargetControl = this;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Expire Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price Per Unit";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No of Units";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Pharmacy_System.Properties.Resources.credit_card;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(908, 828);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(261, 56);
            this.guna2Button1.TabIndex = 54;
            this.guna2Button1.Text = "Purchase and Print";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::Pharmacy_System.Properties.Resources.remove;
            this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2.Location = new System.Drawing.Point(359, 828);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(162, 56);
            this.guna2Button2.TabIndex = 53;
            this.guna2Button2.Text = "Remove";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy_System.Properties.Resources.icons8_refresh__1_;
            this.pictureBox1.Location = new System.Drawing.Point(325, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button2_clear
            // 
            this.guna2Button2_clear.BorderRadius = 15;
            this.guna2Button2_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2_clear.ForeColor = System.Drawing.Color.White;
            this.guna2Button2_clear.Image = global::Pharmacy_System.Properties.Resources.add_to_cart;
            this.guna2Button2_clear.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2_clear.Location = new System.Drawing.Point(931, 483);
            this.guna2Button2_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2_clear.Name = "guna2Button2_clear";
            this.guna2Button2_clear.Size = new System.Drawing.Size(206, 56);
            this.guna2Button2_clear.TabIndex = 37;
            this.guna2Button2_clear.Text = "Add to Cart";
            this.guna2Button2_clear.Click += new System.EventHandler(this.guna2Button2_clear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(581, 843);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 28);
            this.label9.TabIndex = 56;
            this.label9.Text = "Total Price : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Sell_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label9_price);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.textBox6_TotPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.guna2CircleButton1_ViewUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4_Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5_numOfunits);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3_mName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button2_clear);
            this.Controls.Add(this.dateTimePicker1_expire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2_medID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Sell_UC";
            this.Size = new System.Drawing.Size(1205, 905);
            this.Load += new System.EventHandler(this.Sell_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button2_clear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_expire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2_medID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3_mName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5_numOfunits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1_search;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1_ViewUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox6_TotPrice;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label9_price;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1_sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label9;
    }
}
