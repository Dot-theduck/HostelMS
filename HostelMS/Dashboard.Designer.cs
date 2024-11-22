namespace HostelMS
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Closebtn = new System.Windows.Forms.PictureBox();
            this.Dashboardbtn = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logoutbtn = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Paymentbtn = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Roombtn = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Tenantsbtn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RoomsLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TenantsLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.FinancesLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountCalculatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDbDataSet = new HostelMS.HostelDbDataSet();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.bookTblTableAdapter = new HostelMS.HostelDbDataSetTableAdapters.BookTblTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // Closebtn
            // 
            this.Closebtn.Image = ((System.Drawing.Image)(resources.GetObject("Closebtn.Image")));
            this.Closebtn.Location = new System.Drawing.Point(1078, 12);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(54, 50);
            this.Closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Closebtn.TabIndex = 54;
            this.Closebtn.TabStop = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Dashboardbtn
            // 
            this.Dashboardbtn.AutoSize = true;
            this.Dashboardbtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboardbtn.ForeColor = System.Drawing.Color.DimGray;
            this.Dashboardbtn.Location = new System.Drawing.Point(78, 252);
            this.Dashboardbtn.Name = "Dashboardbtn";
            this.Dashboardbtn.Size = new System.Drawing.Size(89, 21);
            this.Dashboardbtn.TabIndex = 13;
            this.Dashboardbtn.Text = "Dashboard";
            this.Dashboardbtn.Click += new System.EventHandler(this.Dashboardbtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 238);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.Dashboardbtn);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Logoutbtn);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.Paymentbtn);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.Roombtn);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Tenantsbtn);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 669);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(206, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 7;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.AutoSize = true;
            this.Logoutbtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.ForeColor = System.Drawing.Color.DimGray;
            this.Logoutbtn.Location = new System.Drawing.Point(78, 630);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(63, 21);
            this.Logoutbtn.TabIndex = 11;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 616);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(60, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // Paymentbtn
            // 
            this.Paymentbtn.AutoSize = true;
            this.Paymentbtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paymentbtn.ForeColor = System.Drawing.Color.DimGray;
            this.Paymentbtn.Location = new System.Drawing.Point(78, 505);
            this.Paymentbtn.Name = "Paymentbtn";
            this.Paymentbtn.Size = new System.Drawing.Size(80, 21);
            this.Paymentbtn.TabIndex = 9;
            this.Paymentbtn.Text = "Payments";
            this.Paymentbtn.Click += new System.EventHandler(this.Paymentbtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 491);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // Roombtn
            // 
            this.Roombtn.AutoSize = true;
            this.Roombtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roombtn.ForeColor = System.Drawing.Color.DimGray;
            this.Roombtn.Location = new System.Drawing.Point(78, 325);
            this.Roombtn.Name = "Roombtn";
            this.Roombtn.Size = new System.Drawing.Size(61, 21);
            this.Roombtn.TabIndex = 5;
            this.Roombtn.Text = "Rooms";
            this.Roombtn.Click += new System.EventHandler(this.Roombtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 311);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Tenantsbtn
            // 
            this.Tenantsbtn.AutoSize = true;
            this.Tenantsbtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenantsbtn.ForeColor = System.Drawing.Color.DimGray;
            this.Tenantsbtn.Location = new System.Drawing.Point(78, 440);
            this.Tenantsbtn.Name = "Tenantsbtn";
            this.Tenantsbtn.Size = new System.Drawing.Size(65, 21);
            this.Tenantsbtn.TabIndex = 3;
            this.Tenantsbtn.Text = "Tenants";
            this.Tenantsbtn.Click += new System.EventHandler(this.Tenantsbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 426);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(78, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hostel MS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(198, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 100);
            this.panel3.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dashboard";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSalmon;
            this.panel4.Controls.Add(this.RoomsLbl);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(258, 566);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 80);
            this.panel4.TabIndex = 57;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // RoomsLbl
            // 
            this.RoomsLbl.AutoSize = true;
            this.RoomsLbl.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomsLbl.Location = new System.Drawing.Point(19, 51);
            this.RoomsLbl.Name = "RoomsLbl";
            this.RoomsLbl.Size = new System.Drawing.Size(43, 25);
            this.RoomsLbl.TabIndex = 2;
            this.RoomsLbl.Text = "Ksh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of Rooms";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSalmon;
            this.panel5.Controls.Add(this.TenantsLbl);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(593, 566);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 80);
            this.panel5.TabIndex = 58;
            // 
            // TenantsLbl
            // 
            this.TenantsLbl.AutoSize = true;
            this.TenantsLbl.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenantsLbl.Location = new System.Drawing.Point(19, 51);
            this.TenantsLbl.Name = "TenantsLbl";
            this.TenantsLbl.Size = new System.Drawing.Size(43, 25);
            this.TenantsLbl.TabIndex = 2;
            this.TenantsLbl.Text = "Ksh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "No of Tenants";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSalmon;
            this.panel6.Controls.Add(this.FinancesLbl);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(852, 566);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 80);
            this.panel6.TabIndex = 58;
            // 
            // FinancesLbl
            // 
            this.FinancesLbl.AutoSize = true;
            this.FinancesLbl.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinancesLbl.Location = new System.Drawing.Point(19, 51);
            this.FinancesLbl.Name = "FinancesLbl";
            this.FinancesLbl.Size = new System.Drawing.Size(43, 25);
            this.FinancesLbl.TabIndex = 2;
            this.FinancesLbl.Text = "Ksh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Finance";
            // 
            // chartRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend1);
            this.chartRevenue.Location = new System.Drawing.Point(696, 223);
            this.chartRevenue.Name = "chartRevenue";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Tenants";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Room";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Cost";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Balance";
            this.chartRevenue.Series.Add(series1);
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Series.Add(series3);
            this.chartRevenue.Series.Add(series4);
            this.chartRevenue.Size = new System.Drawing.Size(467, 300);
            this.chartRevenue.TabIndex = 60;
            this.chartRevenue.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Overall";
            this.chartRevenue.Titles.Add(title1);
            this.chartRevenue.Click += new System.EventHandler(this.chartRevenue_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rcodeDataGridViewTextBoxColumn,
            this.tenantDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.amountCalculatedDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookTblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(214, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 254);
            this.dataGridView1.TabIndex = 61;
            // 
            // rcodeDataGridViewTextBoxColumn
            // 
            this.rcodeDataGridViewTextBoxColumn.DataPropertyName = "Rcode";
            this.rcodeDataGridViewTextBoxColumn.HeaderText = "Rcode";
            this.rcodeDataGridViewTextBoxColumn.Name = "rcodeDataGridViewTextBoxColumn";
            this.rcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenantDataGridViewTextBoxColumn
            // 
            this.tenantDataGridViewTextBoxColumn.DataPropertyName = "Tenant";
            this.tenantDataGridViewTextBoxColumn.HeaderText = "Tenant";
            this.tenantDataGridViewTextBoxColumn.Name = "tenantDataGridViewTextBoxColumn";
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            // 
            // amountCalculatedDataGridViewTextBoxColumn
            // 
            this.amountCalculatedDataGridViewTextBoxColumn.DataPropertyName = "AmountCalculated";
            this.amountCalculatedDataGridViewTextBoxColumn.HeaderText = "AmountCalculated";
            this.amountCalculatedDataGridViewTextBoxColumn.Name = "amountCalculatedDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookTblBindingSource
            // 
            this.bookTblBindingSource.DataMember = "BookTbl";
            this.bookTblBindingSource.DataSource = this.hostelDbDataSet;
            // 
            // hostelDbDataSet
            // 
            this.hostelDbDataSet.DataSetName = "HostelDbDataSet";
            this.hostelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(564, 524);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(223, 36);
            this.Loadbtn.TabIndex = 62;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // bookTblTableAdapter
            // 
            this.bookTblTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(78, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Owner";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(12, 367);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 669);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Closebtn;
        private System.Windows.Forms.Label Dashboardbtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Paymentbtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Roombtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Tenantsbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RoomsLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label TenantsLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label FinancesLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Loadbtn;
        private HostelDbDataSet hostelDbDataSet;
        private System.Windows.Forms.BindingSource bookTblBindingSource;
        private HostelDbDataSetTableAdapters.BookTblTableAdapter bookTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountCalculatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}