using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace Viandas.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }
        [Required]public string? Plato { get; set;}
        [Required]public int Cantidad { get; set; }
        [Required]public float? Precio { get; set;}
        public int? Descuento { get; set; }
    }
}
