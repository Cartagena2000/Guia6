using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotecaApp.Models
{
    public class Libro
    {
        [Key]
        public int LibroID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Titulo { get; set; }

        [Required]
        public DateTime FechaPublicacion { get; set; }

        [ForeignKey("Autor")]
        public int AutorID { get; set; }
        public Autor Autor { get; set; } // Relación muchos a uno

        [ForeignKey("Categoria")]
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; } // Relación muchos a uno
    }
}
