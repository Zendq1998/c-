using System;
/*
 * 对学员对结业考试成绩评测
 */
namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string scoreStr;
            int score;
            char level;
            while (true) {
                Console.Write("Please enter your score(type \"qa!\" to exit):");
                scoreStr = Console.ReadLine();
                if (scoreStr == "qa!") {
                    break;
                }
                try {
                    score = int.Parse(scoreStr);
                }
                catch {
                    Console.WriteLine("Enter type error!");
                    continue;
                }
                if (score > 100 || score < 0) {
                    Console.WriteLine("Your grade is wrong!");
                    continue;
                }
                if (score >= 90){
                    level = 'A';
                }
                else if (score >= 80) {
                    level = 'B';
                }
                else if (score >= 70) {
                    level = 'C';
                }
                else if (score >= 60) {
                    level = 'D';
                }
                else {
                    level = 'E';
                }
                Console.WriteLine("Your grade level id {0}.", level);
            }
        }
    }
}
