using System;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            int Length = 10;
            int Width = 20;

            int Area = Area(length, width);

            Console.WriteLine("The area is: " + Area);

        }
        static int Area(int length, int width) 
        {
            return length * width;
        }
    }
}
