
using System;
using System.Windows.Forms;
using CenteredMessagebox;
using GlobalData.Utils;

namespace GlobalData
{
    public partial class Form1
    {
        private void btn_clear_findDestination_output_Click(object sender, EventArgs e)
        {
            rchtxbx_findDestination_output.Text = "";
        }
        private void FD_dstance_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdobtn_FD_metres.Checked)
            {
                lbl_FD_distance_type.Text = "m";
            }
            else if (rdobtn_FD_kilometres.Checked)
            {
                lbl_FD_distance_type.Text = "km";
            }
            else if (rdobtn_FD_miles.Checked)
            {
                lbl_FD_distance_type.Text = "miles";
            }
            else if (rdobtn_FD_nauticalmiles.Checked)
            {
                lbl_FD_distance_type.Text = "nautical miles";
            }
        }
        
        private void FD_bearing_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdo_FD_bearing_decimal_degrees.Checked)
            {
                txtbx_FD_bearing_degrees.Visible = lbl_FD_bearing_degree.Visible = txtbx_FD_bearing_minutes.Visible =
                    lbl_FD_bearing_minutes.Visible = txtbx_FD_bearing_seconds.Visible =
                        lbl_FD_bearing_seconds.Visible = false;

                txtbx_FD_bearing_decimal_degrees.Visible = lbl_FD_bearing_decimaldegree.Visible = true;

            }
            else if (rdo_FD_bearing_DMS.Checked)
            {
                txtbx_FD_bearing_degrees.Visible = lbl_FD_bearing_degree.Visible = txtbx_FD_bearing_minutes.Visible =
                    lbl_FD_bearing_minutes.Visible = txtbx_FD_bearing_seconds.Visible =
                        lbl_FD_bearing_seconds.Visible = true;

                txtbx_FD_bearing_decimal_degrees.Visible = lbl_FD_bearing_decimaldegree.Visible = false;
            }
        }

        private void FD_origin_latitude_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdo_FD_origin_latitude_decimal_degrees.Checked)
            {
                txtbx_FD_origin_latitude_degrees.Visible = lbl_FD_origin_latitude_degree.Visible = txtbx_FD_origin_latitude_minutes.Visible =
                    lbl_FD_origin_latitude_minutes.Visible = txtbx_FD_origin_latitude_seconds.Visible =
                        lbl_FD_origin_latitude_seconds.Visible = false;

                txtbx_FD_origin_latitude_decimal_degrees.Visible = lbl_FD_origin_latitude_decimaldegree.Visible = true;

            }
            else if (rdo_FD_origin_latitude_DMS.Checked)
            {
                txtbx_FD_origin_latitude_degrees.Visible = lbl_FD_origin_latitude_degree.Visible = txtbx_FD_origin_latitude_minutes.Visible =
                    lbl_FD_origin_latitude_minutes.Visible = txtbx_FD_origin_latitude_seconds.Visible =
                        lbl_FD_origin_latitude_seconds.Visible = true;

                txtbx_FD_origin_latitude_decimal_degrees.Visible = lbl_FD_origin_latitude_decimaldegree.Visible = false;
            }
        }

        private void FD_origin_longitude_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdo_FD_origin_longitude_decimal_degrees.Checked)
            {
                txtbx_FD_origin_longitude_degrees.Visible = lbl_FD_origin_longitude_degree.Visible = txtbx_FD_origin_longitude_minutes.Visible =
                    lbl_FD_origin_longitude_minutes.Visible = txtbx_FD_origin_longitude_seconds.Visible =
                        lbl_FD_origin_longitude_seconds.Visible = false;

                txtbx_FD_origin_longitude_decimal_degrees.Visible = lbl_FD_origin_longitude_decimaldegree.Visible = true;

            }
            else if (rdo_FD_origin_longitude_DMS.Checked)
            {
                txtbx_FD_origin_longitude_degrees.Visible = lbl_FD_origin_longitude_degree.Visible = txtbx_FD_origin_longitude_minutes.Visible =
                    lbl_FD_origin_longitude_minutes.Visible = txtbx_FD_origin_longitude_seconds.Visible =
                        lbl_FD_origin_longitude_seconds.Visible = true;

                txtbx_FD_origin_longitude_decimal_degrees.Visible = lbl_FD_origin_longitude_decimaldegree.Visible = false;
            }
        }

        
        private void btn_GC_find_destination_Click(object sender, EventArgs e)
        {
            //Get distance and assume at this stage it is in metres
            double distance = double.Parse(txtbx_distance.Text);

            //check to see if it is in metres and if not apply multiplier
            if (rdobtn_FD_kilometres.Checked)
            {
                distance *= 1000;
            }
            else if (rdobtn_FD_miles.Checked)
            {
                distance = Convertion.toMetresFromMiles(distance);
            }
            else if (rdobtn_FD_nauticalmiles.Checked)
            {
                distance = Convertion.toMetresFromNauticalMiles(distance);
            }

            // Get the bearing into radians
            double θ = 0;
            if (rdo_FD_bearing_decimal_degrees.Checked)
            {
                θ = Convertion.toRadiansfromDecimalDegrees(txtbx_FD_bearing_decimal_degrees.Text);
            }
            else if (rdo_FD_bearing_DMS.Checked)
            {
                θ = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_FD_bearing_degrees.Text,
                        txtbx_FD_bearing_minutes.Text, txtbx_FD_bearing_seconds.Text).ToString());
            }

            // Get the origin latitude into radians
            double φ1 = 0;
            if (rdo_FD_origin_latitude_decimal_degrees.Checked)
            {
                φ1 = Convertion.toRadiansfromDecimalDegrees(txtbx_FD_origin_latitude_decimal_degrees.Text);
            }
            else if (rdo_FD_origin_latitude_DMS.Checked)
            {
                φ1 = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_FD_origin_latitude_degrees.Text,
                        txtbx_FD_origin_latitude_minutes.Text, txtbx_FD_origin_latitude_seconds.Text).ToString());
            }

            // Get the origin longitude into radians
            double λ1 = 0;
            if (rdo_FD_origin_longitude_decimal_degrees.Checked)
            {
                λ1 = Convertion.toRadiansfromDecimalDegrees(txtbx_FD_origin_longitude_decimal_degrees.Text);
            }
            else if (rdo_FD_origin_longitude_DMS.Checked)
            {
                λ1 = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_FD_origin_longitude_degrees.Text,
                        txtbx_FD_origin_longitude_minutes.Text, txtbx_FD_origin_longitude_seconds.Text).ToString());
            }
            
            //Get the angular distance in radians
            double δ = distance / _settings.EarthsRadius; // Earth radius set in settings
            
            double sinφ2 = Math.Sin(φ1) * Math.Cos(δ) + Math.Cos(φ1) * Math.Sin(δ) * Math.Cos(θ);
            double φ2 = Math.Asin(sinφ2);


            double y = Math.Sin(θ) * Math.Sin(δ) * Math.Cos(φ1);
            double x = Math.Cos(δ) - Math.Sin(φ1) * sinφ2;
            double λ2 = λ1 + Math.Atan2(y, x);

            string lat = "0";
            string lon = "0";

            if (rdo_FD_results_format_decimal_degrees.Checked)
            {
                lat = Convertion.toDegreesFromRadians(φ2).ToString();
                lon = Convertion.toDegreesFromRadians(λ2).ToString();
            }
            else if (rdo_FD_results_format_DMS.Checked)
            {
                lat = Convertion.toDegreesMinutesSecondsFromDecimalDegrees(Convertion.toDegreesFromRadians(φ2).ToString());
                lon = Convertion.toDegreesMinutesSecondsFromDecimalDegrees(Convertion.toDegreesFromRadians(λ2).ToString());
            }
            else
            {
                MsgBox.Show("Please Choose a Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            rchtxbx_findDestination_output.AppendText("Destination Latitude = " + lat + "\rDestination Longitude = " + lon + "\r");
        }



    }
}