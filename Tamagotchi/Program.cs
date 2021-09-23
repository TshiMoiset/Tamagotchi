using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata;
using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {

            tamagotchi gucci = new tamagotchi();
            gucci.name = "";

            int menuChoises = 0;
            string menuChoisesString = "";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Välkomen till Tamagotchi");

            while (menuChoises != 3) // Innehållet som finns i menyn.
            {
                Console.WriteLine();
                Console.WriteLine("Välj ett alternativ!");
                Console.WriteLine("1. Starta spel");
                Console.WriteLine("2. Hur fungerar spelet?");
                Console.ForegroundColor = ConsoleColor.Cyan;
                menuChoisesString = Console.ReadLine();

                while (!int.TryParse(menuChoisesString, out menuChoises))       // Koden gör att den inte krashar om anvädaren inte följer instruktionerna.
                {
                    Console.WriteLine();
                    setWritelineColor("Det där är inte ett giltigt svar. Försök igen!", ConsoleColor.Red);
                    setWritelineColor("Ok, Jag väljer då: ", ConsoleColor.Cyan);

                    Console.ForegroundColor = ConsoleColor.Red;
                    menuChoisesString = Console.ReadLine();
                }


                Console.WriteLine();

                switch (menuChoisesString)
                {
                    case "1":
                        startGame();
                        Console.Clear();
                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Spelet går ut på att hålla din Tamagotchi vid liv.");
                        Console.WriteLine("Du ska välja mellan att lära tamagotchin ett nytt ord, hälsa på den, mata den eller göra ingenting.");
                        Console.WriteLine("Varje gång du gör ett val ökar hunger och boredom, och om någon av dem kommer över 10 så DÖR din tamagotchin.");
                        Console.WriteLine("DÖD TAMAGOTCHI = GAME OVER");
                        Console.WriteLine("Good Luck!!!");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }
            }

            Console.ReadLine();

            //gucci.printStats();

        }

        static void startGame()
        {
            tamagotchi gucci = new tamagotchi();
            gucci.name = "";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Välj ett namn till din Tamagotchi: ");
            gucci.name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Din Tamagotchi heter nu: {gucci.name}");

            Console.ReadLine();







        }

        public static void setWritelineColor(string txt, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(txt);
        }
    }
}

