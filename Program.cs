//Programmer: Andy Chand
//Student Number: 0983026
//Program: Coordinate Converter

using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace CoordinateConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Outputs programmers student number, name, and a brief introduction to the program.
            Console.WriteLine("Name: Andy Chand\nStudent Number: 0983026");
            Console.WriteLine("Function: Convert decimal degrees into degrees, minutes, and seconds.\n");

            //A true/false statement to be used in the while loop to keep the programming looping if the user wants
            bool KeepLoop = true;
            //While loop to keep the programming running
            while (KeepLoop) 
            {
                //Two double variables to catch the user inputs for latitude and longitude
                double latVal;
                double longVal;

                //A command to get the user to submit a Latitude, followed by a check to see if the entered value is a double or not - returns a true or false
                Console.Write("Enter the Latitude - Use positive for North, negative for South:\n");
                var LatitudeVal = Console.ReadLine();
                bool parseSuccessLat = double.TryParse(LatitudeVal, out latVal);

                //An if statement to check if the entered latitude is a double and between -90 and 90 degrees
                if (parseSuccessLat == false || latVal > 90 || latVal < -90)
                {
                    //Outputs a statement to inform the user the value entered does not fall within the parameters and restarts the loop
                    Console.WriteLine("{0} is not a valid Latitude\n", LatitudeVal);
                    continue;
                }

                //A command to get the user to submit a Longitude, followed by a check to see if the entered value is a double or not - returns a true or false
                Console.Write("Enter the Longitude - Use positive for East, negative for West:\n");
                var LongitudeVal = Console.ReadLine();
                bool parseSuccessLong = double.TryParse(LongitudeVal, out longVal);

                //An if statement to check if the entered latitude is a double and between -180 and 180 degrees
                if (parseSuccessLong == false || longVal > 180 || longVal < -180)
                {
                    //Outputs a statement to inform the user the value entered does not fall within the parameters and restarts the loop
                    Console.WriteLine("{0} is not a valid Longitude\n", LongitudeVal);
                    continue;
                }

                //An if statement to check if both the Latitude and Longitude entered were doubles and returned a true when checked earlier
                if (parseSuccessLat & parseSuccessLong)
                {
                    //An if statment to do the calculations if the Latitude and Longitude are both positive
                    if (latVal >= 0 & longVal >= 0)
                    {
                        //Calculations to break the decimal value into degrees, minutes, and seconds for both the Latitude and Longitude
                        double degrees_lat = (Math.Floor(latVal));
                        double minutes_lat = (latVal - Math.Floor(latVal)) * 60;
                        double seconds_lat = (minutes_lat - Math.Floor(minutes_lat)) * 60;

                        minutes_lat = Math.Floor(minutes_lat);
                        seconds_lat = Math.Floor(seconds_lat);

                        double degrees_long = (Math.Floor(longVal));
                        double minutes_long = (longVal - Math.Floor(longVal)) * 60;
                        double seconds_long = (minutes_long - Math.Floor(minutes_long)) * 60;

                        minutes_long = Math.Floor(minutes_long);
                        seconds_long = Math.Floor(seconds_long);

                        Console.WriteLine("{0} Latitude, {1} Longitude:\n{2}° {3}' {4}'' North, {5} {6}' {7}'' East\n", latVal, longVal, degrees_lat, minutes_lat, seconds_lat,
                        degrees_long, minutes_long, seconds_long);
                    }

                    //An else if statement to check if the Longitude is negative
                    else if (latVal >= 0 & longVal < 0)
                    {
                        //Calculations to break the decimal value into degrees, minutes, and seconds for both the Latitude and Longitude
                        double degrees_lat = (Math.Floor(latVal));
                        double minutes_lat = (latVal - Math.Floor(latVal)) * 60;
                        double seconds_lat = (minutes_lat - Math.Floor(minutes_lat)) * 60;

                        minutes_lat = Math.Floor(minutes_lat);
                        seconds_lat = Math.Floor(seconds_lat);

                        double degrees_long = (Math.Ceiling(longVal));
                        double minutes_long = (longVal - Math.Ceiling(longVal)) * 60;
                        double seconds_long = (minutes_long - Math.Ceiling(minutes_long)) * 60;

                        minutes_long = Math.Abs(Math.Ceiling(minutes_long));
                        seconds_long = Math.Abs(Math.Ceiling(seconds_long));

                        //Outputs the calculations into a proper format
                        Console.WriteLine("{0} Latitude, {1} Longitude:\n{2}° {3}' {4}'' North, {5} {6}' {7}'' West\n", latVal, longVal, degrees_lat, minutes_lat, seconds_lat,
                        degrees_long, minutes_long, seconds_long);
                    }

                    //An else if statment to check if the Latitude is negative
                    else if (latVal < 0 & longVal > 0)
                    {
                        //Calculations to break the decimal value into degrees, minutes, and seconds for both the Latitude and Longitude
                        double degrees_lat = (Math.Ceiling(latVal));
                        double minutes_lat = (latVal - Math.Ceiling(latVal)) * 60;
                        double seconds_lat = (minutes_lat - Math.Ceiling(minutes_lat)) * 60;

                        minutes_lat = Math.Abs(Math.Ceiling(minutes_lat));
                        seconds_lat = Math.Abs(Math.Ceiling(seconds_lat));

                        double degrees_long = (Math.Floor(longVal));
                        double minutes_long = (longVal - Math.Floor(longVal)) * 60;
                        double seconds_long = (minutes_long - Math.Floor(minutes_long)) * 60;

                        minutes_long = Math.Floor(minutes_long);
                        seconds_long = Math.Floor(seconds_long);

                        //Outputs the calculations into a proper format
                        Console.WriteLine("{0} Latitude, {1} Longitude:\n{2}° {3}' {4}'' South, {5} {6}' {7}'' East\n", latVal, longVal, degrees_lat, minutes_lat, seconds_lat,
                        degrees_long, minutes_long, seconds_long);
                    }


                    //An else statement to catch when the Latitude and Longitude are both negative
                    else
                    {
                        //Calculations to break the decimal value into degrees, minutes, and seconds for both the Latitude and Longitude
                        double degrees_lat = (Math.Ceiling(latVal));
                        double minutes_lat = (latVal - Math.Ceiling(latVal)) * 60;
                        double seconds_lat = (minutes_lat - Math.Ceiling(minutes_lat)) * 60;

                        minutes_lat = Math.Abs(Math.Ceiling(minutes_lat));
                        seconds_lat = Math.Abs(Math.Ceiling(seconds_lat));

                        double degrees_long = (Math.Ceiling(longVal));
                        double minutes_long = (longVal - Math.Ceiling(longVal)) * 60;
                        double seconds_long = (minutes_long - Math.Ceiling(minutes_long)) * 60;

                        minutes_long = Math.Abs(Math.Ceiling(minutes_long));
                        seconds_long = Math.Abs(Math.Ceiling(seconds_long));

                        //Outputs the calculations into a proper format
                        Console.WriteLine("{0} Latitude, {1} Longitude:\n{2}° {3}' {4}'' South, {5} {6}' {7}'' West\n", latVal, longVal, degrees_lat, minutes_lat, seconds_lat,
                        degrees_long, minutes_long, seconds_long);
                    }

                    //Allows the user to close the program when they are done using it by ending the while loop.
                    Console.WriteLine("Press any key to continue, 'Q' to exit");
                    var UserWantsToContinue = Console.ReadLine();

                    //Allows the user to enter upper or lower case n when wanting to quit. Changes the entry to uppercase regardless before the check.
                    if ((KeepLoop = UserWantsToContinue.ToUpper() != "Q"))
                    {
                        //Loops the program if the user enters anything other than 'q' or 'Q'
                        continue;
                    }
                    //Else statment to close the application program if the user does want to quit
                    else
                    {
                        System.Environment.Exit(1);
                    }
                }
            }
        }
    }
}
