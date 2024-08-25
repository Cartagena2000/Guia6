using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        public ICollection<Libro> Libros { get; set; } // Relación uno a muchos
    }
}
