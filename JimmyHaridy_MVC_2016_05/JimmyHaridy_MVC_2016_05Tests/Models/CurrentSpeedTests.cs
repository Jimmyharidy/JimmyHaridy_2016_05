using Microsoft.VisualStudio.TestTools.UnitTesting;
using JimmyHaridy_MVC_2016_05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimmyHaridy_MVC_2016_05.Models.Tests
{
    [TestClass()]
    public class CurrentSpeedTests
    {
        [TestMethod()]
        [ExpectedException(typeof(FormatException))]
        public void CalculateCurrentSpeedTest_FormatError()
        {
            var distance = "hundra";
            var time = "tio";
            CurrentSpeed.CalculateCurrentSpeed(distance, time);
        }
        [TestMethod]
        public void CalculateCurrentSpeedTest_Correct()
        {
            var distance = "100";
            var time = "10";
            var actual = CurrentSpeed.CalculateCurrentSpeed(distance, time);
            var expected = 10;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CalculateCurrentSpeedTest_WithNull()
        {
            CurrentSpeed.CalculateCurrentSpeed(null, null);
        }

    }
}