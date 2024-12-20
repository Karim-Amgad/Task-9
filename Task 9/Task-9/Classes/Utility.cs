using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9.Classes
{
    internal class Utility
    {
        #region Rectangle Premiter
        public static double RectanglePremiter(double length, double width)
        {
            return (length + width) * 2;
        }
        #endregion

        #region Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double Celsius)
        {
            return 1.8 * Celsius + 32;
        } 
        #endregion
    }
}
