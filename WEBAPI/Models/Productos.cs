using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPI.Models
{
    public class Productos
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public string CodProducto { get; set; }
        public string NomProducto { get; set; }
        public decimal PreComProducto { get; set; }
        public decimal PreVenProducto { get; set; }
        public string ImgProducto { get; set; }
        public string DesProducto { get; set; }
        public int StkMaxProducto { get; set; }
        public int StkMinProducto { get; set; }

    }
}
