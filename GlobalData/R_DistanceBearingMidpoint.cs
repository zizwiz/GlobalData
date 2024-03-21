using System;
using System.Drawing;
using GlobalData.libraries;
using GlobalData.Utils;

namespace GlobalData
{
    public partial class Form1
    {
        /// <summary>
        /// Clear Data from the Rhumb DBM richtextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_R_DBM_clear_Click(object sender, EventArgs e)
        {
            rchtxbx_R_DBM_output.Clear();
        }

        /// <summary>
        /// Change input format of origin co-ordinates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void R_DBM_Origin_CheckChanged(object sender, EventArgs e)
        {
            if (rdo_R_DBM_origin_decimal_degrees.Checked)
            {
                txtbx_R_DBM_origin_latitude_degrees.Visible = lbl_R_DBM_origin_latitude_degrees.Visible =
                    txtbx_R_DBM_origin_latitude_minutes.Visible = lbl_R_DBM_origin_latitude_minutes.Visible =
                        txtbx_R_DBM_origin_latitude_seconds.Visible = lbl_R_DBM_origin_latitude_seconds.Visible =
                            txtbx_R_DBM_origin_longitude_degrees.Visible = lbl_R_DBM_origin_longitude_degrees.Visible =
                                txtbx_R_DBM_origin_longitude_minutes.Visible = lbl_R_DBM_origin_longtude_minutes.Visible =
                                    txtbx_R_DBM_origin_longitude_seconds.Visible = lbl_R_DBM_origin_longtude_seconds.Visible =
                                        cmbobx_R_DBM_origin_longitude_cardinal.Visible = cmbobx_R_DBM_origin_latitude_cardinal.Visible = false;

                txtbx_R_DBM_origin_latitude_decimal.Visible = lbl_R_DBM_origin_latitude_decimal.Visible =
                    txtbx_R_DBM_origin_longitude_decimal.Visible = lbl_R_DBM_origin_longitude_decimal.Visible = true;

            }
            else
            {
                txtbx_R_DBM_origin_latitude_degrees.Visible = lbl_R_DBM_origin_latitude_degrees.Visible =
                    txtbx_R_DBM_origin_latitude_minutes.Visible = lbl_R_DBM_origin_latitude_minutes.Visible =
                        txtbx_R_DBM_origin_latitude_seconds.Visible = lbl_R_DBM_origin_latitude_seconds.Visible =
                            txtbx_R_DBM_origin_longitude_degrees.Visible = lbl_R_DBM_origin_longitude_degrees.Visible =
                                txtbx_R_DBM_origin_longitude_minutes.Visible = lbl_R_DBM_origin_longtude_minutes.Visible =
                                    txtbx_R_DBM_origin_longitude_seconds.Visible = lbl_R_DBM_origin_longtude_seconds.Visible =
                                        cmbobx_R_DBM_origin_longitude_cardinal.Visible = cmbobx_R_DBM_origin_latitude_cardinal.Visible = true;

                txtbx_R_DBM_origin_latitude_decimal.Visible = lbl_R_DBM_origin_latitude_decimal.Visible =
                    txtbx_R_DBM_origin_longitude_decimal.Visible = lbl_R_DBM_origin_longitude_decimal.Visible = false;

            }
        }

        /// <summary>
        /// Change input format of destination co-ordinates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void R_DBM_Destination_CheckChanged(object sender, EventArgs e)
        {
            if (rdo_R_DBM_destination_decimal_degrees.Checked)
            {
                txtbx_R_DBM_destination_latitude_degrees.Visible = lbl_R_DBM_destination_latitude_degrees.Visible =
                    txtbx_R_DBM_destination_latitude_minutes.Visible = lbl_R_DBM_destination_latitude_minutes.Visible =
                        txtbx_R_DBM_destination_latitude_seconds.Visible = lbl_R_DBM_destination_latitude_seconds.Visible =
                            txtbx_R_DBM_destination_longitude_degrees.Visible = lbl_R_DBM_destination_longitude_degrees.Visible =
                                txtbx_R_DBM_destination_longitude_minutes.Visible = lbl_R_DBM_destination_longtude_minutes.Visible =
                                    txtbx_R_DBM_destination_longitude_seconds.Visible = lbl_R_DBM_destination_longtude_seconds.Visible =
                                        cmbobx_R_DBM_destination_longitude_cardinal.Visible = cmbobx_R_DBM_destination_latitude_cardinal.Visible = false;

                txtbx_R_DBM_destination_latitude_decimal.Visible = lbl_R_DBM_destination_latitude_decimal.Visible =
                    txtbx_R_DBM_destination_longitude_decimal.Visible =
                        lbl_R_DBM_destination_longitude_decimal.Visible = true;

            }
            else
            {
                txtbx_R_DBM_destination_latitude_degrees.Visible = lbl_R_DBM_destination_latitude_degrees.Visible =
                    txtbx_R_DBM_destination_latitude_minutes.Visible = lbl_R_DBM_destination_latitude_minutes.Visible =
                        txtbx_R_DBM_destination_latitude_seconds.Visible = lbl_R_DBM_destination_latitude_seconds.Visible =
                            txtbx_R_DBM_destination_longitude_degrees.Visible = lbl_R_DBM_destination_longitude_degrees.Visible =
                                txtbx_R_DBM_destination_longitude_minutes.Visible = lbl_R_DBM_destination_longtude_minutes.Visible =
                                    txtbx_R_DBM_destination_longitude_seconds.Visible = lbl_R_DBM_destination_longtude_seconds.Visible =
                                        cmbobx_R_DBM_destination_longitude_cardinal.Visible = cmbobx_R_DBM_destination_latitude_cardinal.Visible = true;

                txtbx_R_DBM_destination_latitude_decimal.Visible = lbl_R_DBM_destination_latitude_decimal.Visible =
                    txtbx_R_DBM_destination_longitude_decimal.Visible =
                        lbl_R_DBM_destination_longitude_decimal.Visible = false;
            }
        }


        /// <summary>
        /// Find distance between two co-ordinates using Great Circle methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_R_DBM_compute_distance_Click(object sender, EventArgs e)
        {

            string originLongitude = "0";
            string originLatitude = "0";
            string destinationLongitude = " 0";
            string destinationLatitude = "0";
            double longCardinal = 1;
            double latCardinal = 1;

            if (rdo_R_DBM_origin_decimal_degrees.Checked)
            {
                originLongitude = txtbx_R_DBM_origin_longitude_decimal.Text;
                originLatitude = txtbx_R_DBM_origin_latitude_decimal.Text;
            }
            else
            {
                if (cmbobx_R_DBM_origin_latitude_cardinal.Text == "S") longCardinal = -1;
                originLatitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_origin_latitude_degrees.Text, txtbx_R_DBM_origin_latitude_minutes.Text, txtbx_R_DBM_origin_latitude_seconds.Text, longCardinal).ToString();

                if (cmbobx_R_DBM_origin_longitude_cardinal.Text == "W") longCardinal = -1;
                originLongitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_origin_longitude_degrees.Text, txtbx_R_DBM_origin_longitude_minutes.Text, txtbx_R_DBM_origin_longitude_seconds.Text, longCardinal).ToString();
            }

            if (rdo_R_DBM_destination_decimal_degrees.Checked)
            {
                destinationLongitude = txtbx_R_DBM_destination_longitude_decimal.Text;
                destinationLatitude = txtbx_R_DBM_destination_latitude_decimal.Text;
            }
            else
            {
                if (cmbobx_R_DBM_destination_latitude_cardinal.Text == "S") longCardinal = -1;
                destinationLatitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_destination_latitude_degrees.Text, txtbx_R_DBM_destination_latitude_minutes.Text, txtbx_R_DBM_destination_latitude_seconds.Text, longCardinal).ToString();

                if (cmbobx_R_DBM_destination_longitude_cardinal.Text == "W") longCardinal = -1;
                destinationLongitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_destination_longitude_degrees.Text, txtbx_R_DBM_destination_longitude_minutes.Text, txtbx_R_DBM_destination_longitude_seconds.Text, longCardinal).ToString();
            }
            
            double result = RumbLines.Distance(originLongitude, originLatitude,
                destinationLongitude, destinationLatitude);

            rchtxbx_R_DBM_output.SelectionFont = new Font(rchtxbx_R_DBM_output.SelectionFont, FontStyle.Bold | FontStyle.Underline);
            rchtxbx_R_DBM_output.AppendText("\rDistance\r");

            rchtxbx_R_DBM_output.AppendText("Distance = " + Math.Round(result, 4) + "m\r");
            rchtxbx_R_DBM_output.AppendText("Distance = " + Math.Round(result / 1000, 4) + "km\r");
            rchtxbx_R_DBM_output.AppendText("Distance = " + Math.Round(Convertion.toMilesFromMetres(result), 4) + " miles\r");
            rchtxbx_R_DBM_output.AppendText("Distance = " + Math.Round(Convertion.toNauticalMilesFromMetres(result), 4) + " nautical miles\r");

        }

        /// <summary>
        /// Find the initial bearing to set to go from Original co-ordinates to destination co-ordinates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_R_DBM_compute_initial_bearing_Click(object sender, EventArgs e)
        {
            string originLongitude = "0";
            string originLatitude = "0";
            string destinationLongitude = " 0";
            string destinationLatitude = "0";
            double longCardinal = 1;
            double latCardinal = 1;

            if (rdo_R_DBM_origin_decimal_degrees.Checked)
            {
                originLongitude = txtbx_R_DBM_origin_longitude_decimal.Text;
                originLatitude = txtbx_R_DBM_origin_latitude_decimal.Text;
            }
            else
            {
                if (cmbobx_R_DBM_origin_latitude_cardinal.Text == "S") longCardinal = -1;
                originLatitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_origin_latitude_degrees.Text, txtbx_R_DBM_origin_latitude_minutes.Text, txtbx_R_DBM_origin_latitude_seconds.Text, longCardinal).ToString();

                if (cmbobx_R_DBM_origin_longitude_cardinal.Text == "W") longCardinal = -1;
                originLongitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_origin_longitude_degrees.Text, txtbx_R_DBM_origin_longitude_minutes.Text, txtbx_R_DBM_origin_longitude_seconds.Text, longCardinal).ToString();
            }

            if (rdo_R_DBM_destination_decimal_degrees.Checked)
            {
                destinationLongitude = txtbx_R_DBM_destination_longitude_decimal.Text;
                destinationLatitude = txtbx_R_DBM_destination_latitude_decimal.Text;
            }
            else
            {
                if (cmbobx_R_DBM_destination_latitude_cardinal.Text == "S") longCardinal = -1;
                destinationLatitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_destination_latitude_degrees.Text, txtbx_R_DBM_destination_latitude_minutes.Text, txtbx_R_DBM_destination_latitude_seconds.Text, longCardinal).ToString();

                if (cmbobx_R_DBM_destination_longitude_cardinal.Text == "W") longCardinal = -1;
                destinationLongitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_destination_longitude_degrees.Text, txtbx_R_DBM_destination_longitude_minutes.Text, txtbx_R_DBM_destination_longitude_seconds.Text, longCardinal).ToString();
            }

            var results = RumbLines.InitialBearing(originLongitude, originLatitude,
                destinationLongitude, destinationLatitude);

            rchtxbx_R_DBM_output.SelectionFont = new Font(rchtxbx_GC_DBM_output.SelectionFont, FontStyle.Bold | FontStyle.Underline);
            rchtxbx_R_DBM_output.AppendText("\rBearing\r");

            rchtxbx_R_DBM_output.AppendText("Forward bearing decimal = " + Math.Round(results.Item1, 4) + "° " + results.Item2);
            rchtxbx_R_DBM_output.AppendText("\rForward bearing dms = " + Convertion.toDegreesMinutesSecondsFromDecimalDegrees(results.Item1.ToString()) + " " + results.Item2 + "\r");

            rchtxbx_R_DBM_output.AppendText("\rReverse bearing decimal = " + HelpfulFunctions.UnWrap360(Math.Round(results.Item3, 4)) + "° " + results.Item4);
            rchtxbx_R_DBM_output.AppendText("\rReverse bearing dms = " + Convertion.toDegreesMinutesSecondsFromDecimalDegrees(HelpfulFunctions.UnWrap360(Math.Round(results.Item3, 4)).ToString()) + " " + results.Item4 + "\r");
        }

        /// <summary>
        /// Find midpoint between origin and destination co-ordinates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_R_DBM_compute_midpoint_Click(object sender, EventArgs e)
        {
            string originLongitude = "0";
                string originLatitude = "0";
                string destinationLongitude = " 0";
                string destinationLatitude = "0";
                double longCardinal = 1;
                double latCardinal = 1;

                if (rdo_R_DBM_origin_decimal_degrees.Checked)
                {
                    originLongitude = txtbx_R_DBM_origin_longitude_decimal.Text;
                    originLatitude = txtbx_R_DBM_origin_latitude_decimal.Text;
                }
                else
                {
                    if (cmbobx_R_DBM_origin_latitude_cardinal.Text == "S") longCardinal = -1;
                    originLatitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_origin_latitude_degrees.Text, txtbx_R_DBM_origin_latitude_minutes.Text, txtbx_R_DBM_origin_latitude_seconds.Text, longCardinal).ToString();

                    if (cmbobx_R_DBM_origin_longitude_cardinal.Text == "W") longCardinal = -1;
                    originLongitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_origin_longitude_degrees.Text, txtbx_R_DBM_origin_longitude_minutes.Text, txtbx_R_DBM_origin_longitude_seconds.Text, longCardinal).ToString();
                }

                if (rdo_R_DBM_destination_decimal_degrees.Checked)
                {
                    destinationLongitude = txtbx_R_DBM_destination_longitude_decimal.Text;
                    destinationLatitude = txtbx_R_DBM_destination_latitude_decimal.Text;
                }
                else
                {
                    if (cmbobx_R_DBM_destination_latitude_cardinal.Text == "S") longCardinal = -1;
                    destinationLatitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_destination_latitude_degrees.Text, txtbx_R_DBM_destination_latitude_minutes.Text, txtbx_R_DBM_destination_latitude_seconds.Text, longCardinal).ToString();

                    if (cmbobx_R_DBM_destination_longitude_cardinal.Text == "W") longCardinal = -1;
                    destinationLongitude = Convertion.toDecimalDegreesFromDMS(txtbx_R_DBM_destination_longitude_degrees.Text, txtbx_R_DBM_destination_longitude_minutes.Text, txtbx_R_DBM_destination_longitude_seconds.Text, longCardinal).ToString();
                }

                var results = GreatCircle.MidPoint(originLongitude, originLatitude,
                    destinationLongitude, destinationLatitude);

                rchtxbx_R_DBM_output.SelectionFont = new Font(rchtxbx_R_DBM_output.SelectionFont, FontStyle.Bold | FontStyle.Underline);
                rchtxbx_R_DBM_output.AppendText("\rMidpoint\r");

                rchtxbx_R_DBM_output.AppendText("Latitude = " + Math.Round(results.Item1, 4) + "°");
                rchtxbx_R_DBM_output.AppendText("\rLongitude = " + Math.Round(results.Item2, 4) + "°\r");
            
        }

        

    }
}