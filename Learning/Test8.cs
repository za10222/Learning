using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    enum Myenum {a,b,c,d };
    struct Mystruct
    {
        private int val;
        public Circle c;

        private static int count=0;

        public Mystruct(int a) { 
            this.val = a;
            c = new Circle(a);
            count++;
        }

        public int Val { get => val; set => val = value; }

        public static void Count()
        {
            Console.WriteLine(count);
        }
    }
    class Test8
    {
        //static void Main()
        //{
        //    Myenum a;
        //    a = Myenum.a;
        //    Console.WriteLine(a);
        //    Mystruct b=new Mystruct(1);
        //    Console.WriteLine(b.Val);
        //    Mystruct.Count();
        //    Mystruct c = b;
        //    c.Val = 2;
        //    c.c.Radius = 2;
        //    Console.WriteLine($"b val={b.Val} radius={b.c.Radius}");
        //    Console.WriteLine($"c val={c.Val} radius={c.c.Radius}");

        //}
    }
}
