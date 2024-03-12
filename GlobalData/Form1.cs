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

            //Set up the Great Circle Find Distance tab
            rdo_FD_origin_longitude_decimal_degrees.Checked = true;
            rdo_FD_origin_latitude_decimal_degrees.Checked = true;
            rdo_FD_bearing_decimal_degrees.Checked = true;
            rdobtn_FD_metres.Checked = true;
            rdo_FD_results_format_decimal_degrees.Checked = true;
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
