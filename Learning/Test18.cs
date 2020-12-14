using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class A : IEnumerable
    {
        private int[] array = new int[10];

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return array[i];
            }
        }
    }
    class Test18
    {
        //static void Main()
        //{
        //    A a = new A();
        //    foreach(var i in a)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}
