namespace Demo08Structures.Models;

public struct Guilde
{
    // Attributs
    private string nom;
    private Personnage meneur;
    private int niveau;
    private List<Personnage> membres;


    // Constructeurs
    public Guilde(string nom, Personnage meneur)
    {
        this.nom = nom;
        this.meneur = meneur;
        membres = new List<Personnage>();
        AjouterMembre(meneur);
    }

    // Getters & Setters
    public string getNom()
    {
        return nom;
    }

    public void setNom(string nouveauNom)
    {
        this.nom = nouveauNom;
    }

    // Transformation des getters et setters en propriétés
    //public string Nom { get; set; } // Auto-property
    public string Nom // Propriété (property) = propfull
    {
        get
        {
            return nom;
        }
    }

    public int Niveau
    {
        get { return niveau; }
        set { niveau = value; }
    }

    public int Count
    {
        get { return membres.Count; }
    }

    // Méthodes

    public void AjouterMembre(Personnage p)
    {
        if (membres.Contains(p))
        {
            Console.WriteLine($"{p.nom} est déjà présent dans la guilde.");
            return; // A remplacer par une exception plus tard...
        }

        Console.WriteLine($"{p.nom} a intégré la guilde.");
        membres.Add(p);
    }

    // Surcharge (typage différent)
    public void AjouterMembre(params Personnage[] personnages)
    {
        foreach (Personnage p in personnages)
        {
            AjouterMembre(p);
        }
    }

    // Surchage (nombre de paramètres)
    // <!> uniquement sur la signature (si le type de retour change, fonctionne toujours)
    public bool AjouterMembre(Personnage p1, Personnage p2)
    {
        AjouterMembre(p1, p2);
        return true;
    }
}
