namespace RennwagenMVC
{
    public class Rennwagen
    {
        public string Name { get; set; }
        public string Farbe { get; set; }
        public int KW { get; set; }
        public int Hubraum { get; set; }

        public Rennwagen(string name, string farbe, int kw, int hubraum)
        {
            Name = name;
            Farbe = farbe;
            KW = kw;
            Hubraum = hubraum;
        }
        
    }
}