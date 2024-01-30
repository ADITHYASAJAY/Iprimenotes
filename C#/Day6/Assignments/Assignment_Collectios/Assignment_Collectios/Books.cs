using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Collectios
{
    class BookStore 
    {

          int bookId;
        string bookName;
        public int BookID { get { return bookId; } set { bookId = value; } }
        public string BookName { get { return bookName; } set { bookName = value; } }
    }
    internal class Books
    {
        public static void Main() 
        {
            Hashtable books = new Hashtable();
            BookStore bookStore1 = new BookStore() { BookID = 1222, BookName = "Harry Potter" };
            BookStore bookStore2 = new BookStore() { BookID = 1522, BookName = "The Great Gatsby" };
            BookStore bookStore3 = new BookStore() { BookID = 1252, BookName = "Jane Eyre" };
            BookStore bookStore4 = new BookStore() { BookID = 1262, BookName = "Lord of the Rings" };
            BookStore bookStore5 = new BookStore() { BookID = 1232, BookName = "To Kill a Mockingbird" };
            books.Add(bookStore1.BookID, bookStore1);
            books.Add(bookStore2.BookID, bookStore2);
            books.Add(bookStore3.BookID, bookStore3);
            books.Add(bookStore4.BookID, bookStore4);
            books.Add(bookStore5.BookID, bookStore5);

            foreach(object key in books.Keys) 
            {
                BookStore bookName = books[key] as BookStore;
                Console.WriteLine($"Id:{key}  BookName:{bookName.BookName}");
            }
            
        }
       
    }
}
