using System.ComponentModel.DataAnnotations;

namespace TaskPlanner.Client.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        public string ColorHex { get; set; } = "#FFFFFF";
    }
}
