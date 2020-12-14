using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    interface Protest
    { 
        int X { get; set; }
        int Y { get;  }
        int Z{ set; }


    }
    class Test14: Protest
    {
        int x;
        int y;
        public int X { 
            get { return x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return Y; }
        }
        public int Z
        {
            set { this.y = value; }
        }

        //static void Main()
        //{
        //    using (Test13 a = new Test13())
        //    {

        //    }
        //    Console.WriteLine("end");
        //}
    }
}
