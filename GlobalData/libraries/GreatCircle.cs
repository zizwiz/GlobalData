using System;
using GlobalData.Properties;
using GlobalData.Utils;

namespace GlobalData.libraries
{
    /*
     * This is my c# WinForms implementation of the work done by Chris Veness under MIT licence as shown below
     * For fuller explanations please do visit his websites shown below
     */
    /* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */
    /* Latitude/longitude spherical geodesy tools                         (c) Chris Veness 2002-2021  */
    /*                                                                                   MIT Licence  */
    /* www.movable-type.co.uk/scripts/latlong.html                                                    */
    /* www.movable-type.co.uk/scripts/geodesy-library.html#latlon-spherical                           */
    /* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */

    /*
     * Consistency rules
     * use
     *      lat/lon for lati­tude/longi­tude in degrees
     *      φ/λ for lati­tude/longi­tude in radians
     */

    class GreatCircle
    {

        /// <summary>
        /// Returns the distance along the surface of the earth from ‘this’ point to destination point.
        /*
         * This uses the ‘haversine’ formula to calculate the great-circle distance between two points
         * – that is, the shortest distance over the earth’s surface – giving an ‘as-the-crow-flies’ distance
         * between the points (ignoring any hills they fly over, of course).
           
           Haversine formula:
                                a = sin²(Δφ/2) + cos φ1 ⋅ cos φ2 ⋅ sin²(Δλ/2)
                                c = 2 ⋅ atan2( √a, √(1−a) )
                                d = R ⋅ c
           
            where	
                φ is latitude, 
                λ is longitude, 
                R is earth’s radius (mean radius = 6,371km);
            note that angles need to be in radians
        
            @example
        const p1 = new LatLon(52.205, 0.119);
        const p2 = new LatLon(48.857, 2.351);
        const d = p1.distanceTo(p2);       // 404.3×10³ m
        const m = p1.distanceTo(p2, 3959); // 251.2 miles
         */

        /// </summary>
        /// <param name="origin_longitude"></param>
        /// <param name="origin_latitude"></param>
        /// <param name="destination_longitude"></param>
        /// <param name="destination_latitude"></param>
        /// <returns></returns>
        public static double Distance(string origin_longitude, string origin_latitude,
                    string destination_longitude, string destination_latitude)
        {
            double earthsRadius = Settings.Default.EarthsRadius;     //earth’s radius in m (mean radius = 6371km)


            double φ1 = Convertion.toRadiansfromDecimalDegrees(origin_latitude); //latitude in radians
            double φ2 = Convertion.toRadiansfromDecimalDegrees(destination_latitude); // latitude in radians

            //difference in long and lat
            double Δφ = Convertion.toRadiansfromDecimalDegrees(destination_latitude, origin_latitude);
            double Δλ = Convertion.toRadiansfromDecimalDegrees(destination_longitude, origin_longitude);

            double a = Math.Sin(Δφ / 2) * Math.Sin(Δφ / 2) + Math.Cos(φ1) * Math.Cos(φ2) * Math.Sin(Δλ / 2) * Math.Sin(Δλ / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return earthsRadius * c; // in metres
        }




        /// <summary>
        ///  Returns the initial bearing from ‘this’ point to destination point.
        /*
         * In general, your current heading will vary as you follow a great circle path (orthodrome); the final
         * heading will differ from the initial heading by varying degrees according to distance and latitude
         * (if you were to go from say 35°N,45°E (≈ Baghdad) to 35°N,135°E (≈ Osaka), you would start on a heading
         * of 60° and end up on a heading of 120°).
         *
         * This formula is for the initial bearing (sometimes referred to as forward azimuth) which if followed in a
         * straight line along a great-circle arc will take you from the start point to the end point:1
         *
         * Formula:	θ = atan2( sin Δλ ⋅ cos φ2 , cos φ1 ⋅ sin φ2 − sin φ1 ⋅ cos φ2 ⋅ cos Δλ )
         * where	φ1,λ1 is the start point, φ2,λ2 the end point (Δλ is the difference in longitude)
         *
         * For final bearing, simply take the initial bearing from the end point to the start point and reverse it
         * using θ = (θ+180) % 360
         */

        // example
        // const p1 = new LatLon(52.205, 0.119);
        // const p2 = new LatLon(48.857, 2.351);
        // const b1 = p1.initialBearingTo(p2); // 156.2°
        /// </summary>
        /// <param name="origin_longitude"></param>
        /// <param name="origin_latitude"></param>
        /// <param name="destination_longitude"></param>
        /// <param name="destination_latitude"></param>
        /// <returns></returns>
        public static (double, string, double, string) InitialBearing(string origin_longitude, string origin_latitude,
            string destination_longitude, string destination_latitude)
        {
            //latitudes
            double φ1 = Convertion.toRadiansfromDecimalDegrees(origin_latitude);
            double φ2 = Convertion.toRadiansfromDecimalDegrees(destination_latitude);

            //longitudes
            double λ1 = Convertion.toRadiansfromDecimalDegrees(origin_longitude);
            double λ2 = Convertion.toRadiansfromDecimalDegrees(destination_longitude);

            double y = Math.Sin(λ2 - λ1) * Math.Cos(φ2);
            double x = Math.Cos(φ1) * Math.Sin(φ2) - Math.Sin(φ1) * Math.Cos(φ2) * Math.Cos(λ2 - λ1);
            double θ = Math.Atan2(y, x);

            double fbearing = (θ * 180 / Math.PI + 360) % 360; // forward bearing in degrees
            double rbearing = (fbearing + 180) % 360; // reverse bearing in degrees

            return (fbearing, HelpfulFunctions.getCardinalPointsFromDecimalDegrees(fbearing),
                rbearing, HelpfulFunctions.getCardinalPointsFromDecimalDegrees(rbearing));
        }

        /// <summary>
        /// /**
        /// * Returns the midpoint between ‘this’ point and destination point.
        /// *
        /// * @param   {LatLon} point - Latitude/longitude of destination point.
        /// * @returns {LatLon} Midpoint between this point and destination point.
        /// *
        /// * @example
        /// *   p1 = new LatLon(52.205, 0.119);
        /// *   p2 = new LatLon(48.857, 2.351);
        /// *   pMid = p1.midpointTo(p2); // 50.5363°N, 001.2746°E
        /// */
        /// </summary>
        /// <param name="origin_longitude"></param>
        /// <param name="origin_latitude"></param>
        /// <param name="destination_longitude"></param>
        /// <param name="destination_latitude"></param>
        /// <returns></returns>
        public static (double, double) MidPoint(string origin_longitude, string origin_latitude,
            string destination_longitude, string destination_latitude)
        {
            //latitudes
            double φ1 = Convertion.toRadiansfromDecimalDegrees(origin_latitude);
            double φ2 = Convertion.toRadiansfromDecimalDegrees(destination_latitude);

            //longitudes
            double λ1 = Convertion.toRadiansfromDecimalDegrees(origin_longitude);

            //difference in long and lat
            double Δλ = Convertion.toRadiansfromDecimalDegrees(destination_longitude, origin_longitude);

            // get cartesian coordinates for the two points
            double[] A = { Math.Cos(φ1), 0, Math.Sin(φ1) }; // place point A on prime meridian y=0
            double[] B = { Math.Cos(φ2) * Math.Cos(Δλ), Math.Cos(φ2) * Math.Sin(Δλ), Math.Sin(φ2) };

            // vector to midpoint is sum of vectors to two points (no need to normalise)
            double[] C = { A[0] + B[0], A[1] + B[1], A[2] + B[2] };

            double φm = Math.Atan2(C[2], Math.Sqrt(C[0] * C[0] + C[1] * C[1]));
            double λm = λ1 + Math.Atan2(C[1], C[0]);

            double lat = Convertion.toDegreesFromRadians(φm);
            double lon = Convertion.toDegreesFromRadians(λm);

            return (lat, lon);
        }


        /// <summary>
        /// Find a destination co-ordinates from start co-ordinates, bearing and distance
        /// </summary>
        /// <param name="originLongitude"></param>
        /// <param name="originLatitude"></param>
        /// <param name="bearing"></param>
        /// <param name="distance"></param>
        /// <returns>Destination as tuple double of latitude and longitude</returns>
        public static (double, double) FindDestination(double originLongitude, double originLatitude, double bearing, double distance)
        {

            double λ1 = originLongitude;
            double φ1 = originLatitude;
            double θ = bearing;

            //Get the angular distance in radians
            double δ = distance / Settings.Default.EarthsRadius; // Earth radius set in settings

            double sinφ2 = Math.Sin(φ1) * Math.Cos(δ) + Math.Cos(φ1) * Math.Sin(δ) * Math.Cos(θ);
            double φ2 = Math.Asin(sinφ2);


            double y = Math.Sin(θ) * Math.Sin(δ) * Math.Cos(φ1);
            double x = Math.Cos(δ) - Math.Sin(φ1) * sinφ2;
            double λ2 = λ1 + Math.Atan2(y, x);

            return (φ2, λ2);
        }





        //Calculate settings for altitude at destination
        /*
         * var values = MyFunction();
           var firstValue = values.Item1;
           var secondValue = values.Item2;
           var thirdValue = values.Item3;

            (string, string, string)MyFunction()

         */
    }
}
