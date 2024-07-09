using System;

namespace OOP_ASS1
{
    internal struct Point
    {
        public double x;
        public double y;

       


    }
    public enum weekdays
    {
        Monday=1,Tuesday=2,Wednesday=3,Thursday=4,Friday=5,Saturday=6,Sunday=7
    }
    public enum season
    {
        spring=1, summer=2, automn=3, winter=4 
    }
    public enum colors
    {
        Red,Green, Blue
    }
    internal class Program
    {
        public static double CalculateDistance(Point p1, Point p2)
        {
            double distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            return distance;
        }

        static void Main(string[] args)
        {
            /* Create an enum called "WeekDays" with the days of the week
             * (Monday to Sunday) as its members. Then, write a C# program
             * that prints out all the days of the week using this enum.*/
            #region question1  
            //weekdays x = (weekdays)1;
            //weekdays y = (weekdays)2;
            //weekdays z = (weekdays)3;
            //weekdays a = (weekdays)4;
            //weekdays b = (weekdays)5;
            //weekdays c = (weekdays)6;
            //weekdays d = (weekdays)7;
            //Console.WriteLine($"the weekdays id{x} {y} {z} {a} {b} {c} {d}"); 
            #endregion

            #region Question2
            //bool flag;


            //  Console.Write("please enter a season:-");
            // string seasoninput=Console.ReadLine();
            //  flag=  Enum.TryParse(seasoninput, true, out season season);
            //if (flag == true)
            //{
            //    switch (season)
            //    {
            //        case season.spring:
            //            Console.WriteLine("Month Range: March - May");
            //            break;
            //        case season.summer:
            //            Console.WriteLine("Month Range: June - August");
            //            break;
            //        case season.automn:
            //            Console.WriteLine("Month Range: September - November");
            //            break;
            //        case season.winter:
            //            Console.WriteLine("Month Range: December - February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }


            //}
            //else Console.WriteLine("INVALID INPUT"); 
            #endregion

            /* Create an enum called "Colors" with the basic colors (Red, Green, Blue)
             * as its members. Write a C# program that takes a color name as input from
             * the user and displays a message indicating whether the input color is a 
             * primary color or not.*/
            #region Question4
            //Console.WriteLine("Pease Enter a Color");
            //string inputcolor = Console.ReadLine();
            //bool flag = Enum.TryParse(inputcolor, true, out colors colors);
            //if (flag == true)
            //{
            //    switch (colors)
            //    {
            //        case colors.Red:
            //            Console.WriteLine("this is a primary color");
            //            break;
            //        case colors.Green:
            //            Console.WriteLine("this is a primary color");
            //            break;
            //        case colors.Blue:
            //            Console.WriteLine("this is a primary color");
            //            break;
            //        default:
            //            Console.WriteLine("this color is not primary");
            //            break;
            //    }
            //}
            //else Console.WriteLine("INVALID INPUT"); 
            #endregion
            /* Create a struct called "Point" to represent
             * a 2D point with properties "X" and "Y". Write 
             * a C# program that takes two points as input from 
             * the user and calculates the distance between them.
*/
            #region Question5
            //Console.WriteLine("enter the first coordinates");
            //Point p1 = new Point();
            //p1.x = Convert.ToDouble(Console.ReadLine());
            //p1.y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("enter the second coordinates");
            //Point p2 = new Point();
            //p2.x = Convert.ToDouble(Console.ReadLine());
            //p2.y = Convert.ToDouble(Console.ReadLine());

            //double distance = CalculateDistance(p1, p2);
            //Console.WriteLine($"the distance between two points is {distance}"); 
            #endregion

        }

    }
}
