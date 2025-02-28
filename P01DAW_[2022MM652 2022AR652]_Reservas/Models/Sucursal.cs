using System.ComponentModel.DataAnnotations;

namespace P01DAW__2022MM652_2022AR652__Reservas.Models
{
    public class Sucursal
    {
        [Key] // Define que SucursalId es la Primary Key
        public int SucursalId { get; set; }

        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public int AdministradorId { get; set; }
        public int EspaciosDisponibles { get; set; }
    }
}
