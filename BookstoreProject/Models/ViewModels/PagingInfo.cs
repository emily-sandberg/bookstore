using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//creates class that allows us to do pagination and determine how many total pages we'll have
namespace BookstoreProject.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}
