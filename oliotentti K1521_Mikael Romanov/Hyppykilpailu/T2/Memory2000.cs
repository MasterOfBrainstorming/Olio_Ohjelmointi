using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Koululaisten pituushyppykilpailussa käytetään Memory 2000 -laitetta rekisteröimään kaikkien koululaisten pituushyppytulokset. 
// Laitteelle voidaan syöttää arvoja vain yksi kerrallaan (oppilaan nimi sekä tulos). 
// Laitteen tulee voida näyttää kaikki syötetyt tulokset suuruusjärjestyksessä.
// Toteuta laitteen toiminta luokkaan Memory2000.
// Tee myös pääohjelma ja käytä sen avulla tekemääsi Memory2000-luokkaa.
// Graafista käyttöliittymää ei tehtävässä vaadita(toki sen voit toteuttaa, jos haluat).
// Muista jättää toteutukseen näkyville kaikki ohjelmointikoodit, jotta Memory2000-luokan käyttäminen voidaan todeta tehdyksi.
// Osoita laitteen toiminta konsoli-ikkunan tulostuksen avulla.
// Muista liittää tulostus tehtävän Main()-metodin sisältävän luokan alkuun tenttiohjeiden mukaisesti.
// Sekä oma pistearviosi tehtävästä.
// Esimerkkitulostus voisi olla seuraava (alla näkyy tulostuksia, kuinka Memory2000-luokan oliota on käytetty): 

namespace T2
{
    class Memory2000
    {
        public List<Person> persons;
        public Memory2000()
        {
            // Luodaan uusi lista nimeltä person constructorissa
            persons = new List<Person>();
        }

        public void Addtolist(string name, double value)
        {
            // Lisätään henkilö listaan
            persons.Add(new Person(name, value));
            // Tulostetaan että listaan on lisätty henkilö
            Console.WriteLine("Lisätty {0} pituus {1}", name, value);
        }

        public void PrintData()
        {
            // Järjestetään Laskevaan järjestykseen
            persons.Sort((x, y) => y.Result.CompareTo(x.Result));
            Console.Write("********************\nMemory 2000 tulokset\n********************\n");
            // Tulostetaan listan sisältö
            persons.ForEach(item => Console.WriteLine(item.ToString() + "\n"));
        }

    }
}
