using System;
using System.Reflection;
using System.Windows.Forms;
using GlobalData.Properties;
using help_about;

namespace GlobalData
{
    public partial class Form1 : Form
    {
        private Settings _settings = Settings.Default;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            //Set up the Great Circle Distance, Bearing and midpoint tab
            rdo_GC_DBM_origin_decimal_degrees.Checked = true;
            rdo_GC_DBM_destination_decimal_degrees.Checked = true;
            cmbobx_GC_DBM_destination_longitude_cardinal.SelectedIndex = 0;
            cmbobx_GC_DBM_origin_longitude_cardinal.SelectedIndex = 0;
            cmbobx_GC_DBM_destination_latitude_cardinal.SelectedIndex = 0;
            cmbobx_GC_DBM_origin_latitude_cardinal.SelectedIndex = 0;

            //Set up the Great Circle Find Distance tab
            rdo_GC_FD_origin_longitude_decimal_degrees.Checked = true;
            rdo_GC_FD_origin_latitude_decimal_degrees.Checked = true;
            rdo_GC_FD_bearing_decimal_degrees.Checked = true;
            rdobtn_GC_FD_metres.Checked = true;
            rdo_GC_FD_results_format_decimal_degrees.Checked = true;
            cmbobx_GC_FD_origin_longitude_cardinal.SelectedIndex = 0;
            cmbobx_GC_FD_origin_latitude_cardinal.SelectedIndex = 0;

            //Set up the Great Circle Cross-Track Distance
            rdobtn_GC_CTD_longitude1_decimal.Checked = true;
            rdobtn_GC_CTD_latitude1_decimal.Checked = true;
            rdobtn_GC_CTD_bearing1_decimal.Checked = true;
            rdobtn_GC_CTD_longitude2_decimal.Checked = true;
            rdobtn_GC_CTD_latitude2_decimal.Checked = true;
            rdobtn_GC_CTD_bearing2_decimal.Checked = true;
            cmbobx_GC_CTD_longitude1_DMS_cardinal.SelectedIndex = 0;
            cmbobx_GC_CTD_latitude1_DMS_cardinal.SelectedIndex = 0;
            cmbobx_GC_CTD_longitude2_DMS_cardinal.SelectedIndex = 0;
            cmbobx_GC_CTD_latitude2_DMS_cardinal.SelectedIndex = 0;
            rdo_GC_CTD_results_format_decimal_degrees.Checked = true;

            //Set up the Rhumb Distance, Bearing and midpoint tab
            rdo_R_DBM_origin_decimal_degrees.Checked = true;
            rdo_R_DBM_destination_decimal_degrees.Checked = true;
            cmbobx_R_DBM_destination_longitude_cardinal.SelectedIndex = 0;
            cmbobx_R_DBM_origin_longitude_cardinal.SelectedIndex = 0;
            cmbobx_R_DBM_destination_latitude_cardinal.SelectedIndex = 0;
            cmbobx_R_DBM_origin_latitude_cardinal.SelectedIndex = 0;

            //Set up the Rhumb Find Distance tab
            rdo_R_FD_origin_longitude_decimal_degrees.Checked = true;
            rdo_R_FD_origin_latitude_decimal_degrees.Checked = true;
            rdo_R_FD_bearing_decimal_degrees.Checked = true;
            rdobtn_R_FD_metres.Checked = true;
            rdo_R_FD_results_format_decimal_degrees.Checked = true;
            cmbobx_R_FD_origin_longitude_cardinal.SelectedIndex = 0;
            cmbobx_R_FD_origin_latitude_cardinal.SelectedIndex = 0;

            //Set up the Rhumb Cross-Track Distance
            rdobtn_R_CTD_longitude1_decimal.Checked = true;
            rdobtn_R_CTD_latitude1_decimal.Checked = true;
            rdobtn_R_CTD_bearing1_decimal.Checked = true;
            rdobtn_R_CTD_longitude2_decimal.Checked = true;
            rdobtn_R_CTD_latitude2_decimal.Checked = true;
            rdobtn_R_CTD_bearing2_decimal.Checked = true;
            cmbobx_R_CTD_longitude1_DMS_cardinal.SelectedIndex = 0;
            cmbobx_R_CTD_latitude1_DMS_cardinal.SelectedIndex = 0;
            cmbobx_R_CTD_longitude2_DMS_cardinal.SelectedIndex = 0;
            cmbobx_R_CTD_latitude2_DMS_cardinal.SelectedIndex = 0;
            rdo_R_CTD_results_format_decimal_degrees.Checked = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_help_about_Click(object sender, EventArgs e)
        {
            var f1 = new Help_Form();
            f1.ShowDialog();
        }

        private void trkbr_GC_percentage_of_track_Scroll(object sender, EventArgs e)
        {
            lbl_GC_percentage_along_track.Text = trkbr_GC_percentage_of_track.Value + "%";
        }

        
    }
}
