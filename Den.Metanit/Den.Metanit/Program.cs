using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den.Metanit
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 15;
            GlavaSecond.Addition(ref x, y); // вызов метода
            Console.WriteLine(x);   // 25

           
            Console.ReadLine();
            
        }
    }
}
