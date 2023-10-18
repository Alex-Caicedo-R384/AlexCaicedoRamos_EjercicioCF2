namespace AlexCaicedoRamos_EjercicioCF2.Models
{
    public class Promo
    {
        public int Promoid { get; set; }
        public string? PromoName { get; set; }
        public string? PromoDescription { get; set; }
        public int Id { get; set; }
        public Burger? Burger { get; set; }
    }
}
