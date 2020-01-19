using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Marka")]
        public string Brand { get; set; }

        [Required]
        [Display(Name = "Model")]
        public string Model { get; set; }
        [Required]
        [Display(Name = "Segment")]
        public string Segment { get; set; }
        [Required]
        [Display(Name = "Rok produkcji")]
        public string ProductionYear { get; set; }
        [Required]
        [Display(Name = "Rodzaj paliwa")]
        public string FuelType { get; set; }
        [Required]
        [Display(Name = "Numer VIN")]
        public string VIN { get; set; }
        [Required]
        [Display(Name = "Stan licznika")]
        public int Odometer { get; set; }
        [Required]
        [Display(Name = "Czy wypożyczony")]
        public bool IsRent { get; set; }

        public Rent Rent { get; set; }
        public int? RentId { get; set; }
    }
}