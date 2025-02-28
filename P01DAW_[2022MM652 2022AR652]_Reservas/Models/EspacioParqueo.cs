using System.ComponentModel.DataAnnotations;

namespace P01DAW__2022MM652_2022AR652__Reservas.Models
{
    public class EspacioParqueo
    {
        [Key] // Define EspacioId como Primary Key
        public int EspacioId { get; set; }

        public int SucursalId { get; set; }

        [Required] // Evita valores nulos en Numero
        public string Numero { get; set; }

        public string Ubicacion { get; set; }
        public decimal CostoPorHora { get; set; }
        public bool Disponible { get; set; } // true = disponible, false = ocupado
    }
}
