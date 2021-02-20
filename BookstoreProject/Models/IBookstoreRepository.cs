using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreProject.Models
{
    public interface IBookstoreRepository //interface is a template that is meant to be inherited
    {
        IQueryable<Book> Books { get; }
    }
}
