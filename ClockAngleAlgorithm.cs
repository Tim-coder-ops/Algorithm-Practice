using System;
using System.Reflection.Metadata.Ecma335;

namespace ClockAngleAlgo
{
    class ClockAngleAlgorithm
    {
        /*
         * Write a method that will take the time on a clock and then
         * return the angle of the hands.
         */

        //need 360 - hour hand place
        //need 360 - hour hand - minute hand


        //method based off of two integers being passed
        static int ClockAngle(int hour, int minute)
        {
            if(minute == 60)
            {
                hour += 1;
                minute = 0;
            }
            int hourShift = 360 - (hour * 360/12);
            int angle = 360 - (minute * 360 / 60) - hourShift;

            if (angle > 180) angle = 360 - angle;

            return angle;
        }

        //method based off of date time.
        static double CalculateAngle(DateTime input)
        {
            double inputMinute = input.Minute;
            double inputHour = input.Hour;
            double result = Math.Abs(360 - (inputHour * 360 / 12) - (inputMinute * 360 / 60));

            if (result > 180) result = 360 - result;

            return result;
        }

        //method that accounts for hour hand shift
        static double ClockAngleWithHourShift(double hour, double minute)
        {
            if (minute == 60)
            {
                hour += 1;
                minute = 0;
            }

            double hourShift = (360 - (hour * 360 / 12) - (30.0/60.0 * minute));
            double angle = 360 - (minute * 360 / 60) - hourShift;

            if (angle > 180) angle = 360 - angle;

            return angle;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Method based off passing 2 integers:");
            Console.WriteLine(ClockAngle(12,20));
            Console.WriteLine("Method based off of passing date time:");
            DateTime time = new DateTime(2020, 08, 13, 12, 20, 00);
            Console.WriteLine(CalculateAngle(time));
            Console.WriteLine("Method based off of integers that accounts for hour hand shift:");
            Console.WriteLine(ClockAngleWithHourShift(12,20));
            
            

        }
    }
}
