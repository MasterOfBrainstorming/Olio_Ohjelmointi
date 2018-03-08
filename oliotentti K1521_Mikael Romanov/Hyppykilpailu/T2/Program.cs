using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Koululaisten pituushyppykilpailussa käytetään Memory 2000 -laitetta rekisteröimään kaikkien koululaisten pituushyppytulokset. 
// Laitteelle voidaan syöttää arvoja vain yksi kerrallaan (oppilaan nimi sekä tulos). 
// Laitteen tulee voida näyttää kaikki syötetyt tulokset suuruusjärjestyksessä.
// Toteuta laitteen toiminta luokkaan Memory2000.Tee myös pääohjelma ja käytä sen avulla tekemääsi Memory2000-luokkaa.
// Graafista käyttöliittymää ei tehtävässä vaadita(toki sen voit toteuttaa, jos haluat).
// Muista jättää toteutukseen näkyville kaikki ohjelmointikoodit, jotta Memory2000-luokan käyttäminen voidaan todeta tehdyksi.
// Osoita laitteen toiminta konsoli-ikkunan tulostuksen avulla.
// Muista liittää tulostus tehtävän Main()-metodin sisältävän luokan alkuun tenttiohjeiden mukaisesti.
// Sekä oma pistearviosi tehtävästä.
// Esimerkkitulostus voisi olla seuraava (alla näkyy tulostuksia, kuinka Memory2000-luokan oliota on käytetty): 


namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Memory2000 memory = new Memory2000();
            Console.Write("***************************\nMemory 2000 otettu käyttöön\n***************************\n");

            bool tosi = true;
            while (tosi)
            {
                Console.Write("1) Add values\n2)Print values\n0) EXIT\n>");
                int value = Int32.Parse(Console.ReadLine());

                switch (value)
                {
                    case 1:
                        Console.WriteLine("Name of the person:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Result of the person(double):");
                        double result = double.Parse(Console.ReadLine());
                        memory.Addtolist(name, result);
                        break;
                    case 2:
                        memory.PrintData();
                        break;
                    case 0:
                        tosi = false;
                        break;
                }
            }
        }
    }
}
// Varmaan 6 pistettä on ihan OK tästä tehtävästä?

// ***************************
// Memory 2000 otettu käyttöön
// ***************************
// 1) Add values
// 2)Print values
// 0) EXIT
// >1
// Name of the person:
// Matti
// Result of the person(double):
// 10,11
// Lisätty Matti pituus 10,11
// 1) Add values
// 2)Print values
// 0) EXIT
// >1
// Name of the person:
// Minna
// Result of the person(double):
// 20,11
// Lisätty Minna pituus 20,11
// 1) Add values
// 2)Print values
// 0) EXIT
// >1
// Name of the person:
// Toni
// Result of the person(double):
// 40,24
// Lisätty Toni pituus 40,24
// 1) Add values
// 2)Print values
// 0) EXIT
// >2
// ********************
// Memory 2000 tulokset
// ********************
// Name: Toni Result: 40,24

// Name: Minna Result: 20,11

// Name: Matti Result: 10,11

// 1) Add values
// 2)Print values
// 0) EXIT