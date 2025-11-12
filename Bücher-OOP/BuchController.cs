using System.Collections.Generic;

namespace BuchController
{
    public class BuchController
    {

        private readonly List<Buch> _buecher = new(); // Liste aller Bücher
        private readonly BuchView _view = new();      // Zugriff auf die View

        public void Start()
        {
            Buch b1 = new Buch("Der Hobbit", "J.R.R. Tolkien", 320, 12.99);
            Buch b2 = new Buch("Clean Code", "Robert C. Martin", 464, 34.90);
            Buch b3 = new Buch("1984", "George Orwell", 328, 9.95);

            // Zur internen Liste hinzufügen
            _buecher.Add(buch1);
            _buecher.Add(buch2);
            _buecher.Add(buch3);

            // Ausgabe
            _view.ZeigeNachricht("=== Buchverwaltung ===");
            _view.ZeigeAlle(_buecher);
        }
    }
}