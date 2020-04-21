using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Den.Metanit
{
    /// <summary>
    /// Класс посвящен полностью 2 главе
    /// </summary>
    class GlavaSecond

    {

        /// <summary>
        /// Этот метод преветсвует тебя
        /// </summary>
        internal static void Greeting()
        {
            Console.WriteLine("Здаров, Илюха!");
            Console.WriteLine("Это начало 2 главы");
            // там рассказываеться про структуру программы, методы, регистрозависимость и коментарии

            // Консольный ввод-вывод
            string hello = "Привет мир";
            Console.WriteLine(hello);
            Console.WriteLine("Добро пожаловать в С#, мать твою!ыыы");
            Console.WriteLine("Поцелуйте в мой металический зад...");
            Console.WriteLine(23.6);
            Console.WriteLine();

            Console.WriteLine("Нажми Y или N");
            string selection = Console.ReadLine().ToUpper();

            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали букву Y");
                    break;
                case "N":
                    Console.WriteLine("Вы нажали букву N");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }

            // Тернарный оператор 
            Console.WriteLine();

            int x = 3;
            int y = 2;
            Console.WriteLine("Нажмите + или -");
            string selection2 = Console.ReadLine();

            int z = selection2 == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);

            Console.WriteLine();
            Console.WriteLine();

            // Массывы 

            int[] numbers = new int[] {1, 2, 3, 4, 5};
            foreach (var n in numbers)
            {       
                Console.WriteLine(n);
            }

            int[] numbers2 = new int[]{1, 2, 3, 4, 5};
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers2[i] = numbers2[i] * 2;
                Console.WriteLine(numbers2[i]);
            }

            Console.WriteLine();

            // Многомерные массивы
            int[] nums1 = new int[]{0, 1, 2, 3, 4, 5};
            int[,] nums2 = {{0, 1, 2}, { 3, 4, 5}};

            int[][] numbers3 = new int[3][];
            numbers3[0] = new int[] { 1, 2 };
            numbers3[1] = new int[] { 1, 2, 3 };
            numbers3[2] = new int[] { 1, 2, 3, 4, 5 };
            foreach (int[] row in numbers3)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }

            // перебор с помощью цикла for
            for (int i = 0; i < numbers3.Length; i++)
            {
                for (int j = 0; j < numbers3[i].Length; j++)
                {
                    Console.Write($"{numbers3[i][j]} \t");
                }
                Console.WriteLine();
            }

            // Программа сортировки массива

            // ввод чисел
            int[] nums = new int[7];
            Console.WriteLine("Введите семь чисел");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            // сортировка
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

           
        }

        /// <summary>
        /// Передача параметров по ссылке и модификатор ref
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        internal static void Addition(ref int x, int y)
        {
            x += y;
        }

        /// <summary>
        /// /Возращает сумму
        /// </summary>
        /// <returns></returns>
        static int GetSum()
        {
            int x = 2;
            int y = 3;
            int z = x + y;
            return z;
        }


        // Не стал удалять внизу код, чтобы не переносить его в метод Greeting();

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

        internal static void DataTyoe()
        {
            // Тип bool хранит логические литералы true и false и занимает 1 байт
            bool alive = true;
            bool isDead = false;

            // Тип byte хранит целове число с 0 до 255 и занимает 1 байт
            byte bit1 = 1;
            byte bit2 = 106;

            // Тип sbyte хранит целое число от -128 до 127 и занимает 1 байт
            sbyte sbit1 = -111;
            sbyte sbit2 = 120;

            // Тип short хранит целое число от -32768 до 32767и занимает 2 байта
            short n1 = 1;
            short n2 = 666;

            // Тип ushort хранит целое число от 0 до 65535 и занимает 2 байта
            ushort un1 = 0;
            ushort un2 = 63636;

            // Тип int хранит целое число от -2147483648 до 2147483647 и занимает 4 байта
            int a = 10;
            int b = 0b101; // бинарная форма b = 5
            int c = 0xFF; // шестнадцатеричная форма с = 255

            // Тип uint хранит целое число от 0 до 4294967295 и занимает 4 байта
            uint ua = 10;
            uint ub = 0b111;
            uint uc = 0xFF;

            // Тип long хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            long la = -10;
            long lb = 0b101;
            long lc = 0xFF;

            // Тип ulong хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
            ulong ula = 10;
            ulong ulb = 0b101;
            ulong ulc = 0xFF;

            // Тип float: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта
            // Тип double: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта
            // Тип decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт

            // char: хранит одиночный символ в кодировке Unicode и занимает 2 байта
            char char_a = 'A';
            char char_b = '\x5A';
            char char_c = '\u0420';

            // Тип string: хранит набор символов Unicode
            string hello = "Hello";
            string word = "world";

            // object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.
            object obj_a = 22;
            object obj_b = 3.14;
            object obj_c = "hello code";
        }
    }
}
