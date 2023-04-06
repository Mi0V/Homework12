using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Homework12
{

    //Список книг / Добавлять книги / удалять книги / Проверка книги в списке ++ /
    class Library
    {
        public int Count;
        public const int size = 5;
        public Library() { _books = new string[size]; Count = 0; }

        private string[] _books;
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                {
                    return _books[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(index >= 0 && index < size)
                {
                    _books[index] = value;
                }
            }
        }
    }
    internal class zadanie3
    {
        static Library Add_book(Library lib)
        {
            Write("Enter book name to add new book: ");

            string name = ReadLine();
            for(int i = 0; i < Library.size; i++)
            {
                if(lib[i] ==null)
                {
                    lib[i] = name;
                    break;
                }
            }
            if (lib.Count + 1 < Library.size)
            {
                lib.Count++;
            }
            else
            {
                WriteLine(" ");
            }
            return lib;

        }

        static Library Minus_book(Library lib)
        {
            int numb = Int32.Parse(ReadLine());
            WriteLine("Enter book name to Delete old book: ");
            lib[numb - 1] = null;
            return lib;
        }

        static void All_Book(Library lib)
        {
            
            for (int i = 0; i < lib.Count; i++)
            {
                if (lib[i] != null)
                {
                    WriteLine($"Book number {i+1} - {lib[i]}");
                }
            }
            
        }

        static void Search(Library lib)
        {
            Write("Enter book name, that search his: ");
            string name = ReadLine();
            for(int i = 0; i < Library.size; i++)

            {
                if(lib[i] == name)
                {
                    WriteLine($"Thats book is in the Data base under number {i + 1}:  ");
                    break;
                }
                else
                {
                    WriteLine($"This is book name isn't in the data base( ");
                }
            }
            if (lib.Count + 1 < Library.size) lib.Count++;
            else WriteLine();
        }
        static void Main(string[] args)
        {
            Library lib = new Library();
            string Do;
            while(true)
            {
                WriteLine("Enter do which: 1- Enter the book, 2- Delete the book, 3- Check book in the data base, 4 - Withdraw book list");
                Do = ReadLine();
                switch(Do)
                {
                    case "1": Add_book(lib); break;
                    case "2": Minus_book(lib); break;
                    case "3": Search(lib); break;
                    case "4": All_Book(lib); break;
                    case "0": break;
                    default:
                        WriteLine("Maybe try again?: "); ReadKey();
                        break;
                }
                if (Do == "0") { WriteLine("Stop programm"); break; }
            }
            WriteLine();

        }
   
    }
}
