﻿//  Problem 3. Day of week

//  Write a program that prints to the console which day of the week is today.
//  Use System.DateTime.

using System;

    class DayOfWeek
    {
        static void Main()
        {
            Console.WriteLine("Day Of Week\n");

            DateTime dateValue = DateTime.Now; //there is a method for that too ;)
            Console.WriteLine("Today is: {0}", (dateValue.ToString("dddd")));
        }
    }