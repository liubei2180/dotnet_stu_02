using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class BookService: IBookService
    {
        public IEnumerable<string> GetAll()
        {
            return new[] { "books", "books1", "books2", "books3", "books4", "books5" };
        }

    }

      public class BookService2 : IBookService
    {
        public IEnumerable<string> GetAll()
        {
            return new [] { "2 Book 1", "2 Book 2" };
        }
    }
}