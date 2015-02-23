//  Problem 4. Triangle surface

//  Write methods that calculate the surface of a triangle by given:
//      Side and an altitude to it;
//      Three sides;
//      Two sides and an angle between them;
//      Use System.Math.

using System;

    class TriangleSurface
    {
        static void Main()
        {
            Console.WriteLine("Triangel Surface\n");

            //SideAndAltitude();
            //ThreeSides();
            TwoSaidsAndAngle();
        }

        static void SideAndAltitude()
        {
            Console.WriteLine("Triangle's surface by side and an altitude to it\n");

            Console.Write("Enter the size of the side: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of the altitude: ");
            int h = int.Parse(Console.ReadLine());

            int result = (b * h)/2;
            
            Console.WriteLine("Triangle's surface is: {0}", result);
        }

        static void ThreeSides()
        {
            Console.Write("Enter the size of a: ");
            double a = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of b: ");
            double b = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of c: ");
            double c = int.Parse(Console.ReadLine());

            double perimeter = a + b + c;
            double p = perimeter / 2;

            double formula = p * (p - a) * (p - b) * (p - c);

            Console.WriteLine("Triangle's surface is: {0:0.00}", Math.Sqrt(formula));
        }

        static void TwoSaidsAndAngle()
        {
            Console.Write("Enter the size of a: ");
            double a = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of b: ");
            double b = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of the angle alfa: ");
            double alfa = int.Parse(Console.ReadLine());

            double size = ((a * b) / 2) * Math.Sin(alfa);

            Console.WriteLine("Triangle's surface is: {0:0.00}", size);


        }
    }