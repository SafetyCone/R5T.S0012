using System;

namespace R5T.S0012
{
    class Program
    {
        const string ExitCommandValue = "exit";


        static void Main(string[] args)
        {
            Console.WriteLine("\n--- R5T.S0012 - Example echoing console program ---\n\n");
            Console.WriteLine($"To exit type '{Program.ExitCommandValue}'.");

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Type something:");

                var line = Console.ReadLine();

                var isExitCommand = Program.IsExitCommand(line);
                if(isExitCommand)
                {
                    break;
                }

                Console.WriteLine(line);
            }
        }

        private static bool IsExitCommand(string line)
        {
            var loweredLine = line.ToLowerInvariant();

            var isExitCommand = loweredLine == Program.ExitCommandValue;
            return isExitCommand;
        }
    }
}
