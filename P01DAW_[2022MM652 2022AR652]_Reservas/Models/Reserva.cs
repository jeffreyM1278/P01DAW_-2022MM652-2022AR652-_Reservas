using System.ComponentModel.DataAnnotations;

namespace P01DAW__2022MM652_2022AR652__Reservas.Models
{
    public class Reserva
    {
        public class Reserva
        {
            [Key] // Define ReservaId como Primary Key
            public int ReservaId { get; set; }

            public int UsuarioId { get; set; }
            public int EspacioId { get; set; }
            public DateTime Fecha { get; set; }
            public TimeSpan HoraInicio { get; set; }
            public int CantidadHoras { get; set; }
            public bool Activa { get; set; }
        }
    }
}
