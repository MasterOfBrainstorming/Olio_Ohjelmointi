using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Person
    {
        public string Name { get; set; }
        public double Result { get; set; }


        public Person(string name, double result)
        {
            Name = name;
            Result = result;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Result: " + Result;
        }
    }
}
