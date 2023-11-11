using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public interface IBookRepository
    {
        Book GetById(int id);
        void Add(Book book);
        Book GetByIsbn(string isbn);
    }
}
