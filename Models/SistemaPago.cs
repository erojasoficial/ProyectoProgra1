using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class SistemaPago
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Apoderado { get; set; }
        public string Direccion { get; set; }
        public string Dni { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }

        public string Turno { get; set; }
        public string Aula { get; set; }
        public string Ciclo { get; set; }
        public string Modalidad { get; set; }
        public string Postula { get; set; }

    }
}