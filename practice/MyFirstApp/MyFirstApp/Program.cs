using System;

namespace MyFirstApp // 逻辑空间，在同一个namespace里面可以做类和类的联系处理
{
    /// <summary>
    /// 对文件的说明
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
# region
            Console.WriteLine("Hello World!");
            string abc = Console.ReadLine();
# endregion
            Console.WriteLine("打印出来" + abc);
            int c = Add(3, 5);
            Console.WriteLine("3+5值是" + c);
            Console.ReadLine();
        }

        static int Add(int a, int b) {
            return a + b;
        }
    }
}
