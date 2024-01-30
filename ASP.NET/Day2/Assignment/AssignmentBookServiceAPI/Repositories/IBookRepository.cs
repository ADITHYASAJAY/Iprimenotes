using AssignmentBookServiceAPI.Models;

namespace AssignmentBookServiceAPI.Repositories
{
    public interface IBookRepository
    {
        public void AddBook(Book book);

        public List<Book> GetAllBooks();

        public Book GetBookByName(string name);
        public Book GetBookById(int id);

        public List<Book> GetBooksByAuthor(string Author);

        public List<Book> GetBooksByLang(string lang);

        public List<Book> GetBooksByYear(int year);

        public void EditBook(Book book);


        public void DeleteBook(int bookId);
    }
}
