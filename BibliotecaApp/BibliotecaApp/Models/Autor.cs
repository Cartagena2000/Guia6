using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.Models
{
    public class Autor
    {
        [Key]
        public int AutorID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Apellido { get; set; } = string.Empty;

        public ICollection<Libro> Libros { get; set; } 
    }
}
