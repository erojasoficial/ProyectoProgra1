using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Foto { get; set; }

        [Required]
        public decimal Precio { get; set; }
    }
}