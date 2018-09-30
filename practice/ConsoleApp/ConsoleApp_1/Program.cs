using System;

// 结构体
namespace ConsoleApp_1
{
    class Program
    {
        struct ComplexNumber
        {
            public double a;
            public double b;
            public void Write() {
                Console.WriteLine("{0}+{1}i",a,b);
            }
        }
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber();
            c1.a = 2.5;
            c1.b = 2;
            ComplexNumber c2 = c1;
            c1.Write();
            c2.Write();
            c2.a = 1.5;
            c2.b = 4;
            c1.Write();
            c2.Write();
            Console.ReadLine();
        }
    }
}
