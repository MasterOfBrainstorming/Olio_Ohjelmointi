using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuntiharjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.FirstName = "Pekka";

            // create one student object
            Student student = new Student();
            student.FirstName = "Nakki";
            student.LastName = "Naksu";
            student.Address = "Nakkikuja";
            student.Age = 23;
            student.PhoneNumber = "10000000";
            student.StudentID = "G4920";
            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("Sammpo","Verkkomiäs","D420");
            teacher.Age = 57;
            teacher.Address = "himassa";
            teacher.PhoneNumber = "010210240";
            Console.WriteLine(teacher.ToString());


            teacher.TeacherMethod();
            student.StudentMethod();

            // olio ei ole aliluokan sisällä...
            // student.PersonMethod();
        }

    }
}
