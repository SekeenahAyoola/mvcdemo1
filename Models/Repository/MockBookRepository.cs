using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBooksmvc.Models.Repository
{
    public class MockBookRepository : IBookRepository
    {
         public static List<Book> listOfBooks = new List<Book>
        {
            new Book{Id = 1,Name ="Innocent InDeath",Genre ="Mystery",IsAvailable = true},
            new Book{Id = 2,Name ="Our Beloved Summer",Genre ="Young Adult",IsAvailable = true},
            new Book{Id = 3,Name ="Tiger Tiger",Genre ="Mystery",IsAvailable = true},
            new Book{Id = 4,Name ="Homeport",Genre ="Fiction",IsAvailable = true},
            new Book{Id = 5,Name ="Paris Option",Genre ="Science Fiction",IsAvailable = true},
            new Book{Id = 6,Name ="Blue Sea",Genre ="Fiction",IsAvailable = true},
            new Book{Id = 7,Name ="Convert One",Genre ="Science Fiction",IsAvailable = true},
            new Book{Id = 8,Name ="And Then There Were None",Genre ="Mystery",IsAvailable = true},
            new Book{Id = 9,Name ="Wild Life",Genre ="Young Adult",IsAvailable = true},
            new Book{Id = 10,Name ="Digital Fortress",Genre ="Science Fiction",IsAvailable = true},
        };
        public Book AddBook(Book book)
        {
            listOfBooks.Add(book);
            return book;
        }

        public void Delete(Book book)
        {
           listOfBooks.Remove(book);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return listOfBooks;
        }

        public Book GetBook(int id)
        {
            var book = listOfBooks.Find(x => x.Id == id);
            return book;
        }
        public Book GetBook(string genre)
        {
            var book = listOfBooks.Find(x => x.Genre.ToLower() == genre.ToLower());
            return book;
        }

        public Book Update(Book book)
        {
           var x = listOfBooks.Find(x => x.Id == book.Id);
            x.Name = book.Name;
            x.IsAvailable = book.IsAvailable;
            return x;
        }
    }

}