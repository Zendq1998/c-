using System;

public class TestMain
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(37, 43, 2.5);
       
        Console.WriteLine("该圆的圆心的坐标是:{0},{1}", circle.X, circle.Y);
        circle.X = 20;
        circle.Y = 20;

        Console.WriteLine("该圆的新圆心坐标是:{0},{1}", circle.X, circle.Y);

        // 打印圆的周长
        Console.WriteLine("该圆的周长是:{0}", circle.CircumFerence());

        // 打印圆的面积
        Console.WriteLine("该圆的面积是:{0}", circle.Area());

        // 创建圆柱体的实例1
        Cylinder cylinder1 = new Cylinder(circle, 3);
        Console.WriteLine("圆柱体1的体积是:{0}", cylinder1.CylinderBulk());

        // 创建圆柱体实例2
        Cylinder cylinder2 = new Cylinder();
        Console.WriteLine("圆柱体2的体积是:{0}", cylinder2.CylinderBulk());

        // 创建圆柱体实例3
        Cylinder cylinder3 = new Cylinder(1, 1, 2, 1);
        Console.WriteLine("圆柱体3的体积是:{0}", cylinder3.CylinderBulk());

        Console.ReadLine();
    }
}
