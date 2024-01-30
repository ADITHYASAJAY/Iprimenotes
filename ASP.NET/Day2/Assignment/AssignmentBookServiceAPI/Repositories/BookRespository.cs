using AssignmentBookServiceAPI.Models;
using System.Xml.Linq;

namespace AssignmentBookServiceAPI.Repositories
{
    public class BookRespository : IBookRepository
    {
        static List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            try 
            {
                books.Add(book);
            }
            catch(Exception) 
            {
                throw;
            }
        }

        public void EditBook(Book updateBook)
        {
            try 
            {
                
                foreach (Book book in books) 
                {
                    if(book.BookId == updateBook.BookId) 
                    {
                        book.BookName = updateBook.BookName;
                        book.Author = updateBook.Author;
                        book.Price = updateBook.Price;
                        book.ReleaseDate = updateBook.ReleaseDate;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Book> GetAllBooks()
        {
            try 
            {
                return books;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Book> GetBooksByAuthor(string Author)
        {
            try 
            {
                List<Book> booksByAuthor = new List<Book>();
                foreach(Book book in books)
                {
                    if (book.Author.Equals(Author)) 
                    {
                        booksByAuthor.Add(book);
                    }
                }
                return booksByAuthor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Book> GetBooksByLang(string lang)
        {
            try 
            {
                List<Book> booksByLang = new List<Book>();
                foreach (Book book in books)
                {
                    if (book.Lang.Equals(lang))
                    {
                        booksByLang.Add(book);
                    }
                }
                return booksByLang;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Book> GetBooksByYear(int year)
        {
            try {
                List<Book> booksByYear = new List<Book>();
                foreach (Book b in books)
                {
                    if (b.ReleaseDate==year)
                    {
                        booksByYear.Add(b);
                    }
                }
                return booksByYear;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteBook(int bookId) 
        {
            try 
            {
                foreach (Book book in books) 
                {
                    if (book.BookId == bookId)
                    {
                        books.Remove(book);
                        break;
                    }
                }
            }
            catch (Exception) 
            {
                throw;
            }
        }

        public Book GetBookByName(string name)
        {
            try 
            {
                foreach (Book book in books)
                {
                    if (book.BookName.Equals(name)) 
                    {
                        return book;
                    }
                }
                return null;
            }
            catch (Exception) 
            {
                throw;
            }
        }

        public Book GetBookById(int id)
        {
            try
            {
                foreach (Book book in books)
                {
                    if (book.BookId==id)
                    {
                        return book;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
