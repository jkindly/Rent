using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Rent.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        public string FullName { get; set; }

        [Required]
        [Display(Name = "Pesel")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Wprowadź poprawny PESEL.")]
        public string Pesel { get; set; }

        [Required]
        [Display(Name = "Numer dowodu")]
        public string IdNumber { get; set; }

        [Required]
        [Display(Name = "Numer prawa jazdy")]
        public string IdDriver { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+\s\d+[a-zA-Z]*$", ErrorMessage = "Wprowadź poprawną ulicę.")]
        [Display(Name = "Ulica z numerem domu")]
        public string Address { get; set; }

        [Display(Name = "Numer mieszkania")]
        public int? FlatNumber { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Wprowadź poprawny kod pocztowy.")]
        [Display(Name = "Kod pocztowy")]
        public string PostalCode { get; set; }

        [Required]
        [Display(Name = "Miasto")]
        public string City { get; set; }

    }
}