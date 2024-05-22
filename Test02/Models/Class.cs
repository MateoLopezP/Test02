namespace Test02.Models
{
    public class Besitzer
    {
        public string Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Geburtsdatum { get; set; }
        public string Adresse { get; set; }
        public string Telefonnummer { get; set; }
        public string Email { get; set; }

        public List<Auto> Autos { get; set; }
    }
}
