using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Helper
    {
        public static void Max<T>(T argument1, T argument2) where T : IComparable<T>
        {
            if (argument1.CompareTo(argument2) > 0)
            {
                Console.WriteLine($"The bigger value is number 1 with value equals {argument1}");
            }
            else
            {
                Console.WriteLine($"The bigger value is number 2 with value equals {argument2}");
            }
        }
    }
}
