using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
   
    class Test19
    {
        delegate void myder();
        static private event myder me;
        static void Test()
        {
            me += printa;
            me += printb;
            me += printc;

        }
        static void printa()
        {
            Console.WriteLine("a");
        }
        static void printb()
        {
            Console.WriteLine("b");
        }
        static void printc()
        {
            Console.WriteLine("c");
        }
        static void Main()
        {
            Test();
            me();
        }
    }
}
