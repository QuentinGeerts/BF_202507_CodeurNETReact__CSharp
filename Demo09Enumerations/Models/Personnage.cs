using Demo09Enumerations.Enums;

namespace Demo09Structures.Models;

public struct Personnage
{
    // Attributs (fields)
    public string nom;
    public int niveau;
    public int force;
    public int agilite;
    public int intelligence;
    public Archetype archetype;

    // Constructeurs
    // Paramètres par défaut
    public Personnage(string nom, Archetype archetype, int niveau = 1, int force = 10, int agilite = 10, int intelligence = 10)
    {
        this.nom = nom;
        this.archetype = archetype;
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
                $"\nArchétype: {archetype}" +
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
            personnage = new Personnage(nom, Archetype.Guerrier);
            return true;
        }

        return false;
    }

    public static Personnage CreerPersonnage ()
    {
        Personnage p;

        Console.WriteLine($"Entrez le nombre de votre personnage");
        string nomUtilisateur = Console.ReadLine();

        Console.WriteLine($"Liste des archétypes:");
        //foreach (string archetype in Enum.GetNames(typeof(Archetype))) { }

        foreach (string a in Enum.GetNames<Archetype>())
        {
            Console.WriteLine($" - {a}");
        }
        Console.Write($"Choix: ");
        
        Archetype archetype;
        while (!Enum.TryParse<Archetype>(Console.ReadLine(), out archetype))
        {
            Console.WriteLine($"Erreur, réessayez: ");
        }

        //p = new Personnage(nomUtilisateur, (Archetype)Enum.Parse(typeof(Archetype), archetypeUtilisateur));

        p = new Personnage(nomUtilisateur, archetype);

        return p;
    }
}
