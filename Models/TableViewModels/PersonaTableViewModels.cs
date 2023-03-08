using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba2Parcial.Models.TableViewModels
{
    public class PersonaTableViewModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
    }
}