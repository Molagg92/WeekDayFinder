using System;
using System.Collections.Generic;


namespace WeekdayChecker.Models
{

  public class TimeMachine
  {
    public static DateTime d = DateTime.Now;

    public static DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);

    public static DayOfWeek today = DateTime.Today.DayOfWeek;
  }
}


