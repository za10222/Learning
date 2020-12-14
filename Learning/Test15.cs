using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    struct Myrawint
    {
        private int val;
        public Myrawint(int val)
        {
            this.val = val;
        }
        public bool this[int index]
        {
            get {
                return (val & (1 << index)) != 0;
            }
            set {
                if(value)
                {
                    val |= (1 << index);
                }
                else
                {
                    val &= ~(1 << index);
                }
            }
        }
    }
    class Test15
    {
        //static void Main()
        //{
        //    Myrawint a=new Myrawint(2);
        //    Console.WriteLine($"1={a[1]}");
        //    a[1] = false;
        //    Console.WriteLine($"1={a[1]}");
        //}
    }
}
