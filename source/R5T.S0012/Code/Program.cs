using System;

namespace R5T.S0012
{
    class Program
    {
        const string ErrorCommandValue = "error:";
        const string ExitCommandValue = "exit";


        static void Main(string[] args)
        {
            var output = Console.Out;
            var error = Console.Error;

            output.WriteLine("\n--- R5T.S0012 - Example echoing console program ---\n\n");
            output.WriteLine($"To exit type '{Program.ExitCommandValue}'.");

            while(true)
            {
                output.WriteLine();
                output.WriteLine("Type something:");

                var line = Console.ReadLine();

                var isExitCommand = Program.IsExitCommand(line);
                if(isExitCommand)
                {
                    break;
                }

                var isErrorCommand = Program.IsErrorCommand(line);
                if(isErrorCommand)
                {
                    // Write to error.
                    var errorLine = line.Substring(Program.ErrorCommandValue.Length);

                    error.WriteLine(errorLine);
                }
                else
                {
                    // Write to output.
                    output.WriteLine(line);
                }
            }
        }

        private static bool IsErrorCommand(string line)
        {
            if(line.Length < Program.ErrorCommandValue.Length)
            {
                return false;
            }
            // Now we know the line is 5 or more characters.

            var loweredLine = line.ToLowerInvariant();

            var lineStart = line.Substring(0, Program.ErrorCommandValue.Length);

            var isErrorCommand = lineStart == Program.ErrorCommandValue;
            return isErrorCommand;
        }

        private static bool IsExitCommand(string line)
        {
            var loweredLine = line.ToLowerInvariant();

            var isExitCommand = loweredLine == Program.ExitCommandValue;
            return isExitCommand;
        }
    }
}
