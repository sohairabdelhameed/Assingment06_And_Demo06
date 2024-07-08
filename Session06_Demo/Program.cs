// we added the project refrence from right clicking on the dependencies
//And choosing add project dependences
using Common;
using System.ComponentModel;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session06_Demo
{
    //What can we write inside the NameSpace?
    //1.Class
    //2.Struct
    //3.Interface
    //4.Enum
    //Access Modifier Allowed Inside Namespace?
    //1. Internal[Default]
    //2. Public
    internal class Program
    {

        //What You Can Write Inside The Struct Or Class
        //1. Attributes[Fields] => Member Variable  
        //2. Functions[Constructor, Getter Setter, Method]
        //3. Properties[Full Property, Automatic Property, Indexer]
        //4. Events

        //Access Modifier Allowed Inside Class?
        //Private[Default]
        //Private Protected
        //Protected
        //Internal
        //Protected Internal
        //Public

        #region Enum 
        //// An enum type is a special data type that enables for a variable to be a set of predefined constants

        //enum WeekDays
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //} 

        enum Grades
        {
            //Lables
            //the compiler store them as integers
            A, // stored as 0
            B,//1

            C, //2
            D //3
        }
        #endregion



        #region Exceptions Functions

        //static void DoSomeCode()
        //{
        //    //This is not protective code 
        //    //try
        //    //{
        //    //    int X, Y, Z;
        //    //    X = int.Parse(Console.ReadLine()); //If we entered a string and parse canot covert it we will get : System.FormatException
        //    //    Y = int.Parse(Console.ReadLine());
        //    //    Z = X / Y; // If user entered 0 in the Y we will get:  System.DivideByZeroException

        //    //    int[] Numbers = { 1, 2, 3 };
        //    //    Numbers[10] = 100; //System.IndexOutOfRangeException
        //    //}
        //    ////TryBlock: will try to run the code if there's exception the CLR will
        //    ////create object from class of the Exception
        //    ////Throw in catch Block

        //    //catch (Exception ex)
        //    //{
        //    //    Console.WriteLine(ex.Message);
        //    //    //Log In File 
        //    //    //Store in Database


        //    //}
        //}

        //static void DoSomeProductiveCode()
        //{
        //    int X, Y, Z;
        //    bool Flag;
        //    do
        //    {
        //        Console.WriteLine("Enter first number : ");
        //        Flag = int.TryParse(Console.ReadLine(), out X);
        //        // tryparse==> true - X = 10
        //        // tryparse==> False - X = 0 
        //    } while (!Flag);

        //    do
        //    {
        //        Console.WriteLine("Enter Second number : ");
        //        Flag = int.TryParse(Console.ReadLine(), out Y);
        //        // tryparse==> true - X = 10
        //        // tryparse==> False - X = 0 
        //    } while (!Flag || Y == 0);

        //    Z = X / Y;

        //    int[] Numbers = { 1, 2, 3 }; // size 3
        //    if (Numbers.Length > 10)
        //    {
        //        Numbers[10] = 100;

        //    }




        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Exceptions
            //// DoSomeCode();

            //// we will use the try catch block here as last line defense
            ////becuse if there is a case we didnot handle it
            //try
            //{
            //    int k = 10; // K acessable in the try scope only;
            //    DoSomeProductiveCode();
            //}
            //catch (Exception ex)
            //{
            //    //Log the Error
            //    Console.WriteLine(ex.Message);


            //}

            //finally
            //{
            //    //Note: Some Resources are not under the control of the CLR
            //    //It does the following:
            //    // close | Delete | Release | Deallocate umanaged Resoursce 
            //    //like to Open File and read from it some dATA the clr canot do any thing 
            //    // Connection with Database

            //    Console.WriteLine("FinallY"); // if there is no exception or there is exception it will print finally 
            //    //we will enter the finaly in both cases





            //}
            //Console.WriteLine("After Try Catch");





            #endregion

            #region AccessModifiers
            //we need to Import the library "common"
            //so we can Access the Type A class
            //After importing the library common:
            
            TypeA typeA = new TypeA(); //Class TypeA can be accessed since it is public 


            //TypeB typeB = new Common.TypeB(); //Invalid becuse type B is internal so its accessable inside its project only


            #endregion

            #region Enum Example1
            Grades gradesA = Grades.A;
            if (gradesA == Grades.A)
            {
                Console.WriteLine(":)");
            }
            #endregion

        }
    }
}
