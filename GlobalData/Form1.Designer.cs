
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_origin_longitude = new System.Windows.Forms.TextBox();
            this.txtbx_origin_latitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_dest_latitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_dest_longitude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_compute_distance = new System.Windows.Forms.Button();
            this.rchtxbx_great_circle_results = new System.Windows.Forms.RichTextBox();
            this.btn_compute_bearing = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabctrl_main.SuspendLayout();
            this.tab_great_circle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabctrl_main, 0, 0);
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
            this.tab_great_circle.Controls.Add(this.btn_compute_bearing);
            this.tab_great_circle.Controls.Add(this.rchtxbx_great_circle_results);
            this.tab_great_circle.Controls.Add(this.btn_compute_distance);
            this.tab_great_circle.Controls.Add(this.txtbx_dest_latitude);
            this.tab_great_circle.Controls.Add(this.label3);
            this.tab_great_circle.Controls.Add(this.txtbx_dest_longitude);
            this.tab_great_circle.Controls.Add(this.label4);
            this.tab_great_circle.Controls.Add(this.txtbx_origin_latitude);
            this.tab_great_circle.Controls.Add(this.label2);
            this.tab_great_circle.Controls.Add(this.txtbx_origin_longitude);
            this.tab_great_circle.Controls.Add(this.label1);
            this.tab_great_circle.Location = new System.Drawing.Point(4, 29);
            this.tab_great_circle.Name = "tab_great_circle";
            this.tab_great_circle.Padding = new System.Windows.Forms.Padding(3);
            this.tab_great_circle.Size = new System.Drawing.Size(1086, 546);
            this.tab_great_circle.TabIndex = 0;
            this.tab_great_circle.Text = "Great Circle";
            this.tab_great_circle.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Longitude Origin";
            // 
            // txtbx_origin_longitude
            // 
            this.txtbx_origin_longitude.Location = new System.Drawing.Point(197, 33);
            this.txtbx_origin_longitude.Name = "txtbx_origin_longitude";
            this.txtbx_origin_longitude.Size = new System.Drawing.Size(143, 26);
            this.txtbx_origin_longitude.TabIndex = 1;
            this.txtbx_origin_longitude.Text = "0.12318499799890262";
            // 
            // txtbx_origin_latitude
            // 
            this.txtbx_origin_latitude.Location = new System.Drawing.Point(530, 33);
            this.txtbx_origin_latitude.Name = "txtbx_origin_latitude";
            this.txtbx_origin_latitude.Size = new System.Drawing.Size(143, 26);
            this.txtbx_origin_latitude.TabIndex = 3;
            this.txtbx_origin_latitude.Text = "52.22931415150747";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Latitude Origin";
            // 
            // txtbx_dest_latitude
            // 
            this.txtbx_dest_latitude.Location = new System.Drawing.Point(530, 65);
            this.txtbx_dest_latitude.Name = "txtbx_dest_latitude";
            this.txtbx_dest_latitude.Size = new System.Drawing.Size(143, 26);
            this.txtbx_dest_latitude.TabIndex = 7;
            this.txtbx_dest_latitude.Text = "52.13020137607176";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Latitude Destination";
            // 
            // txtbx_dest_longitude
            // 
            this.txtbx_dest_longitude.Location = new System.Drawing.Point(197, 65);
            this.txtbx_dest_longitude.Name = "txtbx_dest_longitude";
            this.txtbx_dest_longitude.Size = new System.Drawing.Size(143, 26);
            this.txtbx_dest_longitude.TabIndex = 5;
            this.txtbx_dest_longitude.Text = "-0.24141672862936847";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Longitude Destination";
            // 
            // btn_compute_distance
            // 
            this.btn_compute_distance.Location = new System.Drawing.Point(600, 169);
            this.btn_compute_distance.Name = "btn_compute_distance";
            this.btn_compute_distance.Size = new System.Drawing.Size(119, 57);
            this.btn_compute_distance.TabIndex = 8;
            this.btn_compute_distance.Text = "Compute Distance";
            this.btn_compute_distance.UseVisualStyleBackColor = true;
            this.btn_compute_distance.Click += new System.EventHandler(this.btn_great_circle_compute_Click);
            // 
            // rchtxbx_great_circle_results
            // 
            this.rchtxbx_great_circle_results.Location = new System.Drawing.Point(41, 140);
            this.rchtxbx_great_circle_results.Name = "rchtxbx_great_circle_results";
            this.rchtxbx_great_circle_results.Size = new System.Drawing.Size(458, 360);
            this.rchtxbx_great_circle_results.TabIndex = 9;
            this.rchtxbx_great_circle_results.Text = "";
            // 
            // btn_compute_bearing
            // 
            this.btn_compute_bearing.Location = new System.Drawing.Point(600, 273);
            this.btn_compute_bearing.Name = "btn_compute_bearing";
            this.btn_compute_bearing.Size = new System.Drawing.Size(119, 57);
            this.btn_compute_bearing.TabIndex = 10;
            this.btn_compute_bearing.Text = "Compute Bearing";
            this.btn_compute_bearing.UseVisualStyleBackColor = true;
            this.btn_compute_bearing.Click += new System.EventHandler(this.btn_bearing_Click);
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
            this.tab_great_circle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabctrl_main;
        private System.Windows.Forms.TabPage tab_great_circle;
        private System.Windows.Forms.RichTextBox rchtxbx_great_circle_results;
        private System.Windows.Forms.Button btn_compute_distance;
        private System.Windows.Forms.TextBox txtbx_dest_latitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_dest_longitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_origin_latitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_origin_longitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_compute_bearing;
    }
}

