using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public interface IAuthorRepository
    {
        Author GetById(int id);
        void Add(Author author);
    }


}
