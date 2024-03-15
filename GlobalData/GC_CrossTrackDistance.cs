
using System;

namespace GlobalData
{
    public partial class Form1
    {
        private void GC_CTD_origin_longitude1_rdobtn_changed(object sender, EventArgs e)
        {
            if (rdobtn_GC_CTD_longitude1_decimal.Checked)
            {
                txtbx_GC_CTD_longitude1_degrees.Visible = lbl_GC_CTD_longitude1_degrees.Visible =
                    txtbx_GC_CTD_longitude1_minutes.Visible = lbl_GC_CTD_longitude1_minutes.Visible =
                        txtbx_GC_CTD_longitude1_seconds.Visible = lbl_GC_CTD_longitude1_seconds.Visible =
                            cmbobx_GC_CTD_longitude1_DSM_cardinal.Visible = false;

                txtbx_GC_CTD_longitude1_decimal.Visible = lbl_GC_CTD_longitude1_decimal.Visible = true;
            }
            else
            {
                txtbx_GC_CTD_longitude1_degrees.Visible = lbl_GC_CTD_longitude1_degrees.Visible =
                    txtbx_GC_CTD_longitude1_minutes.Visible = lbl_GC_CTD_longitude1_minutes.Visible =
                        txtbx_GC_CTD_longitude1_seconds.Visible = lbl_GC_CTD_longitude1_seconds.Visible =
                            cmbobx_GC_CTD_longitude1_DSM_cardinal.Visible = true;

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
                            cmbobx_GC_CTD_longitude2_DSM_cardinal.Visible = false;

                txtbx_GC_CTD_longitude2_decimal.Visible = lbl_GC_CTD_longitude2_decimal.Visible = true;
            }
            else
            {
                txtbx_GC_CTD_longitude2_degrees.Visible = lbl_GC_CTD_longitude2_degrees.Visible =
                    txtbx_GC_CTD_longitude2_minutes.Visible = lbl_GC_CTD_longitude2_minutes.Visible =
                        txtbx_GC_CTD_longitude2_seconds.Visible = lbl_GC_CTD_longitude2_seconds.Visible =
                            cmbobx_GC_CTD_longitude2_DSM_cardinal.Visible = true;

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
                            cmbobx_GC_CTD_latitude2_DSM_cardinal.Visible = false;

                txtbx_GC_CTD_latitude2_decimal.Visible = lbl_GC_CTD_latitude2_decimal.Visible = true;

            }
            else
            {
                txtbx_GC_CTD_latitude2_degrees.Visible = lbl_GC_CTD_latitude2_degrees.Visible = 
                    txtbx_GC_CTD_latitude2_minutes.Visible = lbl_GC_CTD_latitude2_minutes.Visible = 
                        txtbx_GC_CTD_latitude2_seconds.Visible = lbl_GC_CTD_latitude2_seconds.Visible = 
                            cmbobx_GC_CTD_latitude2_DSM_cardinal.Visible = true;

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
                            cmbobx_GC_CTD_latitude1_DSM_cardinal.Visible = false;

                txtbx_GC_CTD_latitude1_decimal.Visible = lbl_GC_CTD_latitude1_decimal.Visible = true;

            }
            else
            {
                txtbx_GC_CTD_latitude1_degrees.Visible = lbl_GC_CTD_latitude1_degrees.Visible = 
                    txtbx_GC_CTD_latitude1_minutes.Visible = lbl_GC_CTD_latitude1_minutes.Visible = 
                        txtbx_GC_CTD_latitude1_seconds.Visible = lbl_GC_CTD_latitude1_seconds.Visible = 
                            cmbobx_GC_CTD_latitude1_DSM_cardinal.Visible = true;

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


    }

}