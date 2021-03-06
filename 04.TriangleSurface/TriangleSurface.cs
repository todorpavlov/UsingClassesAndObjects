﻿//  Problem 4. Triangle surface

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

            Console.WriteLine("Choose wisely: ");
            Console.WriteLine("1. Calculate size of a triangle by a side and the altitude to it");
            Console.WriteLine("2. Calculate size of a triangle by three sides");
            Console.WriteLine("3. Calculate size of a triangle by two sides and the angle between them");
            Console.Write("Choose between 1 and 3: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (n == 1)
            {
                SideAndAltitude();
            }
            if (n == 2)
            {
                ThreeSides();
            }
            if (n == 3)
            {
                TwoSaidsAndAngle();
            }
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