using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//圆柱体
public class Cylinder:Circle {
    private double h;
    public double H
    {
        get { return this.h; }
        set { this.h = value; }
    }

    public Cylinder() : base(0, 0, 1)
    {
        base.R = 1;
        this.h = 1;
    }

    public Cylinder(double x, double y, double r, double h) : base(x, y, r)
    {
        base.X = x;
        base.Y = y;
        base.R = r;
        this.h = h;
    }

    public Cylinder(Circle c, double h) : base(c.X, c.Y, c.R)
    {
        base.X = c.X;
        base.Y = c.Y;
        base.R = c.R;
        this.h = h;
    }

    // 返回圆柱的体积
    public double CylinderBulk()
    {
        return base.Area() * this.h;
    }
}




