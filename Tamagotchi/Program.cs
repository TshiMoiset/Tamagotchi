using System.ComponentModel;
using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tamagotchi";
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
                    default:
                        setWritelineColor("ERROR!!!", ConsoleColor.Red);
                        Console.WriteLine("Du har inte valt någon av alternativen 1 - 3!");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }
            }

            Console.ReadLine();

            //gucci.printStats();

        }

        static void startGame()
        {
            int answerInt = 0;
            string answer = "";
            string food = "";
            tamagotchi gucci = new tamagotchi();
            gucci.name = "";


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Välj ett namn till din Tamagotchi: ");
            gucci.name = Console.ReadLine();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Din Tamagotchi heter nu: {gucci.name}");

            while (gucci.GetAlive())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                gucci.printStats();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Vad vill du göra?");
                setWritelineColor($"1. Lära {gucci.name} ett nytt ord", ConsoleColor.Magenta);
                setWritelineColor("2. Hälsa på den", ConsoleColor.Blue);
                setWritelineColor("3. Mata den", ConsoleColor.Red);
                setWritelineColor("4. Göra ingenting", ConsoleColor.Yellow);

                answer = Console.ReadLine();

                if (answer == "1")
                {
                    Console.WriteLine();
                    Console.Write($"Lär {gucci.name} ett nytt ord: ");
                    string wordAnswer = Console.ReadLine();
                    gucci.teach(wordAnswer);
                    Console.WriteLine();
                    Console.WriteLine($"{gucci.name} lärde sig ordet: {wordAnswer} ");
                    gucci.tick();
                }

                if (answer == "2")
                {
                    gucci.hi();
                    Console.WriteLine();
                    gucci.tick();
                }

                if (answer == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Vad vill du att {gucci.name} ska äta?");
                    food = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    Console.WriteLine("Tack för maten, den var god :)");
                    Console.WriteLine();
                    gucci.tick();
                    gucci.feed();

                }

                if (answer == "4")
                {
                    Console.WriteLine("Vad tråkig du är :(");
                    Console.WriteLine();
                    gucci.tick();
                }

                while (!int.TryParse(answer, out answerInt))
                {
                    Console.WriteLine();
                    setWritelineColor("Det där är inte ett giltigt svar. Försök igen!", ConsoleColor.Red);
                    setWritelineColor("Ok, Jag väljer då: ", ConsoleColor.Cyan);
                    answer = Console.ReadLine();
                }
            }

        }

        public static void setWritelineColor(string txt, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(txt);
        }
    }
}

