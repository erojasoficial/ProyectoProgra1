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

        public string Cuenta1 { get; set; }
        public string Monto1 { get; set; }
        public string Cuenta2 { get; set; }
        public string Monto2 { get; set; }
        public string Cuenta3 { get; set; }
        public string Monto3 { get; set; }
        public string Cuenta4 { get; set; }
        public string Monto4 { get; set; }
        public string Cuenta5 { get; set; }
        public string Monto5 { get; set; }
        public string Cuenta6 { get; set; }
        public string Monto6 { get; set; }

    }

}