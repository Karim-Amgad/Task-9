using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Helper2<T> 
    {
        public static void swap (ref T A,ref T B)
        {
            T swap = A;
            A = B;
            B = swap;
        }
        public static void ReplaceArray(ref T[] array, T OldNumber, T NewNumber)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(OldNumber))
                {
                    array[i] = NewNumber;
                }
            }
        }

        public static int SearchArray(Employee[] emp1, Employee emp2)
        {
            for (int i = 0; i < emp1.Length; i++)
            {
                if (emp1[i].Equals(emp2))
                {
                    return i+1;
                }
            }
            return -1;
        }
    }
}
