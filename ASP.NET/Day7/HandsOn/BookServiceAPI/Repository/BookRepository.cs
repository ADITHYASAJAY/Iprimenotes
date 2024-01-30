using BookServiceAPI.Entities;

namespace BookServiceAPI.Repository
{
    public class BookRepository : IRepository<Book>
    {
        private readonly MyContext _context;
        public BookRepository() 
        {
            _context = new MyContext();
        }
        public void Add(Book entity)
        {
            try 
            {
                _context.Books.Add(entity);
                _context.SaveChanges();
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }   
        }

        public void Delete(int id)
        {
            try 
            {
                var book = _context.Books.Find(id);
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Book Get(int id)
        {
            try 
            {
                return _context.Books.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Book> GetAll()
        {
            try 
            {
                return _context.Books.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Book> GetBooksByAuthor(string Author)
        {
            try 
            {
                var books = _context.Books.Where(x => x.Author == Author);
                return books.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Book> GetBooksByLang(string lang)
        {
            try {
                var books = _context.Books.Where(x => x.Lang == lang);
                return books.ToList();
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Book> GetBooksByYear(int year)
        {
            try 
            {
                var books = _context.Books.Where(x => x.ReleaseDate.Year== year);
                return books.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Book entity)
        {
            try 
            {
                _context.Books.Update(entity);
                _context.SaveChanges();

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
