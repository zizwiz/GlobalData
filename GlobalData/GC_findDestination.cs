
using System;
using System.Drawing;
using System.Windows.Forms;
using CenteredMessagebox;
using GlobalData.libraries;
using GlobalData.Utils;

namespace GlobalData
{
    public partial class Form1
    {
        private void btn_GC_clear_findDestination_output_Click(object sender, EventArgs e)
        {
            rchtxbx_GC_findDestination_output.Text = "";
        }
        private void GC_FD_dstance_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdobtn_GC_FD_metres.Checked)
            {
                lbl_GC_FD_distance_type.Text = "m";
            }
            else if (rdobtn_GC_FD_kilometres.Checked)
            {
                lbl_GC_FD_distance_type.Text = "km";
            }
            else if (rdobtn_GC_FD_miles.Checked)
            {
                lbl_GC_FD_distance_type.Text = "miles";
            }
            else if (rdobtn_GC_FD_nauticalmiles.Checked)
            {
                lbl_GC_FD_distance_type.Text = "nautical miles";
            }
        }
        
        private void GC_FD_bearing_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdo_GC_FD_bearing_decimal_degrees.Checked)
            {
                txtbx_FD_bearing_degrees.Visible = lbl_FD_bearing_degree.Visible = txtbx_FD_bearing_minutes.Visible =
                    lbl_FD_bearing_minutes.Visible = txtbx_FD_bearing_seconds.Visible =
                        lbl_FD_bearing_seconds.Visible = false;

                txtbx_FD_bearing_decimal_degrees.Visible = lbl_FD_bearing_decimaldegree.Visible = true;

            }
            else if (rdo_GC_FD_bearing_DMS.Checked)
            {
                txtbx_FD_bearing_degrees.Visible = lbl_FD_bearing_degree.Visible = txtbx_FD_bearing_minutes.Visible =
                    lbl_FD_bearing_minutes.Visible = txtbx_FD_bearing_seconds.Visible =
                        lbl_FD_bearing_seconds.Visible = true;

                txtbx_FD_bearing_decimal_degrees.Visible = lbl_FD_bearing_decimaldegree.Visible = false;
            }
        }

        private void GC_FD_origin_latitude_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdo_GC_FD_origin_latitude_decimal_degrees.Checked)
            {
                txtbx_GC_FD_origin_latitude_degrees.Visible = lbl_GC_FD_origin_latitude_degree.Visible = txtbx_GC_FD_origin_latitude_minutes.Visible =
                    lbl_GC_FD_origin_latitude_minutes.Visible = txtbx_GC_FD_origin_latitude_seconds.Visible =
                        lbl_GC_FD_origin_latitude_seconds.Visible = cmbobx_GC_FD_origin_latitude_cardinal.Visible = false;

                txtbx_GC_FD_origin_latitude_decimal_degrees.Visible = lbl_GC_FD_origin_latitude_decimaldegree.Visible = true;

            }
            else if (rdo_GC_FD_origin_latitude_DMS.Checked)
            {
                txtbx_GC_FD_origin_latitude_degrees.Visible = lbl_GC_FD_origin_latitude_degree.Visible = txtbx_GC_FD_origin_latitude_minutes.Visible =
                    lbl_GC_FD_origin_latitude_minutes.Visible = txtbx_GC_FD_origin_latitude_seconds.Visible =
                        lbl_GC_FD_origin_latitude_seconds.Visible = cmbobx_GC_FD_origin_latitude_cardinal.Visible = true;

                txtbx_GC_FD_origin_latitude_decimal_degrees.Visible = lbl_GC_FD_origin_latitude_decimaldegree.Visible = false;
            }
        }

        private void GC_FD_origin_longitude_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdo_GC_FD_origin_longitude_decimal_degrees.Checked)
            {
                txtbx_GC_FD_origin_longitude_degrees.Visible = lbl_GC_FD_origin_longitude_degree.Visible = txtbx_GC_FD_origin_longitude_minutes.Visible =
                    lbl_GC_FD_origin_longitude_minutes.Visible = txtbx_GC_FD_origin_longitude_seconds.Visible =
                        lbl_GC_FD_origin_longitude_seconds.Visible = cmbobx_GC_FD_origin_longitude_cardinal.Visible = false ;

                txtbx_GC_FD_origin_longitude_decimal_degrees.Visible = lbl_GC_FD_origin_longitude_decimaldegree.Visible = true;

            }
            else if (rdo_GC_FD_origin_longitude_DMS.Checked)
            {
                txtbx_GC_FD_origin_longitude_degrees.Visible = lbl_GC_FD_origin_longitude_degree.Visible = txtbx_GC_FD_origin_longitude_minutes.Visible =
                    lbl_GC_FD_origin_longitude_minutes.Visible = txtbx_GC_FD_origin_longitude_seconds.Visible =
                        lbl_GC_FD_origin_longitude_seconds.Visible = cmbobx_GC_FD_origin_longitude_cardinal.Visible = true;

                txtbx_GC_FD_origin_longitude_decimal_degrees.Visible = lbl_GC_FD_origin_longitude_decimaldegree.Visible = false;
            }
        }

        
        private void btn_GC_find_destination_Click(object sender, EventArgs e)
        {
            //Get distance and assume at this stage it is in metres
            double distance = double.Parse(txtbx_GC_FD_distance.Text);
            double longCardinal = 1;
            double latCardinal = 1;
            string latDestination = "0";
            string lonDestination = "0";
            string latMidpoint = "0";
            string lonMidpoint = "0";

            //check to see if it is in metres and if not apply multiplier
            if (rdobtn_GC_FD_kilometres.Checked)
            {
                distance *= 1000;
            }
            else if (rdobtn_GC_FD_miles.Checked)
            {
                distance = Convertion.toMetresFromMiles(distance);
            }
            else if (rdobtn_GC_FD_nauticalmiles.Checked)
            {
                distance = Convertion.toMetresFromNauticalMiles(distance);
            }

            // Get the bearing into radians
            double θ = 0;
            if (rdo_GC_FD_bearing_decimal_degrees.Checked)
            {
                θ = Convertion.toRadiansfromDecimalDegrees(txtbx_FD_bearing_decimal_degrees.Text);
            }
            else if (rdo_GC_FD_bearing_DMS.Checked)
            {
                θ = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_FD_bearing_degrees.Text,
                        txtbx_FD_bearing_minutes.Text, txtbx_FD_bearing_seconds.Text, longCardinal).ToString());
            }

            // Get the origin latitude into radians
            double φ1 = 0;
            if (rdo_GC_FD_origin_latitude_decimal_degrees.Checked)
            {
                φ1 = Convertion.toRadiansfromDecimalDegrees(txtbx_GC_FD_origin_latitude_decimal_degrees.Text);
            }
            else if (rdo_GC_FD_origin_latitude_DMS.Checked)
            {

                if (cmbobx_GC_FD_origin_latitude_cardinal.Text == "S") latCardinal = -1;

                φ1 = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_GC_FD_origin_latitude_degrees.Text,
                        txtbx_GC_FD_origin_latitude_minutes.Text, txtbx_GC_FD_origin_latitude_seconds.Text,
                        latCardinal).ToString());
            }

            // Get the origin longitude into radians
            double λ1 = 0;
            if (rdo_GC_FD_origin_longitude_decimal_degrees.Checked)
            {
                λ1 = Convertion.toRadiansfromDecimalDegrees(txtbx_GC_FD_origin_longitude_decimal_degrees.Text);
            }
            else if (rdo_GC_FD_origin_longitude_DMS.Checked)
            {
                if (cmbobx_GC_FD_origin_longitude_cardinal.Text == "W") longCardinal = -1;

                λ1 = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_GC_FD_origin_longitude_degrees.Text,
                        txtbx_GC_FD_origin_longitude_minutes.Text, txtbx_GC_FD_origin_longitude_seconds.Text,
                        longCardinal).ToString());
            }

            var resultDestination = GreatCircle.FindDestination(λ1, φ1, θ, distance);
            double φ2 = resultDestination.Item1;
            double λ2 = resultDestination.Item2;

            var resultMidpoint = GreatCircle.MidPoint(λ1.ToString(), φ1.ToString(), λ2.ToString(), φ2.ToString());
            double φ3 = resultMidpoint.Item1;
            double λ3 = resultMidpoint.Item2;

            if (rdo_GC_FD_results_format_decimal_degrees.Checked)
            {
                latDestination = Convertion.toDegreesFromRadians(φ2).ToString();
                lonDestination = Convertion.toDegreesFromRadians(λ2).ToString();

                latMidpoint = Convertion.toDegreesFromRadians(φ3).ToString();
                lonMidpoint = Convertion.toDegreesFromRadians(λ3).ToString();
            }
            else if (rdo_GC_FD_results_format_DMS.Checked)
            {
                latDestination = Convertion.toDegreesMinutesSecondsFromDecimalDegrees(Convertion.toDegreesFromRadians(φ2).ToString());
                lonDestination = Convertion.toDegreesMinutesSecondsFromDecimalDegrees(Convertion.toDegreesFromRadians(λ2).ToString());

                latMidpoint = Convertion.toDegreesMinutesSecondsFromDecimalDegrees(Convertion.toDegreesFromRadians(φ3).ToString());
                lonMidpoint = Convertion.toDegreesMinutesSecondsFromDecimalDegrees(Convertion.toDegreesFromRadians(λ3).ToString());

            }
            else
            {
                MsgBox.Show("Please Choose a Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            rchtxbx_GC_findDestination_output.SelectionFont = new Font(rchtxbx_GC_DBM_output.SelectionFont, FontStyle.Bold | FontStyle.Underline);
            rchtxbx_GC_findDestination_output.AppendText("Destination Co-Ordinates\r");
            rchtxbx_GC_findDestination_output.AppendText("Latitude = " + latDestination + "\rLongitude = " + lonDestination + "\r");

            rchtxbx_GC_findDestination_output.SelectionFont = new Font(rchtxbx_GC_DBM_output.SelectionFont, FontStyle.Bold | FontStyle.Underline);
            rchtxbx_GC_findDestination_output.AppendText("\rMidpoint Co-Ordinates\r");
            rchtxbx_GC_findDestination_output.AppendText("Latitude = " + latMidpoint + "\rLongitude = " + lonMidpoint + "\r");
        }
    }
}