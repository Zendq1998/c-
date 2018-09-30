using System;

// 枚举类型
namespace ConsoleApp
{
    class Program
    {
        enum Week:int{
            mon=1, tue=2, wed=3, thi=4, fri=5, sat=6, sun=0
        }
        enum Gender {
            Male, Female
        }
        static void Main(string[] args)
        {
            Gender g = Gender.Female;
            int k = (int)DateTime.Now.DayOfWeek;
            Console.WriteLine(k);
            switch(k) {
                case (int)Week.sun:
                    Console.WriteLine("今天是星期天");
                    break;
                case (int)Week.mon:
                    Console.WriteLine("今天是星期一");
                    break;
                case (int)Week.tue:
                    Console.WriteLine("今天是星期二");
                    break;
                case (int)Week.wed:
                    Console.WriteLine("今天是星期三");
                    break;
                case (int)Week.thi:
                    Console.WriteLine("今天是星期四");
                    break;
                case (int)Week.fri:
                    Console.WriteLine("今天是星期五");
                    break;
                case (int)Week.sat:
                    Console.WriteLine("今天是星期刘");
                    break;
            }
        }
    }
}
