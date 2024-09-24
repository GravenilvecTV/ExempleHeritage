namespace TheMoutainProject {

    public class Everest: Montagne{

        public int NombreYeti { get; set; }

        public Everest(int nbYeti) : base("Everest", 8848, 86, 27, 10) {
            NombreYeti = nbYeti;
        }

        public void foo(){

        }

    }

    public class Montagne {

        // propriétés
        public string Nom { get; set; }
        public int Hauteur { get; set; }
        public int Longitude { get; set; }
        public int Latitude { get; set; }
        public int Difficulte { get; set; }

        // constructeurs
        public Montagne(string nom, int hauteur, int longitude, int latitude, int difficulte) {
            Nom = nom;
            Hauteur = hauteur;
            Longitude = longitude;
            Latitude = latitude;
            Difficulte = difficulte;
        }

        // méthodes

    }

}