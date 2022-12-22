using System;

namespace AlanHesaplama
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select The Shape You Want To Calculate");
            Console.WriteLine("**************************************************");
            Console.WriteLine("Circle                  (1)");
            Console.WriteLine("Triangle                (2)");
            Console.WriteLine("Square                  (3)");
            Console.WriteLine("Rectangle               (4)");

            int shape = Convert.ToInt32(Console.ReadLine());

            switch (shape)
            {
                case 1:
                    circleArea.circle();
                    break;

                case 2:
                    TriangleArea.Triangle();
                    break;

                case 3:
                    squareArea.square();
                    break;

                case 4:
                    rectangleArea.rectangle();
                    break;

                default:
                    ErrorMessage.Error();
                    break;
            }
        }
    }
}