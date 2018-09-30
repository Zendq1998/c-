using System;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            int inputNum;
            Console.Write("Please enter a positive integer:");
            while (true) {
                inputStr = Console.ReadLine();
                try {
                    inputNum = int.Parse(inputStr);
                    if (inputNum < 0) {
                        Console.WriteLine("You have to enter a positive integer");
                        Console.Write("Please enter again:");
                        continue;
                    }
                    for (int i = 0; i < inputNum; i += 1) {
                        Console.WriteLine("{0} + {1} = {2}", i, inputNum - i, inputNum);
                    }
                    break;
                }
                catch {
                    Console.WriteLine("Your enter doesn't obey the rule!");
                    Console.Write("Please enter again:");
                    continue;
                }
            }
        }
    }
}
