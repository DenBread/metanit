using System;

namespace Third_Glava
{
    class Program
    {
        static void Main()
        {
            Person p = new Person("Bill", 18);
            p.Display();
            p.GetInfo();
            Employee emp = new Employee("Tom", "Microsoft");
            emp.Display();


            User den = new User("Den", 22);
            den.DisplayInfo();

            User bob = new User();
            bob.DisplayInfo();

            Calculate(5);

            State state1 = new State(); // State - структура, ее данные размещены в стеке
            _ = new County(); // Country - класс, в стек помещается ссылка на адрес в хипу
            // а в хипе располагаются все данные обьекта country1

            state1.county = new County();

            State state2 = new State
            {
                x = 1,
                y = 2
            };
            state1 = state2;
            state2.x = 5;
            Console.WriteLine(state1.x); // 1
            Console.WriteLine(state2.x); // 5

            County county2 = new County
            {
                x = 1,
                y = 4
            };
            County county1 = county2;
            county2.x = 7;

            Console.WriteLine(county1.x); // 7
            Console.WriteLine(county2.x); // 7

            state2.county = new County
            {
                x = 5
            };
            state1 = state2;
            state2.county.x = 8; // теперь и state1.country.x = 8, так как state1.country и state2.country
            // указывают на один объект в хипе

            Console.WriteLine(state1.county.x); // 8
            Console.WriteLine(state2.county.x); // 8

            Person per = new Person { name = "Tom", age = 23 };
            ChangePerson(per);

            Console.WriteLine(p.name); // Alice
            Console.WriteLine(p.age); // 23


            Console.ReadKey();
        }

        static void Calculate(int t)
        {
            object x = 6;
            int y = 7;
            _ = y + t + (int)x;
        }

        static void ChangePerson(Person person)
        {
            // сработает
            person.name = "Alice";
            // сработает только в рамках данного метода 
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }

    }

    struct State
    {
        public int x;
        public int y;
        public County county;
    }

    class County
    {
        public int x;
        public int y;
    }

    class Person
    {
        public string name;
        public int age;
    }
}
