using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryAPI.Core.Helpers
{
    public class Helper
    {
        public static double RadToDegree(double rad)
        {
            return Convert.ToDouble(rad / Math.PI * 180);
        }



        public static double DegreeToRad(double degree)
        {
            return Convert.ToDouble( degree* Math.PI / 180);
        }



    }
}
