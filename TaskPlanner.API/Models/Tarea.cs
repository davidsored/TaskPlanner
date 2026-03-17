using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TaskPlanner.API.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        public string Titulo { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFin { get; set; }

        [Required(ErrorMessage = "Debes elegir un color")]
        public string? ColorHex { get; set; }

        public int? CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }

        public bool EsRecurrente { get; set; } = false;

        public string? PatronDias { get; set; }

        public DateTime? FechaFinRecurrencia { get; set; }

        public string? FechasExcluidas { get; set; }
    }
}
