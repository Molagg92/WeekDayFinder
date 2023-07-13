using System;
using System.Collections.Generic;
using WeekdayChecker.Models;

namespace WeekdayChecker
{
    class Program
    {
        static void Main()
        {
    
        Console.WriteLine("The curret date is " + TimeMachine.dateOnly + ", " + TimeMachine.today);
        Console.WriteLine("Next Year will be " + TimeMachine.dateOnly.AddYears(1));
        Console.WriteLine("Last Year was " + TimeMachine.dateOnly.AddYears(-1));

        Console.WriteLine(TimeMachine.dateOnly.AddDays(1).DayOfWeek);
      
        }
    }}
