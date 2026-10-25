using System.ComponentModel.DataAnnotations;

namespace GestionEscolar.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; } = string.Empty;

        [Required]
        public string Autor { get; set; } = string.Empty;

        public string Editorial { get; set; } = string.Empty;

        [Display(Name = "Año de publicación")]
        public int AnioPublicacion { get; set; }
    }
}