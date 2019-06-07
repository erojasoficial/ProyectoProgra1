using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Recibo
    {
        public int Id { get; set; }

        [Required]
        public int Id_Alumno { get; set; }
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