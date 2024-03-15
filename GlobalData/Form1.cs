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
            rdo_FD_origin_longitude_decimal_degrees.Checked = true;
            rdo_FD_origin_latitude_decimal_degrees.Checked = true;
            rdo_FD_bearing_decimal_degrees.Checked = true;
            rdobtn_FD_metres.Checked = true;
            rdo_FD_results_format_decimal_degrees.Checked = true;
            cmbobx_FD_origin_longitude_cardinal.SelectedIndex = 0;
            cmbobx_FD_origin_latitude_cardinal.SelectedIndex = 0;

            //Set up the Great Circle Cross-Track Distance
            rdobtn_GC_CTD_longitude1_decimal.Checked = true;
            rdobtn_GC_CTD_latitude1_decimal.Checked = true;
            rdobtn_GC_CTD_bearing1_decimal.Checked = true;
            rdobtn_GC_CTD_longitude2_decimal.Checked = true;
            rdobtn_GC_CTD_latitude2_decimal.Checked = true;
            rdobtn_GC_CTD_bearing2_decimal.Checked = true;
            cmbobx_GC_CTD_longitude1_DSM_cardinal.SelectedIndex = 0;
            cmbobx_GC_CTD_latitude1_DSM_cardinal.SelectedIndex = 0;
            cmbobx_GC_CTD_longitude2_DSM_cardinal.SelectedIndex = 0;
            cmbobx_GC_CTD_latitude2_DSM_cardinal.SelectedIndex = 0;
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

       
    }
}
