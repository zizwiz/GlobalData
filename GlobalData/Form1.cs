using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Math = System.Math;

namespace GlobalData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
        }

        /// <summary>
        /// Haversine  formula
        /// This calculates the great-circle distance between two points – that is,
        /// the shortest distance over the earth’s surface – giving an ‘as-the-crow-flies’ distance between the points,
        /// ignoring any hills they fly over.
        ///
        /// Haversine  formula:
        /// a = sin²(Δφ/2) + cos φ1 ⋅ cos φ2 ⋅ sin²(Δλ/2)
        /// c = 2 ⋅ atan2( √a, √(1−a) )
        /// d = R ⋅ c
        /// where	φ is latitude, λ is longitude, R is earth’s radius 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_great_circle_compute_Click(object sender, EventArgs e)
        {
            rchtxbx_great_circle_results.Text = "";



            double earthsRadius = 6371000;     //earth’s radius in m (mean radius = 6371km)

            double φ1 = Double.Parse(txtbx_origin_latitude.Text) * Math.PI / 180; //latitude in radians
            double φ2 = Double.Parse(txtbx_dest_latitude.Text) * Math.PI / 180; // latitude in radians

            //difference in long and lat
            double Δφ = (Double.Parse(txtbx_dest_latitude.Text) - Double.Parse(txtbx_origin_latitude.Text)) * Math.PI / 180;
            double Δλ = (Double.Parse(txtbx_dest_longitude.Text) - Double.Parse(txtbx_origin_longitude.Text)) * Math.PI / 180;

            double a = Math.Sin(Δφ / 2) * Math.Sin(Δφ / 2) + Math.Cos(φ1) * Math.Cos(φ2) * Math.Sin(Δλ / 2) * Math.Sin(Δλ / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double  d = earthsRadius * c; // in metres

            rchtxbx_great_circle_results.AppendText(Math.Round(d, 4) + "m");
            rchtxbx_great_circle_results.AppendText("\r" + Math.Round(d/1000, 4) + "km");
        }

        private void btn_bearing_Click(object sender, EventArgs e)
        {
           // rchtxbx_great_circle_results.Text = "";

            //latitudes
            double φ1 = Double.Parse(txtbx_origin_latitude.Text) * Math.PI / 180; //latitude in radians
            double φ2 = Double.Parse(txtbx_dest_latitude.Text) * Math.PI / 180;

            //longitudes
            double λ1 = Double.Parse(txtbx_origin_longitude.Text) * Math.PI / 180; //latitude in radians
            double λ2 = Double.Parse(txtbx_dest_longitude.Text) * Math.PI / 180; //latitude in radians

            double y = Math.Sin(λ2 - λ1) * Math.Cos(φ2);
            double x = Math.Cos(φ1) * Math.Sin(φ2) - Math.Sin(φ1) * Math.Cos(φ2) * Math.Cos(λ2 - λ1);
            double θ = Math.Atan2(y, x);
            
            double fbearing = (θ * 180 / Math.PI + 360) % 360; // forward bearing in degrees
            double rbearing = (fbearing + 180) % 360; // reverse bearing in degrees

            rchtxbx_great_circle_results.AppendText("\rForward bearing = " + Math.Round(fbearing, 4) + "°\r");
            rchtxbx_great_circle_results.AppendText("Reverse bearing = " + Math.Round(rbearing, 4) + "°\r");
        }
    }
}
