
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
        private void btn_GC_CTD_clear_output_Click(object sender, EventArgs e)
        {
            rchtxbx_GC_CTD_output.Text = "";
        }

        private void GC_CTD_origin_longitude1_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdobtn_GC_CTD_longitude1_decimal.Checked)
            {
                txtbx_GC_CTD_longitude1_degrees.Visible = lbl_GC_CTD_longitude1_degrees.Visible =
                    txtbx_GC_CTD_longitude1_minutes.Visible = lbl_GC_CTD_longitude1_minutes.Visible =
                        txtbx_GC_CTD_longitude1_seconds.Visible = lbl_GC_CTD_longitude1_seconds.Visible =
                            cmbobx_GC_CTD_longitude1_DMS_cardinal.Visible = false;

                txtbx_GC_CTD_longitude1_decimal.Visible = lbl_GC_CTD_longitude1_decimal.Visible = true;
            }
            else
            {
                txtbx_GC_CTD_longitude1_degrees.Visible = lbl_GC_CTD_longitude1_degrees.Visible =
                    txtbx_GC_CTD_longitude1_minutes.Visible = lbl_GC_CTD_longitude1_minutes.Visible =
                        txtbx_GC_CTD_longitude1_seconds.Visible = lbl_GC_CTD_longitude1_seconds.Visible =
                            cmbobx_GC_CTD_longitude1_DMS_cardinal.Visible = true;

                txtbx_GC_CTD_longitude1_decimal.Visible = lbl_GC_CTD_longitude1_decimal.Visible = false;
            }
        }

        private void GC_CTD_origin_longitude2_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdobtn_GC_CTD_longitude2_decimal.Checked)
            {
                txtbx_GC_CTD_longitude2_degrees.Visible = lbl_GC_CTD_longitude2_degrees.Visible =
                    txtbx_GC_CTD_longitude2_minutes.Visible = lbl_GC_CTD_longitude2_minutes.Visible =
                        txtbx_GC_CTD_longitude2_seconds.Visible = lbl_GC_CTD_longitude2_seconds.Visible =
                            cmbobx_GC_CTD_longitude2_DMS_cardinal.Visible = false;

                txtbx_GC_CTD_longitude2_decimal.Visible = lbl_GC_CTD_longitude2_decimal.Visible = true;
            }
            else
            {
                txtbx_GC_CTD_longitude2_degrees.Visible = lbl_GC_CTD_longitude2_degrees.Visible =
                    txtbx_GC_CTD_longitude2_minutes.Visible = lbl_GC_CTD_longitude2_minutes.Visible =
                        txtbx_GC_CTD_longitude2_seconds.Visible = lbl_GC_CTD_longitude2_seconds.Visible =
                            cmbobx_GC_CTD_longitude2_DMS_cardinal.Visible = true;

                txtbx_GC_CTD_longitude2_decimal.Visible = lbl_GC_CTD_longitude2_decimal.Visible = false;
            }
        }

        private void GC_CTD_origin_latitude2_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdobtn_GC_CTD_latitude2_decimal.Checked)
            {
                txtbx_GC_CTD_latitude2_degrees.Visible = lbl_GC_CTD_latitude2_degrees.Visible =
                    txtbx_GC_CTD_latitude2_minutes.Visible = lbl_GC_CTD_latitude2_minutes.Visible =
                        txtbx_GC_CTD_latitude2_seconds.Visible = lbl_GC_CTD_latitude2_seconds.Visible =
                            cmbobx_GC_CTD_latitude2_DMS_cardinal.Visible = false;

                txtbx_GC_CTD_latitude2_decimal.Visible = lbl_GC_CTD_latitude2_decimal.Visible = true;

            }
            else
            {
                txtbx_GC_CTD_latitude2_degrees.Visible = lbl_GC_CTD_latitude2_degrees.Visible =
                    txtbx_GC_CTD_latitude2_minutes.Visible = lbl_GC_CTD_latitude2_minutes.Visible =
                        txtbx_GC_CTD_latitude2_seconds.Visible = lbl_GC_CTD_latitude2_seconds.Visible =
                            cmbobx_GC_CTD_latitude2_DMS_cardinal.Visible = true;

                txtbx_GC_CTD_latitude2_decimal.Visible = lbl_GC_CTD_latitude2_decimal.Visible = false;

            }
        }

        private void GC_CTD_origin_latitude1_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdobtn_GC_CTD_latitude1_decimal.Checked)
            {
                txtbx_GC_CTD_latitude1_degrees.Visible = lbl_GC_CTD_latitude1_degrees.Visible =
                    txtbx_GC_CTD_latitude1_minutes.Visible = lbl_GC_CTD_latitude1_minutes.Visible =
                        txtbx_GC_CTD_latitude1_seconds.Visible = lbl_GC_CTD_latitude1_seconds.Visible =
                            cmbobx_GC_CTD_latitude1_DMS_cardinal.Visible = false;

                txtbx_GC_CTD_latitude1_decimal.Visible = lbl_GC_CTD_latitude1_decimal.Visible = true;

            }
            else
            {
                txtbx_GC_CTD_latitude1_degrees.Visible = lbl_GC_CTD_latitude1_degrees.Visible =
                    txtbx_GC_CTD_latitude1_minutes.Visible = lbl_GC_CTD_latitude1_minutes.Visible =
                        txtbx_GC_CTD_latitude1_seconds.Visible = lbl_GC_CTD_latitude1_seconds.Visible =
                            cmbobx_GC_CTD_latitude1_DMS_cardinal.Visible = true;

                txtbx_GC_CTD_latitude1_decimal.Visible = lbl_GC_CTD_latitude1_decimal.Visible = false;

            }
        }

        private void GC_CTD_origin_bearing1_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdobtn_GC_CTD_bearing1_decimal.Checked)
            {
                txtbx_GC_CTD_bearing1_degrees.Visible = lbl_GC_CTD_bearing1_degrees.Visible =
                    txtbx_GC_CTD_bearing1_minutes.Visible = lbl_GC_CTD_bearing1_minutes.Visible =
                        txtbx_GC_CTD_bearing1_seconds.Visible = lbl_GC_CTD_bearing1_seconds.Visible = false;

                txtbx_GC_CTD_bearing1_decimal.Visible = lbl_GC_CTD_bearing1_decimal.Visible = true;
            }
            else
            {
                txtbx_GC_CTD_bearing1_degrees.Visible = lbl_GC_CTD_bearing1_degrees.Visible =
                    txtbx_GC_CTD_bearing1_minutes.Visible = lbl_GC_CTD_bearing1_minutes.Visible =
                        txtbx_GC_CTD_bearing1_seconds.Visible = lbl_GC_CTD_bearing1_seconds.Visible = true;

                txtbx_GC_CTD_bearing1_decimal.Visible = lbl_GC_CTD_bearing1_decimal.Visible = false;
            }
        }

        private void GC_CTD_origin_bearing2_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdobtn_GC_CTD_bearing2_decimal.Checked)
            {
                txtbx_GC_CTD_bearing2_degrees.Visible = lbl_GC_CTD_bearing2_degrees.Visible =
                    txtbx_GC_CTD_bearing2_minutes.Visible = lbl_GC_CTD_bearing2_minutes.Visible =
                        txtbx_GC_CTD_bearing2_seconds.Visible = lbl_GC_CTD_bearing2_seconds.Visible = false;

                txtbx_GC_CTD_bearing2_decimal.Visible = lbl_GC_CTD_bearing2_decimal.Visible = true;
            }
            else
            {
                txtbx_GC_CTD_bearing2_degrees.Visible = lbl_GC_CTD_bearing2_degrees.Visible =
                    txtbx_GC_CTD_bearing2_minutes.Visible = lbl_GC_CTD_bearing2_minutes.Visible =
                        txtbx_GC_CTD_bearing2_seconds.Visible = lbl_GC_CTD_bearing2_seconds.Visible = true;

                txtbx_GC_CTD_bearing2_decimal.Visible = lbl_GC_CTD_bearing2_decimal.Visible = false;
            }
        }

        private void btn_GC_CTD_compute_intersection_Click(object sender, EventArgs e)
        {
            string lat = "";
            string lon = "";
            double φ3 = 0;
            double λ3 = 0;

            // Get the bearing into radians
            double θ1 = 0;
            double Cardinal = 1;
            if (rdobtn_GC_CTD_bearing1_decimal.Checked)
            {
                θ1 = Convertion.toRadiansfromDecimalDegrees(txtbx_GC_CTD_bearing1_decimal.Text);
            }
            else if (rdobtn_GC_CTD_bearing1_DMS.Checked)
            {
                θ1 = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_GC_CTD_bearing1_degrees.Text,
                        txtbx_GC_CTD_bearing1_minutes.Text, txtbx_GC_CTD_bearing1_seconds.Text, Cardinal).ToString());
            }



            // Get the origin latitude into radians
            double φ1 = 0;
            Cardinal = 1;
            if (rdobtn_GC_CTD_latitude1_decimal.Checked)
            {
                φ1 = Convertion.toRadiansfromDecimalDegrees(txtbx_GC_CTD_latitude1_decimal.Text);
            }
            else if (rdobtn_GC_CTD_latitude1_DMS.Checked)
            {

                if (cmbobx_GC_CTD_latitude1_DMS_cardinal.Text == "S") Cardinal = -1;

                φ1 = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_GC_CTD_latitude1_degrees.Text,
                        txtbx_GC_CTD_latitude1_minutes.Text, txtbx_GC_CTD_latitude1_seconds.Text,
                        Cardinal).ToString());
            }

            // Get the origin longitude into radians
            double λ1 = 0;
            Cardinal = 1;
            if (rdobtn_GC_CTD_longitude1_decimal.Checked)
            {
                λ1 = Convertion.toRadiansfromDecimalDegrees(txtbx_GC_CTD_longitude1_decimal.Text);
            }
            else if (rdobtn_GC_CTD_longitude1_DMS.Checked)
            {
                if (cmbobx_GC_CTD_longitude1_DMS_cardinal.Text == "W") Cardinal = -1;

                λ1 = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_GC_CTD_longitude1_degrees.Text,
                        txtbx_GC_CTD_longitude1_minutes.Text, txtbx_GC_CTD_longitude1_seconds.Text,
                        Cardinal).ToString());
            }

            // Get the bearing into radians
            double θ2 = 0;
            Cardinal = 1;
            if (rdobtn_GC_CTD_bearing2_decimal.Checked)
            {
                θ2 = Convertion.toRadiansfromDecimalDegrees(txtbx_GC_CTD_bearing2_decimal.Text);
            }
            else if (rdobtn_GC_CTD_bearing2_DMS.Checked)
            {
                θ2 = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_GC_CTD_bearing2_degrees.Text,
                        txtbx_GC_CTD_bearing2_minutes.Text, txtbx_GC_CTD_bearing2_seconds.Text, Cardinal).ToString());
            }



            // Get the origin latitude into radians
            double φ2 = 0;
            Cardinal = 1;
            if (rdobtn_GC_CTD_latitude2_decimal.Checked)
            {
                φ2 = Convertion.toRadiansfromDecimalDegrees(txtbx_GC_CTD_latitude2_decimal.Text);
            }
            else if (rdobtn_GC_CTD_latitude2_DMS.Checked)
            {

                if (cmbobx_GC_CTD_latitude2_DMS_cardinal.Text == "S") Cardinal = -1;

                φ2 = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_GC_CTD_latitude2_degrees.Text,
                        txtbx_GC_CTD_latitude2_minutes.Text, txtbx_GC_CTD_latitude2_seconds.Text,
                        Cardinal).ToString());
            }

            // Get the origin longitude into radians
            double λ2 = 0;
            Cardinal = 1;
            if (rdobtn_GC_CTD_longitude2_decimal.Checked)
            {
                λ2 = Convertion.toRadiansfromDecimalDegrees(txtbx_GC_CTD_longitude2_decimal.Text);
            }
            else if (rdobtn_GC_CTD_longitude2_DMS.Checked)
            {
                if (cmbobx_GC_CTD_longitude2_DMS_cardinal.Text == "W") Cardinal = -1;

                λ2 = Convertion.toRadiansfromDecimalDegrees(
                    Convertion.toDecimalDegreesFromDMS(txtbx_GC_CTD_longitude2_degrees.Text,
                        txtbx_GC_CTD_longitude2_minutes.Text, txtbx_GC_CTD_longitude2_seconds.Text,
                        Cardinal).ToString());
            }

            var intersectionPoint = GreatCircle.FindIntersectionOfTwoPaths(λ1, φ1, θ1, λ2, φ2, θ2);

            if (intersectionPoint.Item1 == 999)
            {
                // infinite intersections 
                rchtxbx_GC_CTD_output.SelectionFont = new Font(rchtxbx_GC_CTD_output.SelectionFont, FontStyle.Bold | FontStyle.Underline);
                rchtxbx_GC_CTD_output.AppendText("The two paths never cross\r");
            }
            else if (intersectionPoint.Item1 == 998)
            {
                // ambiguous intersection (antipodal/360°) 
                rchtxbx_GC_CTD_output.SelectionFont = new Font(rchtxbx_GC_CTD_output.SelectionFont, FontStyle.Bold | FontStyle.Underline);
                rchtxbx_GC_CTD_output.AppendText("The two paths are dynamically opposed and will never meet\r");

            }
            else if (intersectionPoint.Item1 == 997)
            {
                // coincident (Same) points
                rchtxbx_GC_CTD_output.SelectionFont = new Font(rchtxbx_GC_CTD_output.SelectionFont, FontStyle.Bold | FontStyle.Underline);
                rchtxbx_GC_CTD_output.AppendText("The two paths are coincident (Same)\r");
            }
            else
            {
                φ3 = intersectionPoint.Item1; //latitude
                λ3 = intersectionPoint.Item2; //longitude

                if (rdo_GC_CTD_results_format_decimal_degrees.Checked)
                {
                    lat = Convertion.toDegreesFromRadians(φ3).ToString();
                    lon = Convertion.toDegreesFromRadians(λ3).ToString();
                }
                else if (rdo_CG_CTD_results_format_DMS.Checked)
                {
                    lat = Convertion.toDegreesMinutesSecondsFromDecimalDegrees(Convertion.toDegreesFromRadians(φ3)
                        .ToString());
                    lon = Convertion.toDegreesMinutesSecondsFromDecimalDegrees(Convertion.toDegreesFromRadians(λ3)
                        .ToString());
                }
                else
                {
                    MsgBox.Show("Please Choose a Format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                rchtxbx_GC_CTD_output.SelectionFont = new Font(rchtxbx_GC_CTD_output.SelectionFont, FontStyle.Bold | FontStyle.Underline);
                rchtxbx_GC_CTD_output.AppendText("The two paths cross at:\r");
                rchtxbx_GC_CTD_output.AppendText("Latitude = " + lat + "\rLongitude = " + lon + "\r");
            }
        }





    }

}