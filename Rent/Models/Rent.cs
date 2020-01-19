using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Rent.Models
{
    public class Rent
    {
        public int Id { get; set; }
        [Required]
        public DateTime RentStarTime { get; set; }

        [Required]
        public DateTime RentEndTime { get; set; }

    }
}