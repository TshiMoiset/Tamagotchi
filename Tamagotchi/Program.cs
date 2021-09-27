using System.Runtime.ConstrainedExecution;
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
            int menuChoises = 0;
            string menuChoisesString = "";
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Välkomen till Tamagotchi!");
            Console.WriteLine();

            while (menuChoises != 3) // Innehållet som finns i menyn.
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Välj ett alternativ!");
                Console.WriteLine("1. Starta spel ;)");
                Console.WriteLine("2. Hur funkaar det?");
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
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Spelet går ut på att hålla din Tamagotchi vid liv och exalterad.");
                        Console.WriteLine("Du ska välja mellan att lära tamagotchin ett nytt ord, hälsa på den, mata den eller göra ingenting.");
                        Console.WriteLine("Varje gång du gör ett val ökar hunger och boredom, och om någon av de blir över 10 så DÖR din tamagotchi.");
                        Console.WriteLine("DÖD TAMAGOTCHI = GAME OVER");
                        Console.WriteLine("Lycka till!!!");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }
            }

            Console.ReadLine();

            //gucci.printStats();

        }

        static void startGame()
        {
            string answer = "";
            tamagotchi gucci = new tamagotchi();
            gucci.name = "";
            string svar = Console.ReadLine();
            gucci.teach(svar);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Välj ett namn till din Tamagotchi: ");
            gucci.name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Din Tamagotchi heter nu: {gucci.name}");

            Console.ForegroundColor = ConsoleColor.Green;
            gucci.printStats();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Vad vill du göra?");
            setWritelineColor("1. Lära tamagotchin ett nytt ord", ConsoleColor.Magenta);
            setWritelineColor("2. Hälsa på den", ConsoleColor.Blue);
            setWritelineColor("3. Mata den", ConsoleColor.Red);
            setWritelineColor("4. Göra ingenting", ConsoleColor.Yellow);

            Console.ReadLine();

            if (answer == "1")
            {
                gucci.teach();

            }






        }

        public static void setWritelineColor(string txt, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(txt);
        }
    }
}

