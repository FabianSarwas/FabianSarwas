using System;
using System.Collections.Generic;

namespace BuchMVC
{
    public class BuchView
    {
        // Gibt eine Liste von Büchern aus
        public void ZeigeAlle(List<Buch> buecher)
        {
            Console.WriteLine("\n Buchliste:");
            foreach (var buch in buecher)
            {
                Console.WriteLine(buch.InfoText());
            }
        }

        // Gibt einfache Nachricht aus
        public void ZeigeNachricht(string text)
        {
            Console.WriteLine(text);
        }
    }
}
