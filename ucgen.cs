using System;

namespace AlanHesaplama
{
    public class TriangleArea 
    {
        public static void Triangle()
        {
            Console.WriteLine("Radius Enter   :");
            double TriangleRadius = Convert.ToInt32(Console.ReadLine());
            double TriangleArea = Math.PI * TriangleRadius * TriangleRadius;
            Console.WriteLine("Triangle Area:" + TriangleArea);
            Console.ReadKey();
        }
    }
}