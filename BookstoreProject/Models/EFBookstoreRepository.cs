﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreProject.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreDbContext _context;

        //Constructor
        public EFBookstoreRepository (BookstoreDbContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
