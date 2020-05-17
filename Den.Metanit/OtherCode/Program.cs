using System;

namespace OtherCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients c = new Clients();
            c[0] = "Dave";
            c[1] = "Den";

            Console.WriteLine(c[1]);

            Box b = new Box(2, 2);
            b.BoxInfo();

            Console.ReadLine();
        }
    }
}
