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
        /// <param name="decimalDegrees"></param>
        /// <param name="decimalDegrees"></param>
        /// <returns>Radians as a double</returns>
        public static double toRadians(string myData1, string myData2)
        {
            return (double.Parse(myData1) - double.Parse(myData2)) * Math.PI / 180; //in radians
        }

        
        /// <summary>
        /// Converts Radians to Degrees
        /// </summary>
        /// <param name="radians"></param>
        /// <returns>Returns degrees as double</returns>
        public static double toDegrees(double myData)
        {
           return (myData * 180 / Math.PI + 360) % 360; // in degrees
        }


        /// <summary>
        /// Input data in metres returns in miles
        /// </summary>
        /// <param name="metres"></param>
        /// <returns>Miles as double</returns>
        public static double toMiles(double myData)
        {
            return (myData * 0.00062137); // in miles
        }

        /// <summary>
        /// Input data in miles returns in kilometres
        /// </summary>
        /// <param name="miles"></param>
        /// <returns>Kilometres as double</returns>
        public static double toKilometres(double myData)
        {
            return (myData * 1.609344); // in kilometres
        }

        /// <summary>
        /// Input data in metres returns in nautical miles
        /// </summary>
        /// <param name="metres"></param>
        /// <returns>Nautical Miles as double</returns>
        public static double toNauticalMiles(double myData)
        {
            return (myData * 0.00053996); // in nautical miles
        }

        /// <summary>
        /// Converts degrees, minutes and seconds into decimal degrees
        /// </summary>
        /// <param name="degrees"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        /// <returns>Decimal degrees as double</returns>

        public static double toDecimalDegrees(string myDegrees, string myMinutes, string mySeconds)
        {
            return double.Parse(myDegrees) + (double.Parse(myMinutes) / 60) + (double.Parse(mySeconds) / 3600);
        }

        /// <summary>
        /// Converts Decimal degrees to degrees, minutes and seconds
        /// </summary>
        /// <param name="DecimalDegrees"></param>
        /// <returns>String containing degrees, minutes and seconds</returns>
        public static string toDegreesMinutesSeconds(string myDegrees)
        {
            int seconds = (int)Math.Round(double.Parse(myDegrees) * 3600);
            int degrees = seconds / 3600;
            seconds = Math.Abs(seconds % 3600);
            int minutes = seconds / 60;
            seconds %= 60;
            
            return degrees + "° " + minutes + "' " + seconds + "\"";
        }


       

    }
}
