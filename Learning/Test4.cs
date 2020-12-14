using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class Test4
    {
        static void Fortest(int a)
        {
            int sum = 0;
            for (int i = 0; i <= a; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void Dowhiletest(int a)
        {
            int i = 0;
            int sum = 0;
            do
            {
                sum += i;
                i++;
            }
            while (i < a);
            Console.WriteLine(sum);
        }
        //static void Main(string[] args)
        //{
        //    Fortest(10);
        //    Dowhiletest(10);
        //}
    }
}
