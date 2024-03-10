using System;

namespace GlobalData.Utils
{
    class Convertion
    {
        /*
         * Converts a string into radians
         */
        public static double toRadians(string myData)
        {
          return  double.Parse(myData) * Math.PI / 180; //inradian
        }

        public static double toRadians(string myData1, string myData2)
        {
            return (double.Parse(myData1) - double.Parse(myData2)) * Math.PI / 180; //in radians
        }

        public static double toDegrees(double myData)
        {
           return (myData * 180 / Math.PI + 360) % 360; // in degrees
        }
    }
}
