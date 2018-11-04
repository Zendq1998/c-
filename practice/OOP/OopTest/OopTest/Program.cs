using System;

namespace OopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入吃了多少");
            int eat = int.Parse(Console.ReadLine());

            Console.WriteLine("输入消化多少");
            int digest = int.Parse(Console.ReadLine());

            Animal animal = new Animal();
            int mounth = animal.CalMounth(eat, digest);
            int cost = animal.CalCost(eat, digest);

            Console.WriteLine("成长需的时间（月）" + mounth);
            Console.WriteLine("要花的钱：" + cost);
        }
    }
}
