using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBooksmvc.Models.Repository;
using BulkyGenresmvc.Models.Repository;

namespace BulkyBooksmvc.Models.Service
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
   
        public GenreService (IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

       
        public Genre AddBookToGenre(Book book)
        {
            var genre = _genreRepository.GetGenre(book.Genre);
            if (genre != null)
            {
                genre.ListOfBooks.Add(book);
                return genre;
            }
           return genre;
        }

        public Genre AddGrenre(Genre genre)
        {
          var thisGenre =  _genreRepository.AddGenre(genre);
            return thisGenre;
        }

        public Genre GetGenre(int id)
        {
            return _genreRepository.GetGenre(id);
        }

        public Genre GetGenre(string name)
        {
            return _genreRepository.GetGenre(name);
        }

       

        public IEnumerable<Genre> GetGenres()
        {
            return _genreRepository.GetAllGenres();
        }

        public Genre RemoveBookFromGenre(Book book)
        {
            var genre = _genreRepository.GetGenre(book.Genre);
            foreach (var item in genre.ListOfBooks)
            {
                if (item == book)
                {
                    genre.ListOfBooks.Remove(book);
                }
            }
            return genre;
        }

       
    }
}