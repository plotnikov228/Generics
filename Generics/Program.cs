using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box1 = new Box<int>(1);
            Box<int> box2 = new Box<int>(2);
            Box<int> box3 = new Box<int>(3);

            Console.WriteLine(box1);
            Console.WriteLine(box2);
            Console.WriteLine(box3);
            int[] mass = new int[] { box1._value, box2._value, box3._value };
            MyArrayUtils<int> myArrayUtils = new MyArrayUtils<int>();

            myArrayUtils.GenerateArray(3);
            myArrayUtils.Reverse(mass);
            myArrayUtils.Print(mass);
            

            //Не знаю как работает метод ревёрс



        }
    }
}
