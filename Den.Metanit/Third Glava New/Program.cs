using System;
using Third_Glava_New.AccountSpace;
using static System.Console;
using static System.Math;
using static Third_Glava_New.Geometry;
using TestLibrary;

namespace Third_Glava_New
{
    class Program
    {
        static void Main(string[] args)
        {


            Account account = new Account(4);
            WriteLine("Hello mathefucker");

            double radius = 50;
            double result = GetArea(radius); // Geometry.GetArea
            WriteLine(result); // Console.WriteLine
            Read(); // Console.Read
        }
    }

    class Geometry
    {
        public static double GetArea(double radius)
        {
            return PI * radius * radius; // Math.PI
        }
    }

    namespace AccountSpace
    {
        class Account
        {
            public int Id { get; private set; } //номер счета
            public Account(int _id)
            {
                Id = _id;
            }
        }
    }
}
