using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01DAW__2022MM652_2022AR652__Reservas.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; } // Cliente o Empleado
        public int? SucursalId { get; set; }
        [Column("Contraseña")]  // Mapea a la columna "Contraseña" en la base de datos
        public string Contrasenia { get; set; }
    }
}
