using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class Test2
    {
        static void Iftest(bool flag)
        {
            if (flag)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        static void Switchtest(char a)
        {
            switch(a)
            {
                case 'a':
                    Console.WriteLine("a");
                    break;
                case 'b':
                    Console.WriteLine("b");
                    break;
                case 'c':
                    Console.WriteLine("c");
                    break;
                default:
                    Console.WriteLine("ohter");
                    break;
            }
        }
        //static void Main(string[] args)
        //{
        //    Iftest(true);
        //    Iftest(false);
        //    Switchtest('a');
        //    Switchtest('b');
        //    Switchtest('c');
        //    Switchtest('d');
        //}
    }
}
