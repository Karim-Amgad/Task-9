using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal struct Circle
    {
        #region Property & Attribute
        public double Radius { get; set; }
        public string Color { get; set; }
        #endregion

        #region Ctor
        public Circle(double _radius, string _color)
        {
            Radius = _radius;
            Color = _color;
        }
        #endregion

        #region Override == & !=
        public static bool operator ==(Circle circle1, Circle circle2)
        {
            return circle1.Equals(circle2);
        }
        public static bool operator !=(Circle circle1, Circle circle2)
        {
            return !(circle1 == circle2);
        }
        #endregion
    }
    class CircleClass
    {
        #region Property & Attribute
        public double Radius { get; set; }
        public string Color { get; set; }
        #endregion

        #region Ctor
        public CircleClass(double _radius, string _color)
        {
            Radius = _radius;
            Color = _color;
        }
        #endregion
    }
}
