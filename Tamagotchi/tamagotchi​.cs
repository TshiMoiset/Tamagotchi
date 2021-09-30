using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;
using System;

namespace Tamagotchi
{
    public class tamagotchi​
    {
        int hunger = 0;
        int boredom = 0;
        List<string> words = new List<string>();
        bool isAlive = true;

        Random generator = new Random();
        public string name;


        //sänker Hunger
        public void feed()
        {
            hunger -= 1;
        }

        //skriver ut ett slumpat ord från words, och anropar ReduceBoredom.
        public void hi()
        {
            int i = generator.Next(words.Count);
            if (words.Count < 0)
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine(words[i]);
            }
            reduceBoredom();
        }


        //lägger till ett ord i words, och anropar ReduceBoredom.
        public void teach(string word)
        {
            words.Add(word);
            Console.Write("Ordet: ");
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }

            reduceBoredom();
        }


        //ökar hunger och boredom, och om någon av dem kommer över 10 så blir isAlive false.
        public void tick()
        {
            hunger += 1;
            boredom += 1;
            if (boredom > 10 || hunger > 10)
            {
                isAlive = false;
                Console.WriteLine("GAME OVER");
            }
        }


        // skriver ut nuvarande hunger och bredom, och meddelar också huruvida tamagotchin lever.
        public void printStats()
        {
            Console.WriteLine($"Boredom: {boredom}");
            Console.WriteLine($"Hunger: {hunger}");
            Console.WriteLine($"Lever din karaktär: {isAlive}");
        }

        //returnerar värdet som isAlive har.
        public bool GetAlive()
        {
            return isAlive;
        }


        //sänker boredom.
        private void reduceBoredom()
        {
            boredom -= 1;
        }
    }
}