namespace P01DAW__2022MM652_2022AR652__Reservas.Models
{
    public class Usuario
    {
            public int UsuarioId { get; set; }
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public string Telefono { get; set; }
            public string Contraseña { get; set; }
            public string Rol { get; set; } // Cliente o Empleado
            public int? SucursalId { get; set; }
    }
}
