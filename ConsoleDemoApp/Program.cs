using StrategyDesignPattern;
using System;

namespace ConsoleDemoApp
{

    public class Program
    {

        private static void Execute(IStrategy strategy)
        {
            strategy.Solve();
        }

        public static void Main(string[] args)
        {
            WriteToConsole("Strategy Design Pattern", ConsoleColor.Cyan);
            Console.WriteLine();

            IStrategy[] algorithms = { new Foo(), new Bar() };
            foreach (var algorithm in algorithms)
            {
                WriteToConsole(algorithm.GetType().ToString(), ConsoleColor.Yellow);
                Execute(algorithm);
                Console.WriteLine();
            }

            WriteToConsole("Finished - press any key to close it!", ConsoleColor.White);
            Console.ReadKey();
        }

        private static void WriteToConsole(string text = "", ConsoleColor consoleColor = ConsoleColor.White)
        {
            var consoleForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ForegroundColor = consoleForegroundColor;
        }

    }

}