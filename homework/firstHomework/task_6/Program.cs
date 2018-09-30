using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int thisYear = 2016;
            double stuNum = 80000;
            int yearIncreased = 0;
            while (stuNum < 200000) {
                stuNum *= 1.25;
                yearIncreased += 1;
            }
            Console.WriteLine("When {0}, the student number will arrive 200000", thisYear + yearIncreased);
        }
    }
}
