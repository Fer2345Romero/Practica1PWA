using System.ComponentModel.DataAnnotations;

namespace Practica1PWA.Models
{
    public class Operaciones
    {
        [Required]
        [Display(Name = "Primer Dato")]
        public double PrimerDato { get; set; } = 0;

        [Required]
        [Display(Name = "Segundo Dato")]
        public double SegundoDato { get; set; } = 0;

        public double Resultado { get; set; } 

        public int TipoOperacionId { get; set; } =0;

        public List<TiposOperacion> ListaOperaciones { get; set; }
        public Operaciones()
        {
            ListaOperaciones = new List<TiposOperacion>
            {
                new TiposOperacion { Id = 1, Nombre = "Suma" },
                new TiposOperacion { Id = 2, Nombre = "Resta" },
                new TiposOperacion { Id = 3, Nombre = "Multiplicación" },
                new TiposOperacion { Id = 4, Nombre = "División" }
            };

        }
    }
}
