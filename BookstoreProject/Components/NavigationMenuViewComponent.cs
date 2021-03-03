using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreProject.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookstoreRepository repository;

        public NavigationMenuViewComponent (IBookstoreRepository r)
        {
            repository = r;
        }
        //drop partial view into the shared layout view
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
