using System;

namespace GlobalData.Utils
{
    class Convertion
    {
        /// <summary>
        /// Converts a string into radians
        /// </summary>
        /// <param name="myData"></param>
        /// <returns>Radians as a double</returns>
        public static double toRadians(string myData)
        {
          return  double.Parse(myData) * Math.PI / 180; //in radians
        }

        /// <summary>
        /// Gets the difference between two co-ordinates and converts answer to radians
        /// </summary>
        /// <param name="myData1"></param>
        /// <param name="myData2"></param>
        /// <returns>Radians as a double</returns>
        public static double toRadians(string myData1, string myData2)
        {
            return (double.Parse(myData1) - double.Parse(myData2)) * Math.PI / 180; //in radians
        }

        
        /// <summary>
        /// Converts Radians to Degrees
        /// </summary>
        /// <param name="myData"></param>
        /// <returns>Returns degrees as double</returns>
        public static double toDegrees(double myData)
        {
           return (myData * 180 / Math.PI + 360) % 360; // in degrees
        }


        /// <summary>
        /// Input data in metres returns in miles
        /// </summary>
        /// <param name="myData"></param>
        /// <returns>Miles as double</returns>
        public static double toMiles(double myData)
        {
            return (myData * 0.00062137); // in miles
        }

        /// <summary>
        /// Input data in miles returns in kilometres
        /// </summary>
        /// <param name="myData"></param>
        /// <returns>Kilometres as double</returns>
        public static double toKilometres(double myData)
        {
            return (myData * 1.609344); // in kilometres
        }

        /// <summary>
        /// Input data in metres returns in nautical miles
        /// </summary>
        /// <param name="myData"></param>
        /// <returns>Nautical Miles as double</returns>
        public static double toNauticalMiles(double myData)
        {
            return (myData * 0.00053996); // in nautical miles
        }
        



    }
}
