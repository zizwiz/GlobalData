﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
         */
        public static double Distance(string origin_longitude, string origin_latitude,
            string destination_longitude, string destination_latitude)
        {
            double earthsRadius = 6371000;     //earth’s radius in m (mean radius = 6371km)

            double φ1 = Convertion.toRadians(origin_latitude); //latitude in radians
            double φ2 = Convertion.toRadians(destination_latitude); // latitude in radians

            //difference in long and lat
            double Δφ = Convertion.toRadians(destination_latitude, origin_latitude);
            double Δλ = Convertion.toRadians(destination_longitude, origin_longitude);

            double a = Math.Sin(Δφ / 2) * Math.Sin(Δφ / 2) + Math.Cos(φ1) * Math.Cos(φ2) * Math.Sin(Δλ / 2) * Math.Sin(Δλ / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

           return earthsRadius * c; // in metres
        }






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
        public static (double, double) Bearing(string origin_longitude, string origin_latitude,
            string destination_longitude, string destination_latitude)
        {
            //latitudes
            double φ1 = Convertion.toRadians(origin_latitude); 
            double φ2 = Convertion.toRadians(destination_latitude);

            //longitudes
            double λ1 = Convertion.toRadians(origin_longitude); 
            double λ2 = Convertion.toRadians(destination_longitude); 

            double y = Math.Sin(λ2 - λ1) * Math.Cos(φ2);
            double x = Math.Cos(φ1) * Math.Sin(φ2) - Math.Sin(φ1) * Math.Cos(φ2) * Math.Cos(λ2 - λ1);
            double θ = Math.Atan2(y, x);

            double fbearing = (θ * 180 / Math.PI + 360) % 360; // forward bearing in degrees
            double rbearing = (fbearing + 180) % 360; // reverse bearing in degrees

            return (fbearing, rbearing);
        }


        public static (double, double) MidPoint(string origin_longitude, string origin_latitude,
            string destination_longitude, string destination_latitude)
        {
            //latitudes
            double φ1 = Convertion.toRadians(origin_latitude);
            double φ2 = Convertion.toRadians(destination_latitude);

            //longitudes
            double λ1 = Convertion.toRadians(origin_longitude);
          
            //difference in long and lat
            double Δλ = Convertion.toRadians(destination_longitude, origin_longitude);

            // get cartesian coordinates for the two points
            double[] A = {Math.Cos(φ1), 0, Math.Sin(φ1)}; // place point A on prime meridian y=0
            double[] B = {Math.Cos(φ2) * Math.Cos(Δλ), Math.Cos(φ2) * Math.Sin(Δλ), Math.Sin(φ2) };

            // vector to midpoint is sum of vectors to two points (no need to normalise)
            double[] C = { A[0] + B[0], A[1] + B[1], A[2] + B[2]};

            double φm = Math.Atan2(C[2], Math.Sqrt(C[0] * C[0] + C[1] * C[1]));
            double λm = λ1 + Math.Atan2(C[1], C[0]);

            double lat = Convertion.toDegrees(φm);
            double lon = Convertion.toDegrees(λm);

            return (lat, lon);
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
