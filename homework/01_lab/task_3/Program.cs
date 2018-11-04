using System;
/*
 * 明天小兰就要登台演出了，老师说再把明天的舞蹈表演一遍，如果满意，小兰就可以回家了，否则就需要再练习一遍，直到老师满意为止
 */
namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSatisfied = false;
            string answerStr;
            while(!isSatisfied) {
                Console.Write("Is the teacher satisfied?(yes or no):");
                answerStr = Console.ReadLine();
                if (answerStr.ToLower() == "yes") {
                    Console.WriteLine("Teacher is satisfied, Lan can go home!");
                    isSatisfied = true;
                }
                else if (answerStr.ToLower() == "no") {
                    Console.WriteLine("Teacher is not satisfied, Lan has to practice again...");
                    continue;
                }
                else {
                    Console.WriteLine("Your enter doesn't obey the rule!");
                    Console.WriteLine("Please enter again!");
                    continue;
                }
            }
        }
    }
}
