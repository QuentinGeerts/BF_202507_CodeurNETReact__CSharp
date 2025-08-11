// Grâce à une boucle « for », calculez les x premiers nombre premier.

// Déclaration des variables
int choixUtilisateur = -1;

Console.WriteLine($"Entrez le nombre de nombres premiers:");
while (choixUtilisateur < 0)
{
    while(!int.TryParse(Console.ReadLine(), out choixUtilisateur))
    {
        Console.WriteLine($"Erreur, entrez un nombre:");
    }

    if (choixUtilisateur < 0) 
        Console.WriteLine($"Erreur, entrez un nombre strictement positif:");
}

for (int valeur = 2, nbPremiers = 0; nbPremiers < choixUtilisateur; valeur++)
{
    bool estPremier = true;
        
    for (int i = 2; i < valeur; i++)
    {
        if (valeur % i == 0)
        {
            estPremier = false;
            i = valeur;
        }
    }

    if (estPremier)
    {
        Console.WriteLine($"{++nbPremiers}: {valeur}");
    }
}

Console.WriteLine("Itérations terminées");