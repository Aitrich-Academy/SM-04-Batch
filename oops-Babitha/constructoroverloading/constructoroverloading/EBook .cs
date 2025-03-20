using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructoroverloading
{
   public class EBook:Book
    {
        public string FileSize;
        public EBook(string tit, string au, int yea, string fileSize)
        {
            title = tit;
            author = au;
            year = yea;

            FileSize = fileSize;
        }

        public override void GetBookDetails()
        {
            Console.WriteLine("title:" + title);
            Console.WriteLine("author:" + author);
            Console.WriteLine("year:" + year);
            Console.WriteLine("filesize:" + FileSize);
        }

    }
}
