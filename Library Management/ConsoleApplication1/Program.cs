using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    public class Program
    {
        public static string op;

        public static List<Books> createBooks()
        {
            List<Books> listBooks = new List<Books>();
            Books b1 = new Books();
            b1.author = "Dan Brown";
            b1.title = "Da Vinci Code";
            b1.issued = false;

            Books b2 = new Books();
            b2.author = "Dan Brown";
            b2.title = "Angels and Demons";
            b2.issued = false;


            Books b3 = new Books();
            b3.author = "Dan Brown";
            b3.title = "Digital Fortress";
            b3.issued = false;

            listBooks.Add(b1);
            listBooks.Add(b2);
            listBooks.Add(b3);

            return listBooks;
        }

        public static bool search(List<Books> bookList, string title)
        {
            foreach (Books book in bookList)
            {
                if (book.title.ToLower().Equals(title.ToLower()))
                {
                    return true;
                }

            }

            return false;
        }


        static void Main(string[] args)
        {
            
            
            List<Books> listOfBooks = createBooks();
            bool stop = false;
            string title = "";
            bool isAvail;

            Console.WriteLine("-----Wel come to The Dan Brown Library-----" + System.Environment.NewLine);// +"We own listed Books :"+System.Environment.NewLine+ "1. Da Vinci Code"+System.Environment.NewLine+ "2. Angels and Demons"+System.Environment.NewLine+"3. Digital Fortress"+System.Environment.NewLine );

            while (!stop)
            {
                Console.WriteLine(System.Environment.NewLine+".....MENU....." + System.Environment.NewLine + "1. Search" + System.Environment.NewLine + "2. Issue" + System.Environment.NewLine + "3. Return" + System.Environment.NewLine + "4. Exit" + System.Environment.NewLine + "Please enter your choice: ");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.WriteLine("Please enter the Book title:" + System.Environment.NewLine);
                        title = Console.ReadLine();
                        isAvail = search(listOfBooks, title);

                        if (isAvail)
                            Console.WriteLine("Book is Available in our Library");
                        else
                            Console.WriteLine("Book is not Available in our Library");
                        break;

                    case "2":
                        Console.WriteLine("Please enter the title of the book to be issued:");
                        title = Console.ReadLine();
                        isAvail = search(listOfBooks, title);

                        if (isAvail)
                            foreach (Books book in listOfBooks)
                            {
                                if (book.title.ToLower().Equals(title.ToLower()))
                                {
                                    listOfBooks.Remove(book);
                                    book.issueBook();
                                    listOfBooks.Add(book);
                                    break;
                                }
                            }
                        else
                            Console.WriteLine("This Book is not available in the Library.. There must be some mistake..");

                        break;

                    case "3":
                        Console.WriteLine("Please enter the title of the book to be returned:");
                        title = Console.ReadLine();
                        isAvail = search(listOfBooks, title);

                        if (isAvail)
                            foreach (Books book in listOfBooks)
                            {
                                if (book.title.ToLower().Equals(title.ToLower()))
                                {
                                    listOfBooks.Remove(book);
                                    listOfBooks.Add(book.returnBook(book));
                                    break;
                                }
                            }
                        else
                            Console.WriteLine("This Book doesn't belong to this Library.. There must be some mistake..");
                        break;

                    case "4":
                        Console.WriteLine("Exiting");
                        stop = true;
                        break;
                }

            }       
        }
    }
}
