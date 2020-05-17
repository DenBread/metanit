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
            int a = 5;
            Console.WriteLine($"Начальное значение переменной a = {a}");
            IncrementRef(ref a);
            Console.WriteLine($"Переменная А после передачи ссылке равна = {a}");


            Console.ReadLine();
            
        }
        
        static void IncrementRef(ref int x)
        {
            x++;
            x = 5 + x;
            Console.WriteLine($"IncrementRef: {x}");
        }
    }
}
