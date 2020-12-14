using System;
using System.Collections.Generic;
using System.Text;
namespace Learning
{
    class Test7
    {
        static void  Add(ref int a)
        {
            a++;
        }

        static void Add(Circle a)
        {
            a.Radius++;
        }
        static void Add1(out int a)
        {
            a = 0;
            a++;
        }
        //static void Main()
        //{
        //    int a = 1;
        //    int b = a;
        //    b = 2;
        //    System.Console.WriteLine($"a={a},b={b}");
        //    var c = new Circle(1);
        //    var d = c;
        //    d.Radius = 2;
        //    System.Console.WriteLine($"c={c.Area()},c={d.Area()}");
        //    var e = c.Clone();
        //    e.Radius = 3;
        //    System.Console.WriteLine($"e={e.Area()},c={c.Area()}");


        //    int? f = null; 
        //    if(f==null)
        //    {
        //        f = 2;
        //    }
        //    System.Console.WriteLine($"f={f}");
        //    if (f.HasValue)
        //    {
        //        f = 2;
        //    }else
        //    {
        //        System.Console.WriteLine($"f={f.Value}");
        //    }

        //    int g = 0;
        //    Add(ref g);
        //    Console.WriteLine($"g={g}");
        //    int h;
        //    Add1(out h);
        //    Console.WriteLine($"h={h}");
        //    System.Console.WriteLine($"e={e.Area()}");
        //    Add(e);
        //    System.Console.WriteLine($"e={e.Area()}");
        ////}
    }
}
