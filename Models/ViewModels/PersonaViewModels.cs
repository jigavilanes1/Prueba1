using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Prueba2Parcial.Models.ViewModels
{
    public class PersonaViewModels
    {
        [Required]
        [Display(Name = "Ingrese el nombre del negocio: ")]
        [StringLength(100, MinimumLength = 3)]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Ingrese el nombre del contacto: ")]
        [StringLength(100, MinimumLength = 3)]
        public string ContactName { get; set; }

        [Required]
        [Display(Name = "Ingrese la direccion: ")]
        [StringLength(100, MinimumLength = 3)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Ingrese el pais: ")]
        [StringLength(100, MinimumLength = 3)]
        public string City { get; set; }

        [Required]
        [Display(Name = "Ingrese el codigo postal: ")]
        public int PostalCode { get; set; }

        [Required]
        [Display(Name = "Ingrese la ciudad: ")]
        public string Country { get; set; }
    }

    public class EditarPersonaViewModels
    {
        [Required]
        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "Ingrese el nombre del negocio: ")]
        [StringLength(100, MinimumLength = 3)]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Ingrese el nombre del contacto: ")]
        [StringLength(100, MinimumLength = 3)]
        public string ContactName { get; set; }

        [Required]
        [Display(Name = "Ingrese la direccion: ")]
        [StringLength(100, MinimumLength = 3)]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Ingrese la ciudad: ")]
        [StringLength(100, MinimumLength = 3)]
        public string City { get; set; }

        [Required]
        [Display(Name = "Ingrese el codigo postal: ")]
        public int PostalCode { get; set; }

        [Required]
        [Display(Name = "Ingrese la ciudad: ")]
        public string Country { get; set; }
    }
}