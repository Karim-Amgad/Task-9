using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Part2
    {
        public static T[] ReverseArray<T>(T[] Array)
        {
            T[] ReversedArray = new T[Array.Length];

            for (int i = 0; i < Array.Length; i++)
            {
                ReversedArray[i] = Array[Array.Length - 1 - i];
            }

            return ReversedArray;
        }

        public static void Swap<T>(T[] array, int index1,  int index2)
        {
             T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            T max = array[0];
            foreach (T element in array)
            {
                if (element.CompareTo(max) == 1)
                {
                    max = element;
                }
            }
            return max;
        }

    }
    class Stack<T>
    {
        private T[] _items; 
        private int _size;   
        private int _capacity;
        public Stack(int capacity = 10)
        {
            _capacity = capacity;
            _items = new T[_capacity];
            _size = 0;
        }
        public void Push(T item)
        {            
            _items[_size] = item;
            _size++;
        }
        public T Pop()
        {
            _size--;
            T item = _items[_size];
            _items[_size] = default;
            return item;
        }
        public T Peek()
        {
            return _items[_size - 1];
        }
    }
}
