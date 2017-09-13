using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentMV.Models;

namespace RentMV.Dtos
{
    public class NewRentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}