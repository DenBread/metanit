using System;
using System.Collections.Generic;
using System.Text;

namespace Third_Glava
{
    /// <summary>
    /// Класс персонала
    /// </summary>
    class Person
    {
        public string Name { get; set; } // имя
        public int Age { get; set; } // возраст

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Person() : this("Unknown", 0)
        {
            //Name = "Unknown";
            //Age = 0;
            Console.WriteLine("Вызов конструктора без параметров");
        }

        /// <summary>
        /// Иницализации имени
        /// </summary>
        /// <param name="name">Имя</param>
        public Person(string name) : this(name , 18)
        {
            Name = name;
        }



        /// <summary>
        /// Конструктор иницализации Person
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /// <summary>
        /// Получаем инвормацию о персонале
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}, age: {Age}");
        }

        /// <summary>
        /// Получаем имя персонала
        /// </summary>
        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
}
