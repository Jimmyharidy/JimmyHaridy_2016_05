using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JimmyHaridy_MVC_2016_05.Models
{
    public static class CurrentSpeed
    {
        public static double CalculateCurrentSpeed(string distanceInput, string timeInput)
        {
            var distance = double.Parse(distanceInput);
            var time = double.Parse(timeInput);
            var speed = distance/time;
            return speed;
        }
    }
}