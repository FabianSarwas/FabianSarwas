namespace HaustierMVC
{
    public class Haustier
    {

        public string Name { get; set; }
        public string Tierart { get; set; }

        public Haustier(string name, string tierart)
        {
            Name = name;
            Tierart = tierart;
        }
        public string MachGeräusch()
        {
            string tier = Tierart.ToLower();

            if (tier == "hund")
            {
                return ("Wuff!");
            }
            else if (tier == "katze")
            {
                return ("Miau!");
            }
            else if (tier == "schwein")
            {
                return ("Oink!");
            }
            else
            {
                return ("...?");
            }

        }

    }
}