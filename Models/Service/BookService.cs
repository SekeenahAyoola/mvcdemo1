using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBooksmvc.Models.Repository;
using BulkyBooksmvc.ViewModels;


namespace BulkyBooksmvc.Models.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        
        public BookService(IBookRepository bookRepository, IWebHostEnvironment webHostEnvironment)
        {
            _bookRepository = bookRepository;
            _webHostEnvironment = webHostEnvironment;
           
        }
        public Book AddBook(CreateBookViewModel createBook)
        {
            string filepath = "";
            if (createBook.coverImage is not null)
            {
                string photoPath = Path.Combine(_webHostEnvironment.WebRootPath,"BookCovers");
                filepath = Guid.NewGuid().ToString() + createBook.coverImage.FileName;
                string fullPath = Path.Combine(photoPath,filepath);
                createBook.coverImage.CopyTo(new FileStream(fullPath,FileMode.Create));
            }
            var book = new Book();
            book.Id = _bookRepository.GetAllBooks().Count()+ 1;
            book.Genre = createBook.Genre;
            book.Name = createBook.Name;
            book.coverImagePath = filepath;
            var newBook = _bookRepository.AddBook(book);
            return newBook;
        }

        public void Delete(int id)
        {
            var bookToDelete = _bookRepository.GetBook(id);
            _bookRepository.Delete(bookToDelete);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            var books = _bookRepository.GetAllBooks().ToList();
            return books;
        }

        public Book GetBook(int id)
        {
            return _bookRepository.GetBook(id);
        }
         public Book GetBook(string genre)
        {
            return _bookRepository.GetBook(genre);
        }

        public IEnumerable<Book> GetBooksByGenre(string genre)
        {
            var books = new List<Book>();
            foreach (var item in _bookRepository.GetAllBooks())
            {
                if (item.Genre == genre)
                {
                    books.Add(item);
                };
            }
            return books;
        }

        public Book Update(Book book)
        {
            return _bookRepository.Update(book);
        }
    }
}