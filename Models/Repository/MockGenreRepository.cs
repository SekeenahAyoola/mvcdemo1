using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBooksmvc.Models.Service;
using BulkyGenresmvc.Models.Repository;

namespace BulkyBooksmvc.Models.Repository
{
    public class MockGenreRepository : IGenreRepository
    {
         static List<Genre> listOfGenre = new List<Genre>{
            new Genre{Id = 1,Name = "Mystery",ListOfBooks = AddExistingBookToGenre("Mystery")},
            new Genre{Id = 2, Name = "Fiction", ListOfBooks = AddExistingBookToGenre("Fiction")},
            new Genre{Id = 3, Name = "Young Adult", ListOfBooks = AddExistingBookToGenre("Young Adult")},
            new Genre{Id = 4,Name = "Science Fiction",ListOfBooks = AddExistingBookToGenre("Science Fiction")}
        };
        private static List<Book> AddExistingBookToGenre(string genre)
        {
            List<Book> genreBooks = new List<Book>();
            foreach (var item in MockBookRepository.listOfBooks)
            {
                if (item.Genre == genre)
                {
                    genreBooks.Add(item);
                }
            }
            return genreBooks;
        }
        

        public Genre AddGenre(Genre genre)
        {
            listOfGenre.Add(genre);
            return genre;

        }

        public IEnumerable<Genre> GetAllGenres()
        {
            var genres = listOfGenre.ToList();
            return genres;
        }

        public Genre GetGenre(int id)
        {
            var genre = listOfGenre.Find(x =>  x.Id == id);
            return genre;
        }
        public Genre GetGenre(string name)
        {
            var genre = listOfGenre.Find(x =>  x.Name.ToLower() == name.ToLower());
            return genre;
        }

       
    }
}