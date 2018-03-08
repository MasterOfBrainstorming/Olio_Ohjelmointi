using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Bagi
    {
        List<Maila> mailat = new List<Maila>(14);
        List<Balls> ballsit = new List<Balls>(1);
        public void AddMaila(Maila maila)
        {
            Console.WriteLine("Trying to add a new club to the bag: {0}",maila);
            mailat.Add(maila);
        }

        public void AddBalls(Balls ball)
        {
            Console.WriteLine("Added{0} balls to the bag", ball);
            ballsit.Add(ball);
        }

        public void ShowContents()
        {
            Console.Write("Bag contains:\n");
            foreach (Balls ball in ballsit)
            {
                Console.WriteLine(ball);
            }

            foreach (Maila maila in mailat)
            {
                Console.WriteLine(maila);
            }
        }

        public void RemoveMaila(string key)
        {
            foreach (Maila maila in mailat)
            {
                if (key.Equals(maila.Name))
                {
                    Console.WriteLine("Trying to get {0} club from the bag",maila.Name);
                    int x = mailat.IndexOf(maila);
                    Console.WriteLine("Club removed from the bag");
                    mailat.RemoveAt(x);
                    break;
                }
            }
        }
        public void RemoveBalls(int key)
        {
            foreach (Balls ball in ballsit)
            {
                    Console.WriteLine("Trying to get {0} balls from the bag",key);
                    ball.Amount -= key ;
                    Console.WriteLine("{0} balls removed from the bag",key);                 
                }
            }
        }
    }