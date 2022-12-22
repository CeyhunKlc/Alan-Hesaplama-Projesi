using System;

namespace AlanHesaplama
{ 
    class circleArea
    { 
        public static void circle()
        { 
            Console.WriteLine("Radius Enter  :");
            double CircleRadius=Convert.ToInt32(Console.ReadLine());
            double CircleArea=Math.PI*CircleRadius*CircleRadius;
            Console.WriteLine("Circle Area:"+ CircleArea);
            Console.ReadKey();
        }
    }
}