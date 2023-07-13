using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WeekdayChecker.Models;

namespace Finder.Test
{
  [TestClass]
  public class FinderTests
  {
    [TestMethod]
    public void DayOnly_ReturnsTodaysDate_7_12_2023()
    {
      //Arrange
      DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);

      //Act
       string today = "7/12/2023";

      //Assert
       Assert.AreEqual(dateOnly, today);
    }

  }
}