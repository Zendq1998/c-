using System;

/* 类型转换
 * 由低精度转换为高精度，不需要声明即可转换，叫做隐式转换
 * 由高精度转为低精度，需要声明，叫做显式转换（强制转换）
 */
namespace ConsoleApp_2
{
    class Student {}
    class Graduate: Student {}

    class Program
    {
        static Graduate g1 = new Graduate();
        static Student s1 = g1; // 引用类型之间的显式转换
        static Graduate g2 = (Graduate)s1; // 引用类型之间的隐式转换
        static void Main(string[] args)
        {
            byte a = 7;
            // 隐式类型转换
            long b = a;
            // 显式类型转换
            a = (byte)b;

            string x1 = "31415926";
            int y1 = int.Parse(x1);
            Console.WriteLine("y1的值是{0}", y1);
        }
    }
}
