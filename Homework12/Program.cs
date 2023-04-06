using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Homework12
{
    class Shop
    {
        public int X { get; set; } //Первое количество сотрудников
        public int Y { get; set; } // Второе количество сотрудников
        
    }

    class Person
    {
        public int X { get; set; }
        public int Y { get; set; }
        

        public Person() { }
        public Person(Shop begin, Shop end)
        {
            X = end.X - begin.X;
            Y = end.Y - begin.Y;
            
        }


        public static Person operator -(Person v1, int n)
        {
            v1.X -= n;
            return v1;
        }

        public static Person operator +(Person v1, int n)
        {
            v1.X += n;
            return v1;
        }
        public static bool operator !=(Person v1, Person v2)
        {        
            return v1.X != v2.X;
        }
        public static bool operator ==(Person v1, Person v2)
        {
            return v1.X == v2.X;
        }
        public static bool operator <(Person v1, Person v2)
        {
            return v1.X < v2.X;
        }
        public static bool operator >(Person v1, Person v2)
        {
            return v1.X > v2.X;
        }

        public override string ToString()
        {
            return $"{X}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Сколько сотрудников должно прибыть или убавится?");
            int n = Int32.Parse(ReadLine());

            Shop all = new Shop {X = 10};
            Person p1 = new Person {X = 10, Y = 10};
            Person p2 = new Person {X = 10, Y = 10};
 
            WriteLine($"Сотрудников сейчас {p1}, к ним добавилось {n}\n {p2 + n}"); // или увеличить или убавит
            WriteLine($"{p1}, от них ушло {n}\n {p2 - n}");
            WriteLine($"сотрудники (1){p1} = (2){p2}:    {p1==p2}");
            WriteLine($"сотрудники (1){p1} != (2){p2}:    {p1!=p2}");
            WriteLine($"сотрудники (1){p1} > (2){p2}:    {p1>p2}");
            WriteLine($"сотрудники (1){p1} < (2){p2}:    {p1<p2}");

        }
    }
}
