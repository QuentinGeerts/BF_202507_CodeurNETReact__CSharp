// 2. Calculer le factoriel d’un nombre entré au clavier.

// Déclaration des variables

int value = -1;
ulong resultat = 1;

Console.WriteLine($"Encoder un nombre positif:");

while (value < 0)
{
    while (!int.TryParse(Console.ReadLine(), out value)) {
        Console.WriteLine($"Vous devez entrer une valeur numérique:");
    }

    if (value <= 0)
    {
        Console.WriteLine($"La valeur doit être positive:");
    }
}


for (int i = value; i > 1; i--)
{
    resultat *= (ulong)i;
}

Console.WriteLine($"Factoriel de {value} vaut {resultat}");