using System;
using GlobalData.libraries;
using GlobalData.Utils;

namespace GlobalData
{
    public partial class Form1
    {

        private void btn_gc_clear_Click(object sender, EventArgs e)
        {
            rchtxbx_output.Clear();
        }

        private void btn_compute_distance_Click(object sender, EventArgs e)
        {
            Double result = GreatCircle.Distance(txtbx_origin_longitude.Text, txtbx_origin_latitude.Text,
                txtbx_dest_longitude.Text, txtbx_dest_latitude.Text);

            rchtxbx_output.AppendText("\rDistance = " + Math.Round(result, 4) + "m\r");
            rchtxbx_output.AppendText("Distance = " + Math.Round(result / 1000, 4) + "km\r");
            rchtxbx_output.AppendText("Distance = " + Math.Round(Convertion.toMilesFromMetres(result), 4) + " miles\r");
            rchtxbx_output.AppendText("Distance = " + Math.Round(Convertion.toNauticalMilesFromMetres(result), 4) + " nautical miles\r");
        }

        private void btn_initial_bearing_Click(object sender, EventArgs e)
        {

            var results = GreatCircle.InitialBearing(txtbx_origin_longitude.Text, txtbx_origin_latitude.Text,
                txtbx_dest_longitude.Text, txtbx_dest_latitude.Text);

            rchtxbx_output.AppendText("\rForward bearing decimal = " + Math.Round(results.Item1, 4) + "°");
            rchtxbx_output.AppendText("\rForward bearing dms = " + Convertion.toDegreesMinutesSecondsFromDecimalDegrees(results.Item1.ToString()) + "\r");

            rchtxbx_output.AppendText("\rReverse bearing decimal = " + GreatCircle.wrap360(Math.Round(results.Item2, 4)) + "°");
            rchtxbx_output.AppendText("\rReverse bearing dms = " + Convertion.toDegreesMinutesSecondsFromDecimalDegrees(GreatCircle.wrap360(Math.Round(results.Item2, 4)).ToString()) + "\r");
        }

        private void btn_compute_midpoint_Click(object sender, EventArgs e)
        {
            var results = GreatCircle.MidPoint(txtbx_origin_longitude.Text, txtbx_origin_latitude.Text,
                txtbx_dest_longitude.Text, txtbx_dest_latitude.Text);


            rchtxbx_output.AppendText("\rLatitude = " + Math.Round(results.Item1, 4) + "°");
            rchtxbx_output.AppendText("\rLongitude = " + Math.Round(results.Item2, 4) + "°\r");
        }


    }
}