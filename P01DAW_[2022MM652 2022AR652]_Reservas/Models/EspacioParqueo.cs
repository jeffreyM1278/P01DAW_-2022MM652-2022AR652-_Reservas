namespace P01DAW__2022MM652_2022AR652__Reservas.Models
{
    public class EspacioParqueo
    {
        public int EspacioId { get; set; }
        public int SucursalId { get; set; }
        public string Numero { get; set; }
        public string Ubicacion { get; set; }
        public decimal CostoPorHora { get; set; }
        public bool Disponible { get; set; } // true = disponible, false = ocupado
    }
}
