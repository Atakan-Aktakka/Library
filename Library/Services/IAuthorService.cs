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
    public interface IAuthorService
    {
        void AddAuthor(Author author);
    }

   

}
