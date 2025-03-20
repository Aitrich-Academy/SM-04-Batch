using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoroverloading
{
    public abstract class Book
    {
        //----------------Create an abstract class Book................................
       public string title;
       public string author;
       public int year;
       
        public abstract void GetBookDetails();
    
    
        //-------------------constructor overloading..............................................
        //string title;
        //string author;
        //int year;
        //public Book(string t1, string a1, int y1)
        //{
        //    title = t1;
        //    author = a1;
        //    year = y1;

        //}
        //public Book(string t2, string a2)
        //{
        //    title = t2;
        //    author = a2;
        //    year = 2020;
        //}
        //public void Display()
        //{
        //    Console.WriteLine("Title: " + title);
        //    Console.WriteLine("Author: " + author);
        //    Console.WriteLine("Year: " + year);
        //}
    }
    }
