using System;
using System.Collections.Generic;
using System.Text;
namespace StopWatch
{
    public class Watch
    {
        DateTime startTime = DateTime.Now;   //class level variable used in timespan
        DateTime stopTime = DateTime.Now;
        public void Start()
        {
            startTime = DateTime.Now;   // variable changed before timespan gets to it
        }
        public double Stop()
        {
            stopTime = DateTime.Now;
            return Math.Round(Convert.ToDouble((stopTime - startTime).TotalSeconds), 1); ;
        }
    }
}
