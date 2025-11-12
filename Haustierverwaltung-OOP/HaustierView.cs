using System;
using System.Collections.Generic;

namespace HaustierMVC
{
    public class HaustierView
    {
        public void ZeigeAlle(List<Haustier> tiere)
        {
            Console.WriteLine("\n🐾 Aktuelle Haustiere:");
            foreach (var t in tiere)
            {
                Console.WriteLine($"{t.Name} ({t.Tierart}) sagt: {t.MachGeräusch()}");
            }
        }

        public void ZeigeNachricht(string text)
        {
            Console.WriteLine(text);
        }

        public (string name, string tierart) FrageNachNeuemTier()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";
            Console.Write("Tierart: ");
            string tierart = Console.ReadLine() ?? "";
            return (name, tierart);
        }
    }
}
