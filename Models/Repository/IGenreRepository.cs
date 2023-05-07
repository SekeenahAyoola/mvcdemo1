using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBooksmvc.Models;

namespace BulkyGenresmvc.Models.Repository
{
    public interface IGenreRepository
    {
        public Genre AddGenre(Genre Genre);
        public Genre GetGenre(int id);
        public Genre GetGenre(string  name);
        public IEnumerable<Genre> GetAllGenres();

    }
}