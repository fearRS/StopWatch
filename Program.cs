using System;

namespace StopWatch
{
    class Program
    {
        static void Main()
        {
            Watch stopStart = new Watch();

            Console.WriteLine("Press Enter to start or 'q' to quit");

            while (true)
            {
                ConsoleKey input = Console.ReadKey().Key;
                if (input != ConsoleKey.Enter)
                {
                    Console.WriteLine("\nPress Enter to start the Stopwatch");
                }
                else
                {
                    Console.WriteLine("Watch started!\nPress Enter to stop");
                    stopStart.Start();
                    input = Console.ReadKey().Key;
                    while (input != ConsoleKey.Enter)
                    {
                        Console.WriteLine("\nPress Enter to start the Stopwatch");
                        input = Console.ReadKey().Key;
                    }
                    stopStart.Stop();
                    Console.WriteLine($"Time elapsed is: {stopStart.Stop()} seconds.");
                }
            }

        }
    }
}
