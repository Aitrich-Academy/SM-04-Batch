using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoroverloading
{
   public class PrintedBook:Book
    {
        public int Pages;
      public  PrintedBook(string tit,string au,int yea,int p)
        {
            title = tit;
            author = au;
            year = yea;
            Pages = p;
        }
        public override void GetBookDetails()
        {
            Console.WriteLine("title:"+title);
            Console.WriteLine("author:" + author);
            Console.WriteLine("year:+" + year);
            Console.WriteLine("No:of pages:"+Pages);
        }
    }
}
