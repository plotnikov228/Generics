using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyArrayUtils<T>
    {
        public void Print(T[] mass)
        {
            Console.WriteLine();
        }

        public void Reverse(T[mass])
        {
            
        }

        public T[] GenerateArray(int mass)
        {
            T[] _result = new T[mass];

            if (typeof(T) == typeof(int))
            {
                Console.WriteLine();
            }
            return _result;
        }

       
    }
}
