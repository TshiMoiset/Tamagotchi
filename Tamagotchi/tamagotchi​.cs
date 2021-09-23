using System.Collections.Generic;
using System;

namespace Tamagotchi
{
    public class tamagotchi​
    {
        int hunger = 0;
        int boredom = 0;
        List<string> words = new List<string>() { };
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
            Console.WriteLine($"{words}");
            reduceBoredom();
        }


        //lägger till ett ord i words, och anropar ReduceBoredom.
        public void teach(string word)
        {
            words.Add(word);
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
            }
        }


        // skriver ut nuvarande hunger och bredom, och meddelar också huruvida tamagotchin lever.
        public void printStats()
        {
            Console.WriteLine($"Din karaktärs Tristess: {boredom}");
            Console.WriteLine($"Din karaktärs Hunger: {hunger}");
            Console.WriteLine($"Lever din karaktär {isAlive}");
        }

        //returnerar värdet som isAlive har.
        bool GetAlive = true;


        //sänker boredom.
        private void reduceBoredom()
        {
            boredom -= 1;
        }
    }
}