using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Rent.Models;

namespace Rent.ViewModels
{
    public class NewRentCarViewModel
    {
        [Required]
        public IEnumerable<Customer> Customers { get; set; }

        [Required]
        public IEnumerable<Car> Cars { get; set; }

        [Required]
        public RentCar RentCar { get; set; }
    }
}