using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBooksmvc.Models;
using BulkyBooksmvc.Models.Service;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBooksmvc.Controllers
{
    public class GenreController : Controller
    {
        static List<Genre> listOfGenre = new List<Genre>();
        private readonly IGenreService _genreService;
        private readonly IBookService _bookService;
        public GenreController(IGenreService genreService, IBookService bookService)
        {
            _genreService = genreService;
            _bookService = bookService;
        }
        
        public IActionResult Genres()
        {
            var genreList = _genreService.GetGenres();
            return View(genreList);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Genre genre)
        {
            _genreService.AddGrenre(genre);
            return RedirectToAction("Add","Book");
        }
        public IActionResult Genre(int id)
        {
            var genre = _genreService.GetGenre(id);
            var books =_bookService.GetBooksByGenre(genre.Name);
            ViewBag.genreName = genre.Name;
            return View(books);
        }
    }
}