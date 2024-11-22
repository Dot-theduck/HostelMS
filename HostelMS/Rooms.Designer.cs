using System;

namespace HostelMS
{
    partial class Rooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            this.dataGridRoom = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RNameTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dashboardbtn = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CostCb = new System.Windows.Forms.TextBox();
            this.TypeCb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AddRoom = new System.Windows.Forms.PictureBox();
            this.Closebtn = new System.Windows.Forms.PictureBox();
            this.OwnerTb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ownerbtn = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRoom
            // 
            this.dataGridRoom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoom.Location = new System.Drawing.Point(198, 364);
            this.dataGridRoom.Name = "dataGridRoom";
            this.dataGridRoom.Size = new System.Drawing.Size(952, 305);
            this.dataGridRoom.TabIndex = 29;
            this.dataGridRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoom_CellContentClick);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Gray;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(753, 272);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(102, 36);
            this.Deletebtn.TabIndex = 28;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.Color.Gray;
            this.Editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbtn.ForeColor = System.Drawing.Color.White;
            this.Editbtn.Location = new System.Drawing.Point(592, 272);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(102, 36);
            this.Editbtn.TabIndex = 27;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click_1);
            // 
            // StatusCb
            // 
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "Available",
            "Taken"});
            this.StatusCb.Location = new System.Drawing.Point(690, 235);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(121, 25);
            this.StatusCb.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(385, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(221, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Room  Name";
            // 
            // RNameTb
            // 
            this.RNameTb.Location = new System.Drawing.Point(221, 235);
            this.RNameTb.Name = "RNameTb";
            this.RNameTb.Size = new System.Drawing.Size(133, 25);
            this.RNameTb.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Rooms";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(198, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 100);
            this.panel3.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(206, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(1179, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(54, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(482, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Room List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.Ownerbtn);
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
            this.panel1.TabIndex = 17;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(540, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Cost per month";
            // 
            // CostCb
            // 
            this.CostCb.Location = new System.Drawing.Point(540, 235);
            this.CostCb.Name = "CostCb";
            this.CostCb.Size = new System.Drawing.Size(133, 25);
            this.CostCb.TabIndex = 32;
            // 
            // TypeCb
            // 
            this.TypeCb.FormattingEnabled = true;
            this.TypeCb.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.TypeCb.Location = new System.Drawing.Point(388, 238);
            this.TypeCb.Name = "TypeCb";
            this.TypeCb.Size = new System.Drawing.Size(121, 25);
            this.TypeCb.TabIndex = 34;
            this.TypeCb.SelectedIndexChanged += new System.EventHandler(this.TypeCb_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(687, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Status";
            // 
            // AddRoom
            // 
            this.AddRoom.Image = ((System.Drawing.Image)(resources.GetObject("AddRoom.Image")));
            this.AddRoom.Location = new System.Drawing.Point(1023, 234);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(34, 26);
            this.AddRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddRoom.TabIndex = 36;
            this.AddRoom.TabStop = false;
            this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Image = ((System.Drawing.Image)(resources.GetObject("Closebtn.Image")));
            this.Closebtn.Location = new System.Drawing.Point(1087, 12);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(54, 50);
            this.Closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Closebtn.TabIndex = 37;
            this.Closebtn.TabStop = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // OwnerTb
            // 
            this.OwnerTb.FormattingEnabled = true;
            this.OwnerTb.Location = new System.Drawing.Point(833, 234);
            this.OwnerTb.Margin = new System.Windows.Forms.Padding(4);
            this.OwnerTb.Name = "OwnerTb";
            this.OwnerTb.Size = new System.Drawing.Size(140, 25);
            this.OwnerTb.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(830, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "Owner";
            // 
            // Ownerbtn
            // 
            this.Ownerbtn.AutoSize = true;
            this.Ownerbtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ownerbtn.ForeColor = System.Drawing.Color.DimGray;
            this.Ownerbtn.Location = new System.Drawing.Point(78, 383);
            this.Ownerbtn.Name = "Ownerbtn";
            this.Ownerbtn.Size = new System.Drawing.Size(65, 21);
            this.Ownerbtn.TabIndex = 15;
            this.Ownerbtn.Text = "Owners";
            this.Ownerbtn.Click += new System.EventHandler(this.Ownerbtn_Click);
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
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 669);
            this.Controls.Add(this.OwnerTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.AddRoom);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TypeCb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CostCb);
            this.Controls.Add(this.dataGridRoom);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.StatusCb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RNameTb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoom)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRoom;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RNameTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox8;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CostCb;
        private System.Windows.Forms.ComboBox TypeCb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox AddRoom;
        //private EventHandler Editbtn_Click;
        private System.Windows.Forms.PictureBox Closebtn;
        private System.Windows.Forms.Label Dashboardbtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox OwnerTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ownerbtn;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}