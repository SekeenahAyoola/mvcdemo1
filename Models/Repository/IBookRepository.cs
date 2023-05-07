using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBooksmvc.Models.Repository
{
    public interface IBookRepository
    {
        public Book AddBook(Book book);
        public Book GetBook(int id);
        public Book GetBook(string genre);
        public Book Update(Book book);
        public void Delete(Book book);
        public IEnumerable<Book> GetAllBooks();

    }
}