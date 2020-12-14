using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class Test3
    {
        static int Add(int a,int b)
        {
            var w = a + b;
            Console.WriteLine($"int add={w}");
            return w;
        }
        static float Add(float a, float b)
        {
            var w = a + b;
            Console.WriteLine($"float add={w}");
            return w;
        }
        //static void Main(string[] args)
        //{
        //    int x = 1, y = 2;
        //    float m = 2, n = 3;
        //    Add(x, y);
        //    Add(m, n);
        //}
    }
}
