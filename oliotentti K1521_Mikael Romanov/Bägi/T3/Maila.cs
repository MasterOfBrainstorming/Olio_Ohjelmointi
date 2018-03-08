using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Maila
    {
        public string Name { get; set; }
        public int Club { get; set; }

        public Maila(string name, int type)
        {
            Name = name;
            Club = type;
        }

        public override string ToString()
        {
            return "Type: "+ Name + " " + "Number:"+ Club;
        }
    }
}
