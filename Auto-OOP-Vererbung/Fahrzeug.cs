using System;

namespace FahrzeugMVC
{
    public class Fahrzeug
    {

        public string Marke { get; set; }
        public int Baujahr { get; set; }

        public Fahrzeug(string marke, int baujahr)
        {
            Marke = marke;
            Baujahr = baujahr;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Fahrzeug: {Marke}, Baujahr: {Baujahr}");
        }
    }

    public class Auto : Fahrzeug
    {
        public int AnzahlTueren { get; set; }

        public Auto(string marke, int baujahr, int tueren)
        : base(marke, baujahr)
        {
            AnzahlTueren = tueren;
        }
        public override void Info()
        {
            Console.WriteLine($"Auto: {Marke}, Baujahr: {Baujahr}, Türen: {AnzahlTueren}");
        }
    }
}