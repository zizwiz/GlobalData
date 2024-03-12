using System;
using System.Reflection;
using System.Windows.Forms;
using GlobalData.Properties;

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

            rdo_FD_bearing_decimal_degrees.Checked = true;
            rdobtn_FD_metres.Checked = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
