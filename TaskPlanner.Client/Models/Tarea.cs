using System.ComponentModel.DataAnnotations;

namespace TaskPlanner.Client.Models
{
    public class Tarea
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public int CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }

    }
}
