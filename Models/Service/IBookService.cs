using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBooksmvc.ViewModels;

namespace BulkyBooksmvc.Models.Service
{
    public interface IBookService
    {
        public Book AddBook(CreateBookViewModel book);
        public Book GetBook(int id);
        public Book GetBook(string id);
        public Book Update(Book book);
        public void Delete(int id);
        public IEnumerable<Book> GetBooksByGenre(string genre);
        public IEnumerable<Book> GetAllBooks();


    }
}