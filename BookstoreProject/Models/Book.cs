using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreProject.Models
{
    public class Book
    {
        // All properties are required and ISBN has to match correct formatting

        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter the title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the author's first name")]
        public string AuthorFirstName { get; set; }

        public string AuthorMiddleName { get; set; }

        [Required(ErrorMessage = "Please enter the author's last name")]
        public string AuthorLastName { get; set; }

        [Required(ErrorMessage = "Please enter the publisher")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Please enter the ISBN")]
        [RegularExpression(@"^(?=(?:\D*\d{10}(?:(?\D*\d){3})?$)[\d-]+$", ErrorMessage = "Not a valid ISBN")]
        public string ISBN { get; set; } 

        [Required(ErrorMessage = "Please enter the classification")]
        public string Classification { get; set; }

        [Required(ErrorMessage = "Please enter the category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter the price")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please enter the number of pages")]
        public int NumPages { get; set; }
    }
}
