using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreProject.Models.ViewModels
{
    public class BookListViewModel //gets books and paging info from HomeController.cs
    {
        public IEnumerable<Book> Books { get; set; } //set up as IEnumerable so that in index we can enumerate through each book
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; } //set in the controller
    }
}
