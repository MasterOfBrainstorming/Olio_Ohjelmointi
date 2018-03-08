using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekisteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons jamit = new Persons();

            Person jami1 = new Person { Firstname="Dj",Lastname="Kridlokk",SocialSecurityNumber="KCMD-MAFIA" };
            Person jami2 = new Person { Firstname = "Evil", Lastname = "Stöö", SocialSecurityNumber = "ROUTSI-STÖGIS" };
            Person jami3 = new Person { Firstname = "Koksu", Lastname = "Koo", SocialSecurityNumber = "LOMMO" };

            // ADD Person objects to Persons (jamit)
            jamit.AddPerson(jami1);
            jamit.AddPerson(jami2);
            jamit.AddPerson(jami3);

            // get one person

            Person jami4 = jamit.GetPerson(0);
            if (jami4 != null)
            {
                Console.WriteLine(jami4.ToString());
            }
            else
            {
                Console.WriteLine("Nakki");
            }

            jamit.Print();

            string sotu = "KCMD-MAFIA";
            Console.Write("Find with: {0} \n", sotu);
            Person jami5 = jamit.FindPerson(sotu);
            if (jami5 != null)
            {
                Console.WriteLine(jami5.ToString());
            }
            else
            {
                Console.WriteLine("_Super_Nakki_Tällä_Pistetään_Paikat_Remonttiin");
            }
        }
    }
}
