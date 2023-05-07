using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBooksmvc.Data;
using BulkyBooksmvc.Models;
using BulkyBooksmvc.Models.Service;
using BulkyBooksmvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBooksmvc.Controllers
{
    public class BookController : Controller
    {
        private readonly IGenreService _genreService;
        private readonly IBookService _bookService;
        public BookController (IBookService bookService, IGenreService genreService)
        {
            _bookService = bookService;
            _genreService = genreService;
        }
        public IActionResult Index()
        {
           IEnumerable<Book> listOfBooks = _bookService.GetAllBooks();
           return View(listOfBooks);
        }
        public IActionResult Book(int id)
        {
           var book = _bookService.GetBook(id);
           return View(book);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(CreateBookViewModel book)
        {
            var bookReturned = _bookService.AddBook(book);
            var genre = _genreService.AddBookToGenre(bookReturned);
            if(bookReturned is not null)
            {
                TempData["successfull"] = "Book added successfully";
            }
            return RedirectToAction("Index");
            
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var book = _bookService.GetBook(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Update(Book book)
        {
                _bookService.Update(book);
            return RedirectToAction("Index");
        }

         public IActionResult Delete(int id)
        {
            var pie = _bookService.GetBook(id);
            return View(pie);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ActualDelete(int id)
        {
           _bookService.Delete(id);
            return RedirectToAction("Index");
        }
           
    }
}