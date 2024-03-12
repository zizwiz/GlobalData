
using System;
using GlobalData.Utils;

namespace GlobalData
{
    public partial class Form1
    {
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

        private void btn_GC_find_destination_Click(object sender, EventArgs e)
        {
            /*
             * /**
               * Returns the destination point from ‘this’ point having travelled the given distance on the
               * given initial bearing (bearing normally varies around path followed).
               *
               * @param   {number} distance - Distance travelled, in same units as earth radius (default: metres).
               * @param   {number} bearing - Initial bearing in degrees from north.
               * @param   {number} [radius=6371e3] - (Mean) radius of earth (defaults to radius in metres).
               * @returns {LatLon} Destination point.
               *
               * @example
               *   const p1 = new LatLon(51.47788, -0.00147);
               *   const p2 = p1.destinationPoint(7794, 300.7); // 51.5136°N, 000.0983°W
               * /
               destinationPoint(distance, bearing, radius=6371e3) {
               // sinφ2 = sinφ1⋅cosδ + cosφ1⋅sinδ⋅cosθ
               // tanΔλ = sinθ⋅sinδ⋅cosφ1 / cosδ−sinφ1⋅sinφ2
               // see mathforum.org/library/drmath/view/52049.html for derivation
               
               const δ = distance / radius; // angular distance in radians
               const θ = Number(bearing).toRadiansfromDecimalDegrees();
               
               const φ1 = this.lat.toRadiansfromDecimalDegrees(), λ1 = this.lon.toRadiansfromDecimalDegrees();
               
               const sinφ2 = Math.sin(φ1) * Math.cos(δ) + Math.cos(φ1) * Math.sin(δ) * Math.cos(θ);
               const φ2 = Math.asin(sinφ2);
               const y = Math.sin(θ) * Math.sin(δ) * Math.cos(φ1);
               const x = Math.cos(δ) - Math.sin(φ1) * sinφ2;
               const λ2 = λ1 + Math.atan2(y, x);
               
               const lat = φ2.toDegreesFromRadians();
               const lon = λ2.toDegreesFromRadians();
               
               return new LatLonSpherical(lat, lon);
               }
               
            */

            //Get distance and assume at this stage it is in metres
            double distance = double.Parse(txtbx_distance.Text);

            //check to see if it is not in metres and if not apply multiplier
            if (rdobtn_FD_kilometres.Checked)
            {
                distance = distance * 1000;
            }
            else if (rdobtn_FD_miles.Checked)
            {
                distance = Convertion.toMetresFromMiles(distance);
            }
            else if (rdobtn_FD_nauticalmiles.Checked)
            {
                distance = Convertion.toMetresFromNauticalMiles(distance);
            }

            // Get earths radius from settings
            double EarthsRadius = _settings.EarthsRadius;
           


            //work out maths
            double δ = distance / EarthsRadius; // angular distance in radians
            double θ = Convertion.toRadiansfromDecimalDegrees(txtbx_FD_bearing_decimal_degrees.Text);

            double φ1 = Convertion.toRadiansfromDecimalDegrees(txtbx_origin_latitude2.Text);
            double λ1 = Convertion.toRadiansfromDecimalDegrees(txtbx_origin_longitude2.Text);

            double sinφ2 = Math.Sin(φ1) * Math.Cos(δ) + Math.Cos(φ1) * Math.Sin(δ) * Math.Cos(θ);
            double φ2 = Math.Asin(sinφ2);


            double y = Math.Sin(θ) * Math.Sin(δ) * Math.Cos(φ1);
            double x = Math.Cos(δ) - Math.Sin(φ1) * sinφ2;
            double λ2 = λ1 + Math.Atan2(y, x);

            double lat = Convertion.toDegreesFromRadians(φ2);
            double lon = Convertion.toDegreesFromRadians(λ2);



            rchtxbx_findDestination_output.AppendText(lat + "\r" + lon + "\r");

        }



    }
}