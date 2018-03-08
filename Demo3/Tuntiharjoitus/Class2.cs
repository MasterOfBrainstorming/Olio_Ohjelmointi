using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuntiharjoitus_2
{
    class Teacher : Person
    {
        public string Room { get; set; }


        public Teacher()
        {
        }
        public Teacher(string firstname, string lastname, string room)
            : base(firstname, lastname)
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to Teacher!");
        }

        public override string ToString()
        {
            // Person-luokan ToString + Room
            // Firstname + Lastname .... + Room
            // base viittaa yliluokkaan eli nyt Person-luokkaan
            return base.ToString() + " " + Room;
        }

    }
}
