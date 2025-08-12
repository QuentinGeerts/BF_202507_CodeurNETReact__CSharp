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
    public Personnage(string nom, int niveau, int force, int agilite, int intelligence)
    {
        this.nom = nom;
        this.niveau = niveau;
        this.force = force;
        this.agilite = agilite;
        this.intelligence = intelligence;
    }


    // Méthodes (methods)
    public string SePresenter()
    {
        return $"Bonjour, je m'appelle {nom} !";
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
}
