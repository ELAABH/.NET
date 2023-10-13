namespace AM.Application.Domaine
{
    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }

        // Propri�t� pour repr�senter la relation avec l'avion
        public Plane Plane { get; set; }
        public List<passenger> passenger { get; set; } = new List<passenger>();
    }
}
