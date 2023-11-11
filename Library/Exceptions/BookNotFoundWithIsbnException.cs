using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Exceptions
{
    public class BookNotFoundWithIsbnException : Exception
    {
        public BookNotFoundWithIsbnException(string message) : base(message)
        {
        }
    }
}
