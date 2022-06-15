using System;

namespace GjettTallet
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {


                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Gjett et tall mellom 1 og 10.");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Cyan;
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    Console.ResetColor();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "OBS! Du kan bare gjette tall!");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Du gjettet feil! Prøv igjen!");

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.ResetColor();
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "Du gjettet riktig! Gratulerer! :D ");

                PrintColorMessage(ConsoleColor.Green, "Vil du prøve igjen? [J eller N]");
               

                Console.ForegroundColor = ConsoleColor.Cyan;

                string answer = Console.ReadLine().ToUpper();


                if(answer == "J")
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Metoder for å korte ned en kode som var mye lenger;

        static void GetAppInfo()
        {
            string appName = "Gjett Tallet!";
            string appAuthor = "Renee T";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}: av {1}", appName, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hei! Hva heter du?");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            string inputName = Console.ReadLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hei {0}, la oss spille!", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

