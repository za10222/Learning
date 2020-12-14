using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class Test13:IDisposable
    {
        public Test13()
        {
            Console.WriteLine("created");
        }
        
        ~Test13()
        {
            Console.WriteLine("delete");
            this.Dispose();
        }

        public void Dispose()
        {
            Console.WriteLine("dispose");
        }
        //static void Main()
        //{
        //    using (Test13 a=new Test13())
        //    {

        //    }
        //    Console.WriteLine("end");
        //}
    }
}
