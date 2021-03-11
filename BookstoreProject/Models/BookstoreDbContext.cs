using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookstoreProject.Models
{
    public class BookstoreDbContext : DbContext     //inherits from DbContext file in system
    {
        public BookstoreDbContext (DbContextOptions<BookstoreDbContext> options) : base (options) //constructor //inherits the base options provided by the DbContext from system
        {

        }

        public DbSet<Book> Books { get; set; }      //returns a set of books //DbSet is built in //Project type //be able to access projects later on
    }
}
