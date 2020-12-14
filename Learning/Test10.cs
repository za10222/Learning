using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class Test10
    {
        static void Paratest(params int[] a)
        {
            int sum = 0;
            foreach(var i in a)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void Paratest(int a,params int[] b)
        {
            int sum = 0;
            foreach (var i in b)
            {
                sum += i;
            }
            sum += a;
            Console.WriteLine("type2");
            Console.WriteLine(sum);

        }
        //static void Main()
        //{
        //    Paratest(1, 3, 4, 5);
        //    Paratest(1);
        //}
    }
}
