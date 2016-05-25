//Description
//Write a method that calculates the number of workdays between today and
//a given date, passed as parameter.Consider that workdays are all days
//from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Collections;

class Workdays
{
    private static int count;
    private static int year;
    private static DateTime day;
    private static int workday;
    private static DateTime inputDay;

    static int WorkingDays(DateTime inputDay)
    {
        year = 2016;
        day = DateTime.Today;
        DateTime[] holidays = new DateTime[]
        {
           new DateTime (year,1,1),new DateTime (year,3,3),
           new DateTime (year,4,29),new DateTime(year,5,1),
           new DateTime (year,5,6),new DateTime (year,5,23),
           new DateTime (year,5,24),new DateTime (year,9,5),
           new DateTime (year,9,6),new DateTime (year,9,22),
           new DateTime (year,9,23),new DateTime (year,12,24),
           new DateTime(year,12,25),new DateTime (year,12,26),

        };
        
        for (int i = 0; i < 365; i++)
        {
            if (day != holidays[i])
            {
                workday++;
            }
            day = day.AddDays(1);
            if (day == holidays[i])
            {
                workday--;
            }
            if (day == inputDay)
            {
                break;
            }
        }
        
        return workday;
    }
    static void Main()
    {
        DateTime inputDay = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(WorkingDays(inputDay));
    }
}

