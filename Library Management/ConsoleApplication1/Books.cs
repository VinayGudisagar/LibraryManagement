using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Books
    {

        public string title;
        public string author;
        public bool issued;

        public void issueBook()
        {
            if (this.issued)
                Console.WriteLine("The book is already issued to someone else");
            else
            {
                Console.WriteLine("...Issued...");
                this.issued = true;
            }            
        }

        public Books returnBook(Books book)
        {

            if (book.issued)
            {
                Console.WriteLine("...Returned...");
                book.issued = false;
            }                
            else
            {
                Console.WriteLine("The book is not issued to anyone.. There must be some mistake");
            }
            return book;
        }
       
    }
}
