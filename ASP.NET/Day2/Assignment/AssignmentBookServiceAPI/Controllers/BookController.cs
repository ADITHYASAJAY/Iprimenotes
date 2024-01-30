using AssignmentBookServiceAPI.Models;
using AssignmentBookServiceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentBookServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;
        public BookController()
        {
            bookRepository = new BookRespository();
        }
        [HttpPost, Route("AddBook")]
        public IActionResult Add(Book book)
        {
            try
            {
                bookRepository.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpPut, Route("UpdateBook")]
        public IActionResult Update(Book book)
        {
            try
            {
                bookRepository.EditBook(book);
                return StatusCode(200, book);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet, Route("AllBooks")]
        public IActionResult GetAllBooks()
        {
            try
            {
                List<Book> books = bookRepository.GetAllBooks();
                return StatusCode(200, books);
            }
            catch (Exception) { throw; }
        }
        [HttpGet, Route("GetBookByAuthor/{author}" )]
        public IActionResult GetBooksByAuthor(string author)
        {
            try
            {
                List<Book> books = bookRepository.GetBooksByAuthor(author);
                return StatusCode(200, books);
            }
            catch (Exception) { throw; }
        }

        [HttpGet, Route("GetBooksByLang/{lang}")]
        public IActionResult GetBooksByLang(string lang)
        {
            try
            {
                List<Book> books = bookRepository.GetBooksByLang(lang);
                return StatusCode(200, books);
            }
            catch (Exception) { throw; }
        }
        [HttpGet, Route("GetBooksByYear/{year}")]
        public IActionResult GetBooksByYear(int year)
        {
            try
            {
                List<Book> books = bookRepository.GetBooksByYear(year);
                return StatusCode(200, books);
            }
            catch (Exception) { throw; }
        }
        [HttpGet, Route("GetBookById/{id}")]
        public IActionResult GetBookById(int id)
        {
            try
            {
                Book book = bookRepository.GetBookById(id);
                return StatusCode(200, book);
            }
            catch (Exception) { throw; }
        }

        [HttpGet, Route("GetBookByName/{bookName}")]
        public IActionResult GetBookByName(string bookName)
        {
            try
            {
                Book book = bookRepository.GetBookByName(bookName);
                return StatusCode(200, book);
            }
            catch (Exception) { throw; }
        }


        [HttpDelete, Route("DeleteBook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                bookRepository.DeleteBook(id);
                return StatusCode(200, "deleted successfully");
            }
            catch (Exception) { throw; }
        }


    }
}
