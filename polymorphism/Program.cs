using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int addedSumOfInt = AddTwoInts(7, 13);
            double addedSumOfDoubles = AddTwoDoubles(7.5, 13.8);

            Console.WriteLine("Int: " + addedSumOfInt);
            Console.WriteLine("Double: " + addedSumOfDoubles);
        }

        static int AddTwoInts(int x, int y)
        {
            return x + y;
        }

        static double AddTwoDoubles(double x, double y)
        {
            return x + y;
        }
    }
}
