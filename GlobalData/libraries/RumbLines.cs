using System;
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


        public static (double, string, double, string) InitialBearing(string origin_longitude, string origin_latitude,
            string destination_longitude, string destination_latitude)
        {
            double π = Math.PI;

            //latitudes
            double φ1 = Convertion.toRadiansfromDecimalDegrees(origin_latitude);
            double φ2 = Convertion.toRadiansfromDecimalDegrees(destination_latitude);
            double Δλ = Convertion.toRadiansfromDecimalDegrees(destination_longitude, origin_longitude);

            // if dLon over 180° take shorter rhumb line across the anti-meridian:
            if (Math.Abs(Δλ) > π) Δλ = Δλ > 0 ? -(2 * π - Δλ) : (2 * π + Δλ);

            double Δψ = Math.Log(Math.Tan(φ2 / 2 + π / 4) / Math.Tan(φ1 / 2 + π / 4));


            double fbearing = Convertion.toDegreesFromRadians(Math.Atan2(Δλ, Δψ)); // forward bearing in degrees
            double rbearing = (fbearing + 180) % 360; // reverse bearing in degrees

            return (fbearing, HelpfulFunctions.getCardinalPointsFromDecimalDegrees(fbearing),
                rbearing, HelpfulFunctions.getCardinalPointsFromDecimalDegrees(rbearing));


        }

        public static (double, double) MidPoint(string origin_longitude, string origin_latitude,
            string destination_longitude, string destination_latitude)
        {
            double π = Math.PI;

            //latitudes
            double φ1 = Convertion.toRadiansfromDecimalDegrees(origin_latitude);
            double φ2 = Convertion.toRadiansfromDecimalDegrees(destination_latitude);

            //longitudes
            double λ1 = Convertion.toRadiansfromDecimalDegrees(origin_longitude);
            double λ2 = Convertion.toRadiansfromDecimalDegrees(destination_longitude);

            //difference in long and lat
            double Δλ = Convertion.toRadiansfromDecimalDegrees(destination_longitude, origin_longitude);


            if (Math.Abs(λ2 - λ1) > π) λ1 += 2 * π; // crossing anti-meridian

            double φ3 = (φ1 + φ2) / 2;
            double f1 = Math.Tan(π / 4 + φ1 / 2);
            double f2 = Math.Tan(π / 4 + φ2 / 2);
            double f3 = Math.Tan(π / 4 + φ3 / 2);

            double λ3 = ((λ2 - λ1) * Math.Log(f3) + λ1 * Math.Log(f2) - λ2 * Math.Log(f1)) / Math.Log(f2 / f1);

            if (!double.IsInfinity(λ3)) λ3 = (λ1 + λ2) / 2; // parallel of latitude


            double lat = Convertion.toDegreesFromRadians(φ3);
            double lon = Convertion.toDegreesFromRadians(λ3);

            return (lat, lon);

        }
    }
}
