using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBooksmvc.Models.Service
{
    public interface IGenreService
    {
        public Genre AddGrenre(Genre genre);
        public Genre AddBookToGenre(Book book);
        public Genre GetGenre(int id);
        public Genre GetGenre(string name);
        public Genre RemoveBookFromGenre(Book book);
        public IEnumerable<Genre> GetGenres();
    }
}