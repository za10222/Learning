using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class Test16
    {
        static void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        //static void Main()
        //{
        //    int a = 1;
        //    int b = 2;
        //    Swap<int>(ref a,ref  b);
        //    Console.WriteLine($"{b},{a}");
        //}
    }
}
