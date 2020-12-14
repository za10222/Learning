using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
  
    class Test5
    {
        static void Addtest1()
        {
            int a = Int32.MaxValue;
            checked
            {
                a +=1;
                Console.WriteLine(a);
            }
        }
        static void Throwtest(bool flag )
        {
            if(flag)
            { throw new IndexOutOfRangeException(); }
        }
        static void Trytest(bool flag)
        {
            try
            {
                Throwtest(flag);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("flag is true");
            }
            finally
            {
                Console.WriteLine("final");
            }
        }
        //static void Main(string[] args)
        //{
        //    //Addtest1();
        //    Trytest(true);
        //    Trytest(false);
        //}
    }
}
