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

        [Required(ErrorMessage = "Please enter title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter author's first name")]
        public string AuthorFirstName { get; set; }

        public string AuthorMiddleName { get; set; }

        [Required(ErrorMessage = "Please enter author's last name")]
        public string AuthorLastName { get; set; }

        [Required(ErrorMessage = "Please enter publisher")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Please enter ISBN")]
        [RegularExpression(@"^(?=(?:\D*\d{10}(?:(?\D*\d){3})?$)[\d-]+$", ErrorMessage = "Not a valid ISBN")]
        public string ISBN { get; set; } 

        [Required(ErrorMessage = "Please enter classification")]
        public string Classification { get; set; }

        [Required(ErrorMessage = "Please enter category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        public double Price { get; set; }
    }
}
