using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            string currentInputStr;
            int currentInput;
            while (true) {
                Console.Write("Please enter a positive integer(type \"end\" to exit):");
                currentInputStr = Console.ReadLine();
                if (currentInputStr == "end") {
                    break;
                }
                try {
                    currentInput = int.Parse(currentInputStr);
                }
                catch {
                    Console.WriteLine("Your enter doesn't obey the rule!");
                    Console.WriteLine("Please enter again!");
                    continue;
                }
                if (currentInput > max) {
                    max = currentInput;
                }
            }
            Console.WriteLine("The max integer you have entered is {0}", max);
        }
    }
}
