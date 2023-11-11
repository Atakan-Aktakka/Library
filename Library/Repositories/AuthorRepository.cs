using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private List<Author> authors = new List<Author>();

        public Author GetById(int id)
        {
            return authors.FirstOrDefault(a => a.Id == id);
        }

        public void Add(Author author)
        {
            authors.Add(author);
        }
    }

}
