using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalData.Properties;
using GlobalData.Utils;

namespace GlobalData.libraries
{
    class RumbLines
    {

        public static double Distance(string origin_longitude, string origin_latitude,
            string destination_longitude, string destination_latitude)
        {
            double earthsRadius = Settings.Default.EarthsRadius; //earth’s radius in m (mean radius = 6371km)


            double φ1 = Convertion.toRadiansfromDecimalDegrees(origin_latitude); //latitude in radians
            double φ2 = Convertion.toRadiansfromDecimalDegrees(destination_latitude); // latitude in radians

            //difference in long and lat
            double Δφ = Convertion.toRadiansfromDecimalDegrees(destination_latitude, origin_latitude);
            double Δλ = Math.Abs(Convertion.toRadiansfromDecimalDegrees(destination_longitude, origin_longitude));

            double π = Math.PI;

            // if destination_longitude over 180° take shorter rhumb line across the anti-meridian:
            if (Math.Abs(Δλ) > π) Δλ = Δλ > 0 ? -(2 * π - Δλ) : (2 * π + Δλ);

            // on Mercator projection, longitude distances shrink by latitude; q is the 'stretch factor'
            // q becomes ill-conditioned along E-W line (0/0); use empirical tolerance to avoid it (note ε is too small)
            double Δψ = Math.Log(Math.Tan(φ2 / 2 + π / 4) / Math.Tan(φ1 / 2 + π / 4));
            double q = Math.Abs(Δψ) > 10e-12 ? Δφ / Δψ : Math.Cos(φ1);

            // distance is pythagoras on 'stretched' Mercator projection, √(Δφ² + q²·Δλ²)
            double δ = Math.Sqrt(Δφ * Δφ + q * q * Δλ * Δλ); // angular distance in radians
            


            return earthsRadius * δ; // in metres
        }








    }
    }
