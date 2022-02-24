using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generics
{
    internal class Box<T>
    {
        public T _value { get; set; }
        public Box (T value)
        {
            _value = value;
        }
        public override string ToString()
        {
            return _value + " ";
        }
    }
}
