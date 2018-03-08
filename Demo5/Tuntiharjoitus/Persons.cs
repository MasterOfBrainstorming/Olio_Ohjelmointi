using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekisteri
{
    class Persons
    {
        private List<Person> persons;


        public Persons()
        {
            persons = new List<Person>();
        }

        /// <summary>
        /// Add person to collection
        /// </summary>
        /// <param name="person">person to add</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public Person GetPerson(int location)
        {
            if (location < persons.Count)
            {
               return persons.ElementAt(location);
            }
            else { return null; }
        }

        public Person FindPerson(string social)
        {
            foreach (Person person in persons)
            {
                if (social.Equals(person.SocialSecurityNumber))
                {
                    return person;
                }
            }
            return null;
        }


        public void Print()
        {
            foreach(Person person in persons)
            {
                Console.Write(person);
            }
        }
    }
}
