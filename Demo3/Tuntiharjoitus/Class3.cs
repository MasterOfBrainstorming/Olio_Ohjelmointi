using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuntiharjoitus_2
{
    class Student: Person
    {
        public string StudentID { get; set; }

        public Student()
        {
        }

        public Student(string firstname, string lastname, string studenID)
            :base(firstname,lastname)
        {
            StudentID = StudentID;
        }

        public void StudentMethod()
        {
            Console.WriteLine("This method belongs to Student");
        }
        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}
