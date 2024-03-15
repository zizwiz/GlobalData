using System;
using GlobalData.Properties;
using GlobalData.Utils;

namespace GlobalData.libraries
{
    /* ===============================================================================================*/
    /* This is my c# WinForms implementation of the work done by Chris Veness under MIT license       */
    /* and Ed Williams see links below                                                                */
    /* For fuller explanations please do visit his websites shown below                               */
    /*                                                                                                */
    /*   Chris Veness                                                                                 */
    /*   https://www.movable-type.co.uk/scripts/latlong.html                                          */
    /*   https://www.movable-type.co.uk/scripts/geodesy-library.html#latlon-spherical                 */
    /*                                                                                                */
    /*   Ed Williams                                                                                  */
    /*   https://www.edwilliams.org/                                                                  */
    /*   https://www.edwilliams.org/avform147.htm                                                     */
    /*                                                                                                */
    /* Consistency rules:                                                                             */
    /*                                                                                                */
    /* use lat/lon for lati­tude/longi­tude in degrees                                                  */
    /* use  φ/λ for lati­tude/longi­tude in radians                                                     */
    /*                                                                                                */
    /* North latitudes and West longitudes are used as positive.                                      */
    /* South latitudes and East longitudes are used as negative.                                      */
    /*                                                                                                */
    /* ===============================================================================================*/

    class GreatCircle
    {

        /// <summary>
        /// This uses the ‘Haversine’ formula to calculate the great-circle distance between two points
        /// That is, the shortest distance over the earth’s surface – giving an ‘as-the-crow-flies’ distance
        /// between the points (ignoring any vertical obstructions like hills that they may need to fly over).
        /// 
        /// Haversine formula:
        /// a = sin²(Δφ/2) + cos φ1 * cos φ2 * sin²(Δλ/2) 
        /// d = R * (2 * atan2( √a, √(1−a)))
        ///
        /// Where:
        /// φ is latitude,
        /// λ is longitude,
        /// R is earth’s radius (mean radius = 6371m),
        /// d is resulting distance,
        /// All angles need to be in radians
        /// 
        /// </summary>
        /// <param name="origin_longitude"></param>
        /// <param name="origin_latitude"></param>
        /// <param name="destination_longitude"></param>
        /// <param name="destination_latitude"></param>
        /// <returns>Distance between the two points in metres.</returns>
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
        /// This formula is for the initial bearing (sometimes referred to as forward azimuth) which if
        /// followed in a straight line along a great-circle arc will take you from the start point to the
        /// end point.
        /// 
        /// Formula:	θ = atan2( sin Δλ ⋅ cos φ2 , cos φ1 ⋅ sin φ2 − sin φ1 ⋅ cos φ2 ⋅ cos Δλ )
        ///
        /// where:
        /// φ1,λ1 is the start point,
        /// φ2,λ2 the end point,
        /// Δλ is the difference in longitude
        /// </summary>
        /// <param name="origin_longitude"></param>
        /// <param name="origin_latitude"></param>
        /// <param name="destination_longitude"></param>
        /// <param name="destination_latitude"></param>
        /// <returns>Returns the bearing and its cardinal point for the route starting in both directions</returns>
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
        /// This is the half-way point along a great circle path between the two points.
        /// 
        /// Formula:
        /// Bx = cos φ2 ⋅ cos Δλ
        /// By = cos φ2 ⋅ sin Δλ
        /// φm = atan2( sin φ1 + sin φ2, √(cos φ1 + Bx)² + By² )
        /// λm = λ1 + atan2(By, cos(φ1)+Bx)
        ///
        /// The midpoint may not be located half-way between latitudes/longitudes
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
        /// Find a destination co-ordinates from start co-ordinates, bearing and distance.
        /// Formula:	φ2 = asin( sin φ1 ⋅ cos δ + cos φ1 ⋅ sin δ ⋅ cos θ )
        ///             λ2 = λ1 + atan2( sin θ ⋅ sin δ ⋅ cos φ1, cos δ − sin φ1 ⋅ sin φ2 )
        /// where
        /// φ is latitude,
        /// λ is longitude,
        /// θ is the bearing (clockwise from north), 
        /// d being the distance traveled,
        /// R the earth’s radius
        /// δ is the angular distance d/R,
        /// 
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
