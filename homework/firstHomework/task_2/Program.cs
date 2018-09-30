using System;
/*
 * 盖茨买了一筐鸡蛋，如果坏蛋少于5个，他就吃掉，否则他就去退货
 */
namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string badEggsNumStr;
            int badEggsNum;
            Console.Write("Please enter the num of Gate's bad eggs:");
            while(true) {
                badEggsNumStr = Console.ReadLine();
                try {
                    badEggsNum = int.Parse(badEggsNumStr);
                }
                catch {
                    Console.WriteLine("Enter type error!");
                    Console.Write("Please enter again:");
                    continue;
                }
                if (badEggsNum < 0) {
                    Console.WriteLine("Your enter doesn't obey the rule!");
                    Console.Write("Please enter again:");
                    continue;
                }
                if (badEggsNum < 5) {
                    Console.WriteLine("Gate will eat them!");
                }
                else {
                    Console.WriteLine("Gate will return them!");
                }
                break;
            }
        }
    }
}
