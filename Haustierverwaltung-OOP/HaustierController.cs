using System.Collections.Generic;

namespace HaustierMVC
{
    public class HaustierController
    {
        private readonly List<Haustier> _tiere = new();
        private readonly HaustierView _view = new();

        public void Start()
        {
            bool running = true;

            while (running)
            {
                _view.ZeigeNachricht("\n=== Haustier-Verwaltung ===");
                _view.ZeigeNachricht("1. Neues Haustier hinzufügen");
                _view.ZeigeNachricht("2. Alle Haustiere anzeigen");
                _view.ZeigeNachricht("3. Beenden");
                _view.ZeigeNachricht("> ");

                string eingabe = System.Console.ReadLine() ?? "";

                switch (eingabe)
                {
                    case "1":
                        var (name, tierart) = _view.FrageNachNeuemTier();
                        var tier = new Haustier(name, tierart);
                        _tiere.Add(tier);
                        _view.ZeigeNachricht("Haustier wurde hinzugefügt!");
                        break;

                    case "2":
                        _view.ZeigeAlle(_tiere);
                        break;

                    case "3":
                        running = false;
                        break;

                    default:
                        _view.ZeigeNachricht("Ungültige Eingabe!");
                        break;
                }
            }
        }
    }
}
