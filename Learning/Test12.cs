using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class Test12
    {
        interface Ilegnumber
        {
            int Legnumber();
            int Eat();

        }
        class Animal : Ilegnumber
        {

            int Ilegnumber.Eat()
            {
                return 0;
            }

              int Ilegnumber.Legnumber()
            {
                return 0;
            }
        }
    }
}
