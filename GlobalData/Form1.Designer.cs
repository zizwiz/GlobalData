﻿
namespace GlobalData
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabctrl_main = new System.Windows.Forms.TabControl();
            this.tab_great_circle = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_DBM = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_compute_distance = new System.Windows.Forms.Button();
            this.btn_gc_clear = new System.Windows.Forms.Button();
            this.btn_compute_initial_bearing = new System.Windows.Forms.Button();
            this.btn_compute_midpoint = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rchtxbx_output = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtbx_origin_longitude = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtbx_dest_longitude = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtbx_origin_latitude = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtbx_dest_latitude = new System.Windows.Forms.TextBox();
            this.tab_destination = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.grpbx_FD_bearing = new System.Windows.Forms.GroupBox();
            this.lbl_FD_bearing_seconds = new System.Windows.Forms.Label();
            this.txtbx_FD_bearing_seconds = new System.Windows.Forms.TextBox();
            this.lbl_FD_bearing_minutes = new System.Windows.Forms.Label();
            this.txtbx_FD_bearing_minutes = new System.Windows.Forms.TextBox();
            this.lbl_FD_bearing_degree = new System.Windows.Forms.Label();
            this.txtbx_FD_bearing_degrees = new System.Windows.Forms.TextBox();
            this.lbl_FD_bearing_decimaldegree = new System.Windows.Forms.Label();
            this.rdo_FD_bearing_decimal_degrees = new System.Windows.Forms.RadioButton();
            this.rdo_FD_bearing_DMS = new System.Windows.Forms.RadioButton();
            this.txtbx_FD_bearing_decimal_degrees = new System.Windows.Forms.TextBox();
            this.btn_clear_findDestination_output = new System.Windows.Forms.Button();
            this.grpbx_FD_distance = new System.Windows.Forms.GroupBox();
            this.lbl_FD_distance_type = new System.Windows.Forms.Label();
            this.rdobtn_FD_nauticalmiles = new System.Windows.Forms.RadioButton();
            this.rdobtn_FD_miles = new System.Windows.Forms.RadioButton();
            this.rdobtn_FD_kilometres = new System.Windows.Forms.RadioButton();
            this.rdobtn_FD_metres = new System.Windows.Forms.RadioButton();
            this.txtbx_distance = new System.Windows.Forms.TextBox();
            this.rchtxbx_findDestination_output = new System.Windows.Forms.RichTextBox();
            this.btn_GC_find_destination = new System.Windows.Forms.Button();
            this.txtbx_origin_latitude2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_origin_longitude2 = new System.Windows.Forms.TextBox();
            this.tab_CTD = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabctrl_main.SuspendLayout();
            this.tab_great_circle.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_DBM.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tab_destination.SuspendLayout();
            this.panel13.SuspendLayout();
            this.grpbx_FD_bearing.SuspendLayout();
            this.grpbx_FD_distance.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabctrl_main, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 665);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabctrl_main
            // 
            this.tabctrl_main.Controls.Add(this.tab_great_circle);
            this.tabctrl_main.Controls.Add(this.tabPage2);
            this.tabctrl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrl_main.Location = new System.Drawing.Point(3, 3);
            this.tabctrl_main.Name = "tabctrl_main";
            this.tabctrl_main.SelectedIndex = 0;
            this.tabctrl_main.Size = new System.Drawing.Size(1094, 579);
            this.tabctrl_main.TabIndex = 0;
            // 
            // tab_great_circle
            // 
            this.tab_great_circle.Controls.Add(this.tabControl1);
            this.tab_great_circle.Location = new System.Drawing.Point(4, 29);
            this.tab_great_circle.Name = "tab_great_circle";
            this.tab_great_circle.Padding = new System.Windows.Forms.Padding(3);
            this.tab_great_circle.Size = new System.Drawing.Size(1086, 546);
            this.tab_great_circle.TabIndex = 0;
            this.tab_great_circle.Text = "Great Circle";
            this.tab_great_circle.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tab_DBM);
            this.tabControl1.Controls.Add(this.tab_destination);
            this.tabControl1.Controls.Add(this.tab_CTD);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 540);
            this.tabControl1.TabIndex = 14;
            // 
            // tab_DBM
            // 
            this.tab_DBM.Controls.Add(this.panel2);
            this.tab_DBM.Location = new System.Drawing.Point(28, 4);
            this.tab_DBM.Name = "tab_DBM";
            this.tab_DBM.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DBM.Size = new System.Drawing.Size(1048, 532);
            this.tab_DBM.TabIndex = 0;
            this.tab_DBM.Text = "Distance, Bearing and Midpoint";
            this.tab_DBM.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 526);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 6, 4);
            this.tableLayoutPanel2.Controls.Add(this.btn_gc_clear, 6, 10);
            this.tableLayoutPanel2.Controls.Add(this.btn_compute_initial_bearing, 6, 6);
            this.tableLayoutPanel2.Controls.Add(this.btn_compute_midpoint, 6, 8);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel11, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel12, 6, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1042, 526);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_compute_distance);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(786, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 99);
            this.panel3.TabIndex = 0;
            // 
            // btn_compute_distance
            // 
            this.btn_compute_distance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_compute_distance.Location = new System.Drawing.Point(0, 0);
            this.btn_compute_distance.Name = "btn_compute_distance";
            this.btn_compute_distance.Size = new System.Drawing.Size(253, 99);
            this.btn_compute_distance.TabIndex = 11;
            this.btn_compute_distance.Text = "Compute Distance";
            this.btn_compute_distance.UseVisualStyleBackColor = true;
            this.btn_compute_distance.Click += new System.EventHandler(this.btn_compute_distance_Click);
            // 
            // btn_gc_clear
            // 
            this.btn_gc_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_gc_clear.Location = new System.Drawing.Point(786, 423);
            this.btn_gc_clear.Name = "btn_gc_clear";
            this.btn_gc_clear.Size = new System.Drawing.Size(253, 100);
            this.btn_gc_clear.TabIndex = 13;
            this.btn_gc_clear.Text = "Clear";
            this.btn_gc_clear.UseVisualStyleBackColor = true;
            this.btn_gc_clear.Click += new System.EventHandler(this.btn_gc_clear_Click);
            // 
            // btn_compute_initial_bearing
            // 
            this.btn_compute_initial_bearing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_compute_initial_bearing.Location = new System.Drawing.Point(786, 203);
            this.btn_compute_initial_bearing.Name = "btn_compute_initial_bearing";
            this.btn_compute_initial_bearing.Size = new System.Drawing.Size(253, 99);
            this.btn_compute_initial_bearing.TabIndex = 10;
            this.btn_compute_initial_bearing.Text = "Compute Initial Bearing";
            this.btn_compute_initial_bearing.UseVisualStyleBackColor = true;
            this.btn_compute_initial_bearing.Click += new System.EventHandler(this.btn_initial_bearing_Click);
            // 
            // btn_compute_midpoint
            // 
            this.btn_compute_midpoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_compute_midpoint.Location = new System.Drawing.Point(786, 313);
            this.btn_compute_midpoint.Name = "btn_compute_midpoint";
            this.btn_compute_midpoint.Size = new System.Drawing.Size(253, 99);
            this.btn_compute_midpoint.TabIndex = 12;
            this.btn_compute_midpoint.Text = "Compute Midpoint";
            this.btn_compute_midpoint.UseVisualStyleBackColor = true;
            this.btn_compute_midpoint.Click += new System.EventHandler(this.btn_compute_midpoint_Click);
            // 
            // panel4
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel4, 5);
            this.panel4.Controls.Add(this.rchtxbx_output);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 93);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel2.SetRowSpan(this.panel4, 7);
            this.panel4.Size = new System.Drawing.Size(772, 430);
            this.panel4.TabIndex = 14;
            // 
            // rchtxbx_output
            // 
            this.rchtxbx_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchtxbx_output.Location = new System.Drawing.Point(0, 0);
            this.rchtxbx_output.Name = "rchtxbx_output";
            this.rchtxbx_output.Size = new System.Drawing.Size(772, 430);
            this.rchtxbx_output.TabIndex = 9;
            this.rchtxbx_output.Text = "";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 34);
            this.panel5.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Longitude Origin";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 34);
            this.panel6.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Longitude Destination";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtbx_origin_longitude);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(264, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 34);
            this.panel7.TabIndex = 17;
            // 
            // txtbx_origin_longitude
            // 
            this.txtbx_origin_longitude.Location = new System.Drawing.Point(0, 4);
            this.txtbx_origin_longitude.Name = "txtbx_origin_longitude";
            this.txtbx_origin_longitude.Size = new System.Drawing.Size(184, 26);
            this.txtbx_origin_longitude.TabIndex = 1;
            this.txtbx_origin_longitude.Text = "0.12318499799890262";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtbx_dest_longitude);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(264, 48);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 34);
            this.panel8.TabIndex = 18;
            // 
            // txtbx_dest_longitude
            // 
            this.txtbx_dest_longitude.Location = new System.Drawing.Point(3, 4);
            this.txtbx_dest_longitude.Name = "txtbx_dest_longitude";
            this.txtbx_dest_longitude.Size = new System.Drawing.Size(184, 26);
            this.txtbx_dest_longitude.TabIndex = 5;
            this.txtbx_dest_longitude.Text = "-0.24141672862936847";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(525, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(250, 34);
            this.panel9.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Latitude Origin";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(525, 48);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(250, 34);
            this.panel10.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Latitude Destination";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtbx_origin_latitude);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(786, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(253, 34);
            this.panel11.TabIndex = 21;
            // 
            // txtbx_origin_latitude
            // 
            this.txtbx_origin_latitude.Location = new System.Drawing.Point(3, 4);
            this.txtbx_origin_latitude.Name = "txtbx_origin_latitude";
            this.txtbx_origin_latitude.Size = new System.Drawing.Size(157, 26);
            this.txtbx_origin_latitude.TabIndex = 3;
            this.txtbx_origin_latitude.Text = "52.22931415150747";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtbx_dest_latitude);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(786, 48);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(253, 34);
            this.panel12.TabIndex = 22;
            // 
            // txtbx_dest_latitude
            // 
            this.txtbx_dest_latitude.Location = new System.Drawing.Point(3, 4);
            this.txtbx_dest_latitude.Name = "txtbx_dest_latitude";
            this.txtbx_dest_latitude.Size = new System.Drawing.Size(157, 26);
            this.txtbx_dest_latitude.TabIndex = 7;
            this.txtbx_dest_latitude.Text = "52.13020137607176";
            // 
            // tab_destination
            // 
            this.tab_destination.Controls.Add(this.panel13);
            this.tab_destination.Location = new System.Drawing.Point(28, 4);
            this.tab_destination.Name = "tab_destination";
            this.tab_destination.Padding = new System.Windows.Forms.Padding(3);
            this.tab_destination.Size = new System.Drawing.Size(1048, 532);
            this.tab_destination.TabIndex = 1;
            this.tab_destination.Text = "Find Destination";
            this.tab_destination.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.grpbx_FD_bearing);
            this.panel13.Controls.Add(this.btn_clear_findDestination_output);
            this.panel13.Controls.Add(this.grpbx_FD_distance);
            this.panel13.Controls.Add(this.rchtxbx_findDestination_output);
            this.panel13.Controls.Add(this.btn_GC_find_destination);
            this.panel13.Controls.Add(this.txtbx_origin_latitude2);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Controls.Add(this.label5);
            this.panel13.Controls.Add(this.txtbx_origin_longitude2);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(3, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1042, 526);
            this.panel13.TabIndex = 0;
            // 
            // grpbx_FD_bearing
            // 
            this.grpbx_FD_bearing.Controls.Add(this.lbl_FD_bearing_seconds);
            this.grpbx_FD_bearing.Controls.Add(this.txtbx_FD_bearing_seconds);
            this.grpbx_FD_bearing.Controls.Add(this.lbl_FD_bearing_minutes);
            this.grpbx_FD_bearing.Controls.Add(this.txtbx_FD_bearing_minutes);
            this.grpbx_FD_bearing.Controls.Add(this.lbl_FD_bearing_degree);
            this.grpbx_FD_bearing.Controls.Add(this.txtbx_FD_bearing_degrees);
            this.grpbx_FD_bearing.Controls.Add(this.lbl_FD_bearing_decimaldegree);
            this.grpbx_FD_bearing.Controls.Add(this.rdo_FD_bearing_decimal_degrees);
            this.grpbx_FD_bearing.Controls.Add(this.rdo_FD_bearing_DMS);
            this.grpbx_FD_bearing.Controls.Add(this.txtbx_FD_bearing_decimal_degrees);
            this.grpbx_FD_bearing.Location = new System.Drawing.Point(80, 163);
            this.grpbx_FD_bearing.Name = "grpbx_FD_bearing";
            this.grpbx_FD_bearing.Size = new System.Drawing.Size(426, 161);
            this.grpbx_FD_bearing.TabIndex = 18;
            this.grpbx_FD_bearing.TabStop = false;
            this.grpbx_FD_bearing.Text = "Bearing";
            // 
            // lbl_FD_bearing_seconds
            // 
            this.lbl_FD_bearing_seconds.AutoSize = true;
            this.lbl_FD_bearing_seconds.Location = new System.Drawing.Point(374, 37);
            this.lbl_FD_bearing_seconds.Name = "lbl_FD_bearing_seconds";
            this.lbl_FD_bearing_seconds.Size = new System.Drawing.Size(15, 20);
            this.lbl_FD_bearing_seconds.TabIndex = 14;
            this.lbl_FD_bearing_seconds.Text = "\"";
            // 
            // txtbx_FD_bearing_seconds
            // 
            this.txtbx_FD_bearing_seconds.Location = new System.Drawing.Point(268, 34);
            this.txtbx_FD_bearing_seconds.Name = "txtbx_FD_bearing_seconds";
            this.txtbx_FD_bearing_seconds.Size = new System.Drawing.Size(100, 26);
            this.txtbx_FD_bearing_seconds.TabIndex = 13;
            // 
            // lbl_FD_bearing_minutes
            // 
            this.lbl_FD_bearing_minutes.AutoSize = true;
            this.lbl_FD_bearing_minutes.Location = new System.Drawing.Point(248, 37);
            this.lbl_FD_bearing_minutes.Name = "lbl_FD_bearing_minutes";
            this.lbl_FD_bearing_minutes.Size = new System.Drawing.Size(12, 20);
            this.lbl_FD_bearing_minutes.TabIndex = 12;
            this.lbl_FD_bearing_minutes.Text = "\'";
            // 
            // txtbx_FD_bearing_minutes
            // 
            this.txtbx_FD_bearing_minutes.Location = new System.Drawing.Point(142, 34);
            this.txtbx_FD_bearing_minutes.Name = "txtbx_FD_bearing_minutes";
            this.txtbx_FD_bearing_minutes.Size = new System.Drawing.Size(100, 26);
            this.txtbx_FD_bearing_minutes.TabIndex = 11;
            // 
            // lbl_FD_bearing_degree
            // 
            this.lbl_FD_bearing_degree.AutoSize = true;
            this.lbl_FD_bearing_degree.Location = new System.Drawing.Point(121, 37);
            this.lbl_FD_bearing_degree.Name = "lbl_FD_bearing_degree";
            this.lbl_FD_bearing_degree.Size = new System.Drawing.Size(14, 20);
            this.lbl_FD_bearing_degree.TabIndex = 10;
            this.lbl_FD_bearing_degree.Text = "°";
            // 
            // txtbx_FD_bearing_degrees
            // 
            this.txtbx_FD_bearing_degrees.Location = new System.Drawing.Point(15, 34);
            this.txtbx_FD_bearing_degrees.Name = "txtbx_FD_bearing_degrees";
            this.txtbx_FD_bearing_degrees.Size = new System.Drawing.Size(100, 26);
            this.txtbx_FD_bearing_degrees.TabIndex = 9;
            // 
            // lbl_FD_bearing_decimaldegree
            // 
            this.lbl_FD_bearing_decimaldegree.AutoSize = true;
            this.lbl_FD_bearing_decimaldegree.Location = new System.Drawing.Point(287, 79);
            this.lbl_FD_bearing_decimaldegree.Name = "lbl_FD_bearing_decimaldegree";
            this.lbl_FD_bearing_decimaldegree.Size = new System.Drawing.Size(14, 20);
            this.lbl_FD_bearing_decimaldegree.TabIndex = 8;
            this.lbl_FD_bearing_decimaldegree.Text = "°";
            // 
            // rdo_FD_bearing_decimal_degrees
            // 
            this.rdo_FD_bearing_decimal_degrees.AutoSize = true;
            this.rdo_FD_bearing_decimal_degrees.Location = new System.Drawing.Point(10, 119);
            this.rdo_FD_bearing_decimal_degrees.Name = "rdo_FD_bearing_decimal_degrees";
            this.rdo_FD_bearing_decimal_degrees.Size = new System.Drawing.Size(156, 24);
            this.rdo_FD_bearing_decimal_degrees.TabIndex = 1;
            this.rdo_FD_bearing_decimal_degrees.Text = "Decimal Degrees";
            this.rdo_FD_bearing_decimal_degrees.UseVisualStyleBackColor = true;
            this.rdo_FD_bearing_decimal_degrees.CheckedChanged += new System.EventHandler(this.FD_bearing_rdobtn_changed);
            // 
            // rdo_FD_bearing_DMS
            // 
            this.rdo_FD_bearing_DMS.AutoSize = true;
            this.rdo_FD_bearing_DMS.Location = new System.Drawing.Point(186, 119);
            this.rdo_FD_bearing_DMS.Name = "rdo_FD_bearing_DMS";
            this.rdo_FD_bearing_DMS.Size = new System.Drawing.Size(230, 24);
            this.rdo_FD_bearing_DMS.TabIndex = 0;
            this.rdo_FD_bearing_DMS.Text = "Degrees, Minutes, Seconds";
            this.rdo_FD_bearing_DMS.UseVisualStyleBackColor = true;
            this.rdo_FD_bearing_DMS.CheckedChanged += new System.EventHandler(this.FD_bearing_rdobtn_changed);
            // 
            // txtbx_FD_bearing_decimal_degrees
            // 
            this.txtbx_FD_bearing_decimal_degrees.Location = new System.Drawing.Point(97, 76);
            this.txtbx_FD_bearing_decimal_degrees.Name = "txtbx_FD_bearing_decimal_degrees";
            this.txtbx_FD_bearing_decimal_degrees.Size = new System.Drawing.Size(184, 26);
            this.txtbx_FD_bearing_decimal_degrees.TabIndex = 7;
            this.txtbx_FD_bearing_decimal_degrees.Text = "96.02166667";
            // 
            // btn_clear_findDestination_output
            // 
            this.btn_clear_findDestination_output.Location = new System.Drawing.Point(694, 442);
            this.btn_clear_findDestination_output.Name = "btn_clear_findDestination_output";
            this.btn_clear_findDestination_output.Size = new System.Drawing.Size(127, 62);
            this.btn_clear_findDestination_output.TabIndex = 17;
            this.btn_clear_findDestination_output.Text = "Clear";
            this.btn_clear_findDestination_output.UseVisualStyleBackColor = true;
            // 
            // grpbx_FD_distance
            // 
            this.grpbx_FD_distance.Controls.Add(this.lbl_FD_distance_type);
            this.grpbx_FD_distance.Controls.Add(this.rdobtn_FD_nauticalmiles);
            this.grpbx_FD_distance.Controls.Add(this.rdobtn_FD_miles);
            this.grpbx_FD_distance.Controls.Add(this.rdobtn_FD_kilometres);
            this.grpbx_FD_distance.Controls.Add(this.rdobtn_FD_metres);
            this.grpbx_FD_distance.Controls.Add(this.txtbx_distance);
            this.grpbx_FD_distance.Location = new System.Drawing.Point(75, 376);
            this.grpbx_FD_distance.Name = "grpbx_FD_distance";
            this.grpbx_FD_distance.Size = new System.Drawing.Size(432, 107);
            this.grpbx_FD_distance.TabIndex = 16;
            this.grpbx_FD_distance.TabStop = false;
            this.grpbx_FD_distance.Text = "Distance";
            // 
            // lbl_FD_distance_type
            // 
            this.lbl_FD_distance_type.AutoSize = true;
            this.lbl_FD_distance_type.Location = new System.Drawing.Point(319, 28);
            this.lbl_FD_distance_type.Name = "lbl_FD_distance_type";
            this.lbl_FD_distance_type.Size = new System.Drawing.Size(22, 20);
            this.lbl_FD_distance_type.TabIndex = 16;
            this.lbl_FD_distance_type.Text = "m";
            // 
            // rdobtn_FD_nauticalmiles
            // 
            this.rdobtn_FD_nauticalmiles.AutoSize = true;
            this.rdobtn_FD_nauticalmiles.Location = new System.Drawing.Point(292, 61);
            this.rdobtn_FD_nauticalmiles.Name = "rdobtn_FD_nauticalmiles";
            this.rdobtn_FD_nauticalmiles.Size = new System.Drawing.Size(129, 24);
            this.rdobtn_FD_nauticalmiles.TabIndex = 15;
            this.rdobtn_FD_nauticalmiles.Text = "nautical miles";
            this.rdobtn_FD_nauticalmiles.UseVisualStyleBackColor = true;
            this.rdobtn_FD_nauticalmiles.CheckedChanged += new System.EventHandler(this.FD_dstance_rdobtn_changed);
            // 
            // rdobtn_FD_miles
            // 
            this.rdobtn_FD_miles.AutoSize = true;
            this.rdobtn_FD_miles.Location = new System.Drawing.Point(216, 61);
            this.rdobtn_FD_miles.Name = "rdobtn_FD_miles";
            this.rdobtn_FD_miles.Size = new System.Drawing.Size(70, 24);
            this.rdobtn_FD_miles.TabIndex = 14;
            this.rdobtn_FD_miles.Text = "miles";
            this.rdobtn_FD_miles.UseVisualStyleBackColor = true;
            this.rdobtn_FD_miles.CheckedChanged += new System.EventHandler(this.FD_dstance_rdobtn_changed);
            // 
            // rdobtn_FD_kilometres
            // 
            this.rdobtn_FD_kilometres.AutoSize = true;
            this.rdobtn_FD_kilometres.Location = new System.Drawing.Point(104, 61);
            this.rdobtn_FD_kilometres.Name = "rdobtn_FD_kilometres";
            this.rdobtn_FD_kilometres.Size = new System.Drawing.Size(106, 24);
            this.rdobtn_FD_kilometres.TabIndex = 13;
            this.rdobtn_FD_kilometres.Text = "kilometres";
            this.rdobtn_FD_kilometres.UseVisualStyleBackColor = true;
            this.rdobtn_FD_kilometres.CheckedChanged += new System.EventHandler(this.FD_dstance_rdobtn_changed);
            // 
            // rdobtn_FD_metres
            // 
            this.rdobtn_FD_metres.AutoSize = true;
            this.rdobtn_FD_metres.Location = new System.Drawing.Point(15, 61);
            this.rdobtn_FD_metres.Name = "rdobtn_FD_metres";
            this.rdobtn_FD_metres.Size = new System.Drawing.Size(83, 24);
            this.rdobtn_FD_metres.TabIndex = 12;
            this.rdobtn_FD_metres.Text = "metres";
            this.rdobtn_FD_metres.UseVisualStyleBackColor = true;
            this.rdobtn_FD_metres.CheckedChanged += new System.EventHandler(this.FD_dstance_rdobtn_changed);
            // 
            // txtbx_distance
            // 
            this.txtbx_distance.Location = new System.Drawing.Point(129, 22);
            this.txtbx_distance.Name = "txtbx_distance";
            this.txtbx_distance.Size = new System.Drawing.Size(184, 26);
            this.txtbx_distance.TabIndex = 9;
            this.txtbx_distance.Text = "124.8";
            // 
            // rchtxbx_findDestination_output
            // 
            this.rchtxbx_findDestination_output.Location = new System.Drawing.Point(694, 3);
            this.rchtxbx_findDestination_output.Name = "rchtxbx_findDestination_output";
            this.rchtxbx_findDestination_output.Size = new System.Drawing.Size(329, 433);
            this.rchtxbx_findDestination_output.TabIndex = 11;
            this.rchtxbx_findDestination_output.Text = "";
            // 
            // btn_GC_find_destination
            // 
            this.btn_GC_find_destination.Location = new System.Drawing.Point(896, 442);
            this.btn_GC_find_destination.Name = "btn_GC_find_destination";
            this.btn_GC_find_destination.Size = new System.Drawing.Size(127, 62);
            this.btn_GC_find_destination.TabIndex = 10;
            this.btn_GC_find_destination.Text = "Find Destination";
            this.btn_GC_find_destination.UseVisualStyleBackColor = true;
            this.btn_GC_find_destination.Click += new System.EventHandler(this.btn_GC_find_destination_Click);
            // 
            // txtbx_origin_latitude2
            // 
            this.txtbx_origin_latitude2.Location = new System.Drawing.Point(222, 65);
            this.txtbx_origin_latitude2.Name = "txtbx_origin_latitude2";
            this.txtbx_origin_latitude2.Size = new System.Drawing.Size(184, 26);
            this.txtbx_origin_latitude2.TabIndex = 5;
            this.txtbx_origin_latitude2.Text = "53.32055556";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Latitude Origin";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Longitude Origin";
            // 
            // txtbx_origin_longitude2
            // 
            this.txtbx_origin_longitude2.Location = new System.Drawing.Point(222, 33);
            this.txtbx_origin_longitude2.Name = "txtbx_origin_longitude2";
            this.txtbx_origin_longitude2.Size = new System.Drawing.Size(184, 26);
            this.txtbx_origin_longitude2.TabIndex = 3;
            this.txtbx_origin_longitude2.Text = "-1.72972222";
            // 
            // tab_CTD
            // 
            this.tab_CTD.Location = new System.Drawing.Point(28, 4);
            this.tab_CTD.Name = "tab_CTD";
            this.tab_CTD.Size = new System.Drawing.Size(1048, 532);
            this.tab_CTD.TabIndex = 2;
            this.tab_CTD.Text = "Cross-Track Distance";
            this.tab_CTD.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1086, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 588);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 74);
            this.panel1.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(966, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(119, 57);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Global Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabctrl_main.ResumeLayout(false);
            this.tab_great_circle.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_DBM.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tab_destination.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.grpbx_FD_bearing.ResumeLayout(false);
            this.grpbx_FD_bearing.PerformLayout();
            this.grpbx_FD_distance.ResumeLayout(false);
            this.grpbx_FD_distance.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabctrl_main;
        private System.Windows.Forms.TabPage tab_great_circle;
        private System.Windows.Forms.RichTextBox rchtxbx_output;
        private System.Windows.Forms.TextBox txtbx_dest_latitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_dest_longitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_origin_latitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_origin_longitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_compute_initial_bearing;
        private System.Windows.Forms.Button btn_compute_distance;
        private System.Windows.Forms.Button btn_compute_midpoint;
        private System.Windows.Forms.Button btn_gc_clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_DBM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tab_destination;
        private System.Windows.Forms.TabPage tab_CTD;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtbx_distance;
        private System.Windows.Forms.TextBox txtbx_FD_bearing_decimal_degrees;
        private System.Windows.Forms.TextBox txtbx_origin_latitude2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_origin_longitude2;
        private System.Windows.Forms.Button btn_GC_find_destination;
        private System.Windows.Forms.RichTextBox rchtxbx_findDestination_output;
        private System.Windows.Forms.GroupBox grpbx_FD_distance;
        private System.Windows.Forms.Label lbl_FD_distance_type;
        private System.Windows.Forms.RadioButton rdobtn_FD_nauticalmiles;
        private System.Windows.Forms.RadioButton rdobtn_FD_miles;
        private System.Windows.Forms.RadioButton rdobtn_FD_kilometres;
        private System.Windows.Forms.RadioButton rdobtn_FD_metres;
        private System.Windows.Forms.GroupBox grpbx_FD_bearing;
        private System.Windows.Forms.Button btn_clear_findDestination_output;
        private System.Windows.Forms.TextBox txtbx_FD_bearing_degrees;
        private System.Windows.Forms.Label lbl_FD_bearing_decimaldegree;
        private System.Windows.Forms.RadioButton rdo_FD_bearing_decimal_degrees;
        private System.Windows.Forms.RadioButton rdo_FD_bearing_DMS;
        private System.Windows.Forms.Label lbl_FD_bearing_seconds;
        private System.Windows.Forms.TextBox txtbx_FD_bearing_seconds;
        private System.Windows.Forms.Label lbl_FD_bearing_minutes;
        private System.Windows.Forms.TextBox txtbx_FD_bearing_minutes;
        private System.Windows.Forms.Label lbl_FD_bearing_degree;
    }
}

