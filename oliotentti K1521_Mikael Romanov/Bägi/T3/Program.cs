using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bagi bagi = new Bagi();
            Console.Write("A new empty bag has created\n");

            Balls pallot = new Balls(10);
            Maila driver = new Maila("Driver", 1);
            Maila fairway = new Maila("Fairway", 3);
            Maila wedge = new Maila("Wedge", 55);

            bagi.AddBalls(pallot);
            bagi.AddMaila(driver);
            bagi.AddMaila(fairway);
            bagi.AddMaila(wedge);
            bagi.ShowContents();

            string nimi = "Fairway";
            bagi.RemoveMaila(nimi);
            bagi.RemoveBalls(2);
            bagi.ShowContents();
            
        }
    }
}

// Vaikka joku 5 pistettä?

// A new empty bag has created
// AddedBalls: 10 balls to the bag
// Trying to add a new club to the bag: Type: Driver Number:1
// Trying to add a new club to the bag: Type: Fairway Number:3
// Trying to add a new club to the bag: Type: Wedge Number:55
// Bag contains:
// Balls: 10
// Type: Driver Number:1
// Type: Fairway Number:3
// Type: Wedge Number:55
// Trying to get Fairway club from the bag
// Club removed from the bag
// Trying to get 2 balls from the bag
// 2 balls removed from the bag
// Bag contains:
// Balls: 8
// Type: Driver Number:1
// Type: Wedge Number:55
// Press any key to continue . . .