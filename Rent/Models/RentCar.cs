using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent.Models
{
    public class RentCar
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Początek najmu")]
        [DataType(DataType.DateTime)]
        public DateTime RentStarTime { get; set; }

        [Required]
        [Display(Name = "Koniec najmu")]
        [DataType(DataType.DateTime)]
        public DateTime RentEndTime { get; set; }

        public Customer Customer { get; set; }
        [Required]
        [Display(Name = "Klient")]
        public int CustomerId { get; set; }

        public Car Car { get; set; }
        [Required]
        [Display(Name = "Pojazd")]
        public int CarId { get; set; }

    }
}