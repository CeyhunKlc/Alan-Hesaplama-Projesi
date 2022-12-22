using System;

namespace AlanHesaplama
{ 
    class rectangleArea
    { 
         public static void rectangle()
        {
            Console.WriteLine("Radius Enter:");
            double RectangleRadius= Convert.ToInt32(Console.ReadLine());
            double RectangleArea= Math.PI*RectangleRadius*RectangleRadius;
            Console.WriteLine("Rectangle Area:"+ RectangleArea);
            Console.ReadLine();

        }
    }
}