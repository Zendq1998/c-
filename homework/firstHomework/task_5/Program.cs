using System;
/*
 * 李四的年终工作评定，如果为A级，则工资涨500;为B，涨200;为C，工资不;D，工资降200;E,降500元。
 * 假设李四的原工资为5000，请用户输入李四的评级，然后显式李四来年的工资。
 */
namespace task_5
{
    enum WageLevel {
        A = 500, B = 200, C = 0, D = -200, E = -500
    }

    class Program
    {
        static void Main(string[] args)
        {
            int wage = 5000;
            string levelStr;
            int wageChanged;
            Console.Write("Please enter the work level this year:");
            while (true) {
                levelStr = Console.ReadLine();
                try {
                    wageChanged = (int)Enum.Parse(typeof(WageLevel), levelStr);
                }
                catch {
                    Console.WriteLine("Your enter doesn't obey the rule!");
                    Console.Write("Please enter again:");
                    continue;
                }
                break;
            }
            Console.WriteLine("Lisi's new year wage is {0}", wage + wageChanged);
        }
    }
}
