using System;

namespace Learning
{
    class Circle
    {
        private int radius;
        static int count=0;

        public int Radius { get => radius; set => radius = value; }

        public Circle(int radius = 0)
        {
            this.Radius = radius;
            count++;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        static  public void Count()
        {
            Console.WriteLine(count);
        }
         public Circle Clone()
        {
            Circle clone = new Circle();
            clone.Radius = Radius;
            return clone;
        }
    }
}
