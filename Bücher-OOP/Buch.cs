namespace BuchMVC
{
    public class Buch
    {

        public string Titel { get; set; }
        public string Autor { get; set; }

        public int Seitenzahl { get; set; }
        public double Preis { get; set; }

        public Buch(string titel, string autor, int seitenzahl, double preis)
        {
            Titel = titel;
            Autor = autor;
            Seitenzahl = seitenzahl;
            Preis = preis;

        }
        public void InfoAnzeigen()

        {
            Console.WriteLine($"Titel: {titel}, Autor: {autor}, Seiten: {seitenzahl}");
        }
    }
}