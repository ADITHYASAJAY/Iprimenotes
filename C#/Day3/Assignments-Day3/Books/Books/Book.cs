using System.Net;

namespace Books
{
    internal class Book
    {
        public int bookId;
        public string bookName;
        public string language;
        public int price;
        public string author;
        public string publisher;
    }
    class BookRepository
    {
        Book[] books = new Book[6];
        int index = 0;
        public void AddBook(Book book) 
        {
            if(index< books.Length) 
            {
                books[index] = book;
                index++;
            }
            else 
            {
                Console.WriteLine("Full, cannot add more books");
            }
        
        }
        public Book GetBookByName(string nameOfBook) 
        {
            Book book = new Book();
            foreach(var b in books) 
            { 
                if(string.Equals(b.bookName,nameOfBook))
                    return b;
            }
            return null;
        }
        public Book[] GetBooksByAuthor(string author) 
        {
            Book[] b = new Book[books.Length];
            int ptx = 0;
            foreach(Book byauthor in books)
            {
                if(byauthor!=null)
                {
                    if (string.Equals(byauthor.author, author))
                    {
                        b[ptx] = byauthor;
                        ptx++;
                    }
                }
                
            }
            return b;
        }
        public Book[] GetBooksByPublisher(string publisher) 
        {
            Book[] b = new Book[books.Length];
            int ptx = 0;
            foreach (Book bypublisher in books)
            {
                if (string.Equals(bypublisher.publisher ,publisher))                                                                                                                                                                                                                                                                                                                                                                                                           
                {
                    b[ptx] = bypublisher;
                    ptx++;
                }
            }
            return b;
        }
        public Book[] GetAllBooks() 
        {
            return books;
        
        }
        public static void Main()
        {
            BookRepository bookRepository = new BookRepository();
            do
            {
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Get Get Book By Name");
                Console.WriteLine("3.Get Books By Publisher ");
                Console.WriteLine("4.Get All Books");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter Your Choice");
                int ch = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case 1: //add new Book
                        {
                            Book book = new Book();
                            Console.WriteLine("Enter Book Name");
                            book.bookName = Console.ReadLine();
                            Console.WriteLine("Enter Author Name");
                            book.author = Console.ReadLine();
                            Console.WriteLine("Enter Price ");
                            book.price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Publisher");
                            book.publisher = Console.ReadLine();
                            Console.WriteLine("Enter the language");
                            book.language = Console.ReadLine();
                            book.bookId = new Random().Next();
                            bookRepository.AddBook(book);
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        {
                            Book book = new Book();
                            Console.WriteLine("Enter the book Name");
                            string name = Console.ReadLine();
                            book=bookRepository.GetBookByName(name);
                            Console.WriteLine();
                            if (book != null)
                                Console.WriteLine($"BookId:{book.bookId} BookName:{book.bookName} BookAuthour:{book.author} BookPublisher: {book.publisher}");
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter the Author Name");
                            string author = Console.ReadLine();
                            Console.WriteLine();
                            Book[] books = bookRepository.GetBooksByAuthor(author);
                            if(books!=null)
                            {
                                foreach (Book book in books) 
                                {
                                    if(book != null) 
                                    {
                                        Console.WriteLine($"BookId:{book.bookId} BookName:{book.bookName} BookAuthour:{book.author} BookPublisher: {book.publisher}");
                                    }
                                       
                                }
                               
                            }
                            else 
                            {
                                Console.WriteLine("No books found");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Books:");
                            Book[] books = bookRepository.GetAllBooks();
                            foreach (Book book in books)
                            {
                                if (book != null) 
                                {
                                    Console.WriteLine($"BookId:{book.bookId} BookName:{book.bookName} BookAuthour:{book.author} BookPublisher: {book.publisher}");
                                }  
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 5: 
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default: 
                        {
                            Console.WriteLine("Enter a valid choice");
                            Console.WriteLine();
                        }
                        break;
                }
            } while (true);
           }
    }
}
