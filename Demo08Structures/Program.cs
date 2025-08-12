// Démonstration 08 - Structures

using Demo08Structures.Models;

Personnage p1;

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

Personnage p3 = new Personnage("Bill", 1, 15, 12, 19);
Console.WriteLine($"P3 se présente: {p3.SePresenter()}");

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);