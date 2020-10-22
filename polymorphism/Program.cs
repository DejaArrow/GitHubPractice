using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int addedSumOfInt = AddTwoInts(7, 13);
            Console.WriteLine("Int: " + addedSumOfInt);
        }

        static int AddTwoInts(int x, int y)
        {
            return x + y;
        }
    }
}
