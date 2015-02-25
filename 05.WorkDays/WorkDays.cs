//  Problem 5. Workdays

//  Write a method that calculates the number of workdays between today and given date, passed as parameter.
//  Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class WorkDays
{
    static void Main()
    {


        int days = 0; //user input

        int year = 2015;
        int month = 5;
        int day = 7;

        DateTime oldDate = new DateTime(year, month, day); //2002, 7, 15
        DateTime newDate = DateTime.Now;

        // Difference in days, hours, and minutes.
        TimeSpan ts = oldDate - newDate;
        // Difference in days.
        int differenceInDays = ts.Days;

        Console.WriteLine("Difference in days: {0} ", differenceInDays);

        int weekdays = (differenceInDays / 7) * 5;

        Console.WriteLine("Difference in weekdays: {0} ", weekdays);




        DateTime today = DateTime.Now;
        DateTime answer = today.AddDays(days);
        Console.WriteLine("Today: {0}", today);
        Console.WriteLine("{0} days from today: {1}", differenceInDays, answer);
    }


    
        
    
}
    
