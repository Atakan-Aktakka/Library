using Library.Exceptions;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();

        public Book GetById(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        public void Add(Book book)
        {
            books.Add(book);
        }

        public Book GetByIsbn(string isbn)
        {
            var book = books.FirstOrDefault(b => b.Isbn == isbn);
            if (book == null)
            {
                throw new BookNotFoundWithIsbnException($"ISBN '{isbn}' ile ilgili kitap bulunamadı.");
            }

            return book;
        }
    }
}
