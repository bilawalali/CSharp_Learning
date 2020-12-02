using System;
using System.Collections.Generic;
using System.Text;

namespace TestProgram1
{
    class DateTimeLectures
    {

        public void DateLecture()
        {
            //datetime and Timespan are structures and both are immutable.
            // datetime object are immutable so if we add year to our current datetime object with dateTime.AddYear(1) , it will have no effect on the value of the date because it is immutable.
            var dateTime = new DateTime(2020, 11, 29);
            Console.WriteLine(DateTime.Now.Year);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine("");
            Console.WriteLine(now);
            Console.WriteLine("");
            var a=now.AddHours(2);
            Console.WriteLine("");
            Console.WriteLine(a);
            Console.WriteLine(today);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine("");
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine("");
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine("");
            Console.WriteLine(now.ToShortDateString());

            Console.WriteLine("");
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss:Z"));

        }
        public void TS()
        {


            //var timeSpan = new TimeSpan(1, 2, 3);
            // Time span is 1 hour , 2 minutes and 3 seconds.
            var timeSpan1 = new TimeSpan(1,2,3);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("timeSpan1:" + timeSpan1);

            //var start = DateTime.Now;
            //Console.WriteLine("start: " + start );
            var end = DateTime.Now;
            Console.WriteLine("end: " + end);
            var diff = end + timeSpan1;
            Console.WriteLine("diff: " + diff);


            //Properties of Timespan , Minutes returns the minutes only , TotalMinutes return the total minutes of the timespan object

            //Minutes property of the timespan
            var minutes =timeSpan1.Minutes;
            Console.WriteLine("Minutes : " + minutes);
            Console.WriteLine("");
            //Total Minutes in the time span object
            var tot_minutes = timeSpan1.TotalMinutes;
            Console.WriteLine("Total Minutes of the time span: " + tot_minutes);
            Console.WriteLine("");
            //Total seconds in the time span object
            var tot_seconds = timeSpan1.TotalSeconds;
            Console.WriteLine("Total seconds of the time span: " + tot_seconds);
            Console.WriteLine("");
            //Total Minutes in the time span object
            var tic = timeSpan1.Ticks;
            Console.WriteLine("Total ticks of the time span: " + tic);

            // Adding new value to the original TimeSpan

            var timeSpan = timeSpan1.Add(TimeSpan.FromHours(1));
            Console.WriteLine("Added 1 hour in original timespan: " + timeSpan);

            // Subtracting a value from the original TimeSpan

            var ntimeSpan = timeSpan1.Subtract(TimeSpan.FromMinutes(30));
            Console.WriteLine("Subtracted 30 minutes from the original timespan: " + ntimeSpan);

            // Conversion of the TimeSpan ToString, Converts the value of the current TimeSpan object to its string representation.
            Console.WriteLine("");
            Console.WriteLine("ToString: " + timeSpan1.ToString());

            //Parse Timespan

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }

        public void Parse_Test()

        {

            string[] values = {"6:12:00","00:11:12","12:13:11","1:22:2" };

            foreach (var v in values)
            {
                Console.WriteLine("Parse: " + TimeSpan.Parse(v));
             
            }
        
        
        }






    }
}
