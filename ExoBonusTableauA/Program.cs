/*
 * Écrire un programme qui permet de trier un tableau d'entier.
 * Le nombre d'éléments est entré par l'utilisateur au démarrage du programme.
 * Le tableau doit être initialiser avec des valeurs aléatoires.
 * 
 * Faire l'affichage avant le tri, faire le tri puis afficher le tableau après le tri.
 * 
 * Vous ne pouvez pas utiliser les collections pour cet exercice.
 */


// Déclaration des variables
int nbItems = 0, temp;

Console.WriteLine($"Entrez la taille du tableau:");
while (nbItems <= 0)
{
    while (!int.TryParse(Console.ReadLine(), out nbItems))
    {
        Console.WriteLine("Vous devez entrer une valeur numérique.");
    }

    if (nbItems <= 0)
    {
        Console.WriteLine("Vous devez entrer une valeur strictement positive.");
    }
}

// Création du tableau et initialisation
int[] ints = new int[nbItems];

for (int i = 0; i < ints.Length; i++)
{
    ints[i] = Random.Shared.Next(100) + 1;
}

// Affichage avant le tri
string format = "";

for (int i = 0;i < ints.Length; i++)
{
    format += ints[i];

    if (i < ints.Length - 1) format += ", ";
}

Console.WriteLine($"Avant: [ {format} ]");

// Tri
for (int i = 0; i < ints.Length - 1; i++)
{
    for (int j = i + 1; j < ints.Length; j++)
    {
        if (ints[i] > ints[j])
        {
            temp = ints[i];
            ints[i] = ints[j];
            ints[j] = temp;
        }
    }
}

// Affichage après le tri
format = "";

for (int i = 0; i < ints.Length; i++)
{
    format += ints[i];

    if (i < ints.Length - 1) format += ", ";
}

Console.WriteLine($"Après: [ {format} ]");