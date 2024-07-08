using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Drawing;

namespace Assingment06
{
    internal class Program

    {
        #region Question01 Enum
        //Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.
        //Then, write a C# program that prints out all the days of the week using this enum.

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        #endregion

        #region Question02 Enum
        //Create an enum called "Season" with the four seasons(Spring, Summer,Autumn, Winter) as its members.
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }


        #endregion

        #region Question03 Enum
        public enum Permissions
        {
            None = 0,
            Delete = 1,
            Execute = 2,
            Read = 4,
            Write = 8
        }
        #endregion


        #region Question04 Enum
        // Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members
        enum Colors
        {
            Red,
            Green,
            Blue,
            Yellow,
            Orange,
            Purple,
            Brown,
            Black,
            White
        }
        #endregion

        #region Question05 Struct
        //Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double _x, double _y)
            {
                X = _x;
                Y = _y;
            }

            public double DistanceTo(Point otherPoint)
            {
                return Math.Sqrt(Math.Pow(X - otherPoint.X, 2) + Math.Pow(Y - otherPoint.Y, 2));
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Question01
            //Write a C# program that prints out all the days of the week using this enum.
            //foreach (var day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Question02
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons (spring march to may , summer june to august, autumn September to November, winter December toFebruary)

            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string input = Console.ReadLine();
            //Season season;

            //if (Enum.TryParse(input, true, out season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine( $"The region of {season} are from March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine($"The region of {season} are from June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine($"The region of {season} are from September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine($"The region of {season} are from December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}
            #endregion

            #region Question03
            // Initial permissions: None
            //Permissions userPermissions = Permissions.None;

            //// Add Read and Write permissions
            //userPermissions = AddPermission(userPermissions, Permissions.Read);
            //userPermissions = AddPermission(userPermissions, Permissions.Write);
            //Console.WriteLine($"Current permissions: {userPermissions}");

            //// Remove Read permission
            //userPermissions = RemovePermission(userPermissions, Permissions.Read);
            //Console.WriteLine($"Current permissions after removing Read: {userPermissions}");

            //// Check if Write permission exists
            //bool hasWritePermission = HasPermission(userPermissions, Permissions.Write);
            //Console.WriteLine($"Has Write permission: {hasWritePermission}");

            //// Check if Execute permission exists
            //bool hasExecutePermission = HasPermission(userPermissions, Permissions.Execute);
            //Console.WriteLine($"Has Execute permission: {hasExecutePermission}");
            #endregion

            #region Question04 
            // Write a C# program that takes a color name as input from
            //the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color name: ");
            //string input = Console.ReadLine();
            //Colors color;

            //if (Enum.TryParse(input, true, out color))
            //{
            //    switch (color)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine($"{color} is a primary color.");
            //            break;
            //        default:
            //            Console.WriteLine($"{color} is not a primary color.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid color entered.");
            //}

            #endregion

            #region Question05
            //Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("Enter the coordinates for the first point (X Y): ");
            //var input1 = Console.ReadLine().Split();
            //Point p1 = new Point(double.Parse(input1[0]), double.Parse(input1[1]));

            //Console.WriteLine("Enter the coordinates for the second point (X Y): ");
            //var input2 = Console.ReadLine().Split();
            //Point p2 = new Point(double.Parse(input2[0]), double.Parse(input2[1]));

            //double distance = p1.DistanceTo(p2);
            //Console.WriteLine($"The distance between the two points is: {distance}");

            #endregion




        }
        #region Question03 Functions
        public static Permissions AddPermission(Permissions currentPermissions, Permissions newPermission)
        {
            // Add the new permission using bitwise OR
            return currentPermissions | newPermission;
        }

        public static Permissions RemovePermission(Permissions currentPermissions, Permissions removePermission)
        {
            // Remove the permission using bitwise AND and bitwise NOT
            return currentPermissions & ~removePermission;
        }

        public static bool HasPermission(Permissions currentPermissions, Permissions checkPermission)
        {
            // Check if the permission exists using bitwise AND
            return (currentPermissions & checkPermission) == checkPermission;
        } 
        #endregion
    }
}