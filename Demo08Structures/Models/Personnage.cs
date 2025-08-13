namespace Demo08Structures.Models;

public struct Personnage
{
    // Attributs (fields)
    public string nom;
    public int niveau;
    public int force;
    public int agilite;
    public int intelligence;

    // Constructeurs
    // Paramètres par défaut
    public Personnage(string nom, int niveau = 1, int force = 10, int agilite = 10, int intelligence = 10)
    {
        this.nom = nom;
        this.niveau = niveau;
        this.force = force;
        this.agilite = agilite;
        this.intelligence = intelligence;
    }


    // Méthodes (methods)
    public string SePresenter() // Fonction qui retourne une chaîne de caractères
    {
        return $"Bonjour, je m'appelle {this.nom} !";
    }

    public void AfficherDetails() // Procédure qui ne retourne rien
    {
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        return $"Personnage: " +
                $"\nNom: {nom}" +
                $"\nNiveau: {niveau}" +
                $"\nForce: {force}" +
                $"\nAgilite: {agilite}" +
                $"\nIntelligence: {intelligence}";
    }

    public static bool TryParse (string nom, out Personnage? personnage)
    {
        personnage = null;

        if (nom != null)
        {
            personnage = new Personnage(nom);
            return true;
        }

        return false;
    }
}
