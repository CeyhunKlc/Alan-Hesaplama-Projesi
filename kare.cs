using System;

namespace AlanHesaplama
{
    public class squareArea
    {
        public static void square()
        {
            Console.WriteLine("Radius Enter  :");
            double SquareRadius = Convert.ToInt32(Console.ReadLine());
            double SquareArea = Math.PI * SquareRadius * SquareRadius;
            Console.WriteLine("Square Area:" + SquareArea);
            Console.ReadKey();
        }
    }
}