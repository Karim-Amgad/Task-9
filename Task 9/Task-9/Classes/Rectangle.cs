using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal struct Rectangle
    {
        #region Attributes & Properties
        public double Length { get; set; }
        public double Width { get; set; }
        #endregion

        #region Ctor
        public Rectangle(double _Length, double _Width)
        {
            Length = _Length;
            Width = _Width;
        }
        #endregion

        #region Swap
        public static void Swap(ref Rectangle rectangle1, ref Rectangle rectangle2)
        {
            Rectangle temp = rectangle1;
            rectangle1 = rectangle2;
            rectangle2 = temp;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return ($"The rectangle length is {Length} and width is {Width}");
        }
        #endregion
    }
}
