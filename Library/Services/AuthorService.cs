using Library.Exceptions;
using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void AddAuthor(Author author)
        {
            if (author.Name.Length < 2)
            {
                throw new AuthorNameException("Yazar adı en az 2 karakter olmalıdır.");
            }

            _authorRepository.Add(author);
        }
    }
}
