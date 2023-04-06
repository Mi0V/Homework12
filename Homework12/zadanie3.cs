using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Homework12
{

    //Список книг / Добавлять книги / удалять книги / Проверка книги в списке ++ /
    class book
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} ";
        }
    }

    class library
    {
        book[] book_arr;

        public library(int size)
        {
            book_arr = new book[size];
        }

        public int Length
        {
            get { return book_arr.Length; }
        }
        public book this[int index]
        {
            get
            {
                if(index >= 0 && index < book_arr.Length)
                {
                    return book_arr[index];
                }
                throw new IndexOutOfRangeException();

            }
            set
            {
                book_arr[index] = value;
            }
        }

        public int findBook(string name)
        {
            for(int i = 0; i < book_arr.Length; i++)
            {   
                
                if(book_arr[i].Name == name)
                {
                    return i;
                }
            }   
            return -1;
        }


        

           
    }
    internal class zadanie3
    {
        static void Main(string[] args)
        {
            library books = new library(1);
            books = Convert.ReadLine();


           
        }
    }
}
