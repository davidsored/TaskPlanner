using System.ComponentModel.DataAnnotations;

namespace TaskPlanner.API.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la categoría es obligatorio")]
        public string Nombre { get; set; } = string.Empty;

    }
}
