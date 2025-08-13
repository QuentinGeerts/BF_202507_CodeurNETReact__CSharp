// Démonstration 08 - Structures

using Demo09Enumerations.Enums;
using Demo09Structures.Models;

Personnage p1 = new Personnage();

p1.nom = "Oyumiro";
p1.niveau = 1;
p1.force = 14;
p1.agilite = 13;
p1.intelligence = 9;

Console.WriteLine($"Personnage: " +
    $"\nNom: {p1.nom}" +
    $"\nNiveau: {p1.niveau}" +
    $"\nForce: {p1.force}" +
    $"\nAgilite: {p1.agilite}" +
    $"\nIntelligence: {p1.intelligence}"
);

Personnage p2 = new Personnage()
{
    nom = "Toto",
    niveau = 1,
    force = 14,
    agilite = 13,
    intelligence = 9,
};

Console.WriteLine($"P1 se présente: {p1.SePresenter()}");
Console.WriteLine($"P2 se présente: {p2.SePresenter()}");

Personnage p3 = new Personnage("Bill", Archetype.Mage, 1, 15, 12, 19);
Console.WriteLine($"P3 se présente: {p3.SePresenter()}");

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

Guilde guilde = new Guilde("Bruxelles Formation", p1);

//guilde.nom = "Prout";
//guilde.meneur = p2;

Console.WriteLine($"Nom de la guilde: {guilde.getNom()}");
Console.WriteLine($"Nom de la guilde: {guilde.Nom}");

Console.WriteLine($"Nombre de membres dans la guilde: {guilde.Count}");

Personnage p4 = new Personnage("Thorn", Archetype.Guerrier, force: 15,intelligence: 5, agilite: 12);
Console.WriteLine();
Console.WriteLine($"{p4}");

Personnage p5 = new Personnage("Thrall", Archetype.Pretre);
Console.WriteLine($"{p5}");

guilde.AjouterMembre(p1, p2, p3, p4, p5);


Personnage? p;

if (Personnage.TryParse(null, out p))
{
    Console.WriteLine($"Le personnage a été créé: {p}");
}
else
{
    Console.WriteLine($"Erreur lors de la création du personnage");
}

p?.AfficherDetails(); // Raccourci d'écriture

//if (p != null) p.AfficherDetails();

if (Personnage.TryParse("Arnold ", out p))
{
    Console.WriteLine($"Le personnage a été créé: {p}");
}
else
{
    Console.WriteLine($"Erreur lors de la création du personnage");
}

p?.AfficherDetails();

Console.WriteLine($"\nCréation d'un personnage: \n");

Personnage nouveauPersonnage = Personnage.CreerPersonnage();

Console.WriteLine($"Nouveau personnage: {nouveauPersonnage}");