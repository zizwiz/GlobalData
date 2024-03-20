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


        /*
        private void rdo_R_DBM_origin_decimal_degrees_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo_R_DBM_origin_DMS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo_R_DBM_destination_decimal_degrees_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdo_R_DBM_destination_DMS_CheckedChanged(object sender, EventArgs e)
        {

        }
        */

        private void btn_R_DBM_compute_distance_Click(object sender, EventArgs e)
        {

        }

        private void btn_R_DBM_compute_initial_bearing_Click(object sender, EventArgs e)
        {

        }

        private void btn_R_DBM_compute_midpoint_Click(object sender, EventArgs e)
        {

        }

        private void btn_R_DBM_compute_co_ordinate_Click(object sender, EventArgs e)
        {

        }

       



    }
}