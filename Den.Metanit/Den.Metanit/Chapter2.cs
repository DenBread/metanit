using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den.Metanit
{
    /// <summary>
    /// Класс посвящен полностью 2 главе
    /// </summary>
    class Chapter2

    {

        /// <summary>
        /// Этот метод преветсвует тебя
        /// </summary>
        internal static void Greeting()
        {
            Console.WriteLine("Здаров, Илюха!");
            Console.WriteLine("Это начало 2 главы");
            // там рассказываеться про структуру программы, методы, регистрозависимость и коментарии
        }

        /// <summary>
        /// Метод вызывит имя "Ден", а потом "Илья"
        /// </summary>
        internal static void Variables()
        {
            // тип имя_переменной

            string name;
            string Name;

            // name и Name - это разные переменные, потому что C# являеться регистрозависимый

            name = "Ден";
            Console.WriteLine(name);

            name = "Илья";
            Console.WriteLine(name);
        }

        internal static void Literals()
        {
            // Литералы бывают логическими, целочисленными, вещественными, символьными и строчными

            Console.WriteLine("***Логический литерал***");
            Console.WriteLine(true);
            Console.WriteLine(false);


            Console.WriteLine("\n***Целочисленные литералы***");
            Console.WriteLine(-777);
            Console.WriteLine(666);

            // шестнадцатеричной форме
            Console.WriteLine(0xFF);   // 0.12


            Console.WriteLine("\n***Вещественные литералы***");
            Console.WriteLine(1.2E-1);


            Console.WriteLine("\n***Символьные литералы***");
            Console.WriteLine('2');
            Console.WriteLine('T');
            Console.WriteLine('\x5A'); // Z

            Console.WriteLine("\n***Строковые литералы***");
            Console.WriteLine("hey boy!");
            Console.WriteLine("если скажешь нигга, boy");
            Console.WriteLine("нигга пустит трига, boy");
        }
    }
}
