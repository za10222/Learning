using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    static class w
    {
        public static void print3(this Test11.a x)
        {
            Console.WriteLine(3);
        }
    }
    class Test11
    {
       
         public class a
        {
            protected int m_print2()
            {
                return 0;
            }
            public void print2()
            {
                Console.WriteLine(m_print2());
            }
            protected virtual int m_print()
            {
                return 0;
            }
            public void print()
            {
                Console.WriteLine(m_print());
            }
        }
        public class b :a
        {
            protected new int m_print2()
            {
                return 1;
            }
            protected override int m_print()
            {
                return 1;
            }
 
        }
        //static void Main()
        //{
        //    a x = new a();
        //    b y = new b();
        //    x.print();
        //    y.print();
        //    x.print2();
        //    y.print2();
        //    x.print3();
        //    y.print3();
        //}
    }
}
