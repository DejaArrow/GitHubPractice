using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int addedSumOfInt = AddTwoNumbers(7, 13);
            double addedSumOfDoubles = AddTwoNumbers(7.5, 13.8);

            Console.WriteLine("Int: " + addedSumOfInt);
            Console.WriteLine("Double: " + addedSumOfDoubles);

            //animal section
            Animal animal = new Animal();
            animal.MakeAnimalSound();
        }

        static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        static double AddTwoNumbers(double x, double y)
        {
            return x + y ;
        }

      
    }
}
