namespace CDA.Models
{
    public class Vol
    {
        public string VolId { get; set; }
        public string Reference { get; set; }
        public DateTime DateDepart { get; set; }
        public DateTime DateArrivee { get; set; }
        public Ville VilleDepart { get; set; }
        public Ville VilleArrivee { get; set; }
    }
}
