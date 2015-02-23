//  Problem 2. Random numbers

//  Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

    class RandomNumbers
    {
        static void Main()
        {
            Console.WriteLine("Random Numbers\n");

            Console.WriteLine("10 random numbers within the range [100, 200]:");
            Random r = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                int numbers = r.Next(100, 200);
                Console.Write("{0}, ", numbers);
            }
            Console.WriteLine();
        }
    }