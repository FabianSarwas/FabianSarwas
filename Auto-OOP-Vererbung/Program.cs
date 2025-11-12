// See https://aka.ms/new-console-template for more information
using System;

namespace FahrzeugMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ein Fahrzeug erstellen
            Fahrzeug fahrzeug1 = new Fahrzeug("Yamaha", 2021);

            // Ein Auto erstellen
            Auto auto1 = new Auto("BMW", 2020, 4);

            // Methoden aufrufen
            fahrzeug1.Info();  // Gibt die Basisklassen-Info aus
            auto1.Info();      // Gibt die überschriebenen Infos aus


        }
    }
}

