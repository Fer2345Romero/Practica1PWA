using System.ComponentModel.DataAnnotations;

namespace Practica1PWA.Models
{
    public class Conversiones
    {
        [Required]
        [Display(Name = "Valor a Convertir")]
        public double ValorConversion { get; set; } = 0;

        public int TipoConversionId { get; set; } = 0;
        public double ResultadoConversion { get; set; } = 0;

        public List<TiposConversion> ListaConversiones { get; set; }

        public Conversiones()
        {
            ListaConversiones = new List<TiposConversion>
            {
                new TiposConversion { Id = 1, Nombre = "Celsius a Fahrenheit" },
                new TiposConversion { Id = 2, Nombre = "Metros a Pies" },
                new TiposConversion { Id = 3, Nombre = "Kilogramos a Libras" }
            };
        }
    }
}