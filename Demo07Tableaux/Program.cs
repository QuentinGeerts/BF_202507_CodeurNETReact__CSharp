// Démonstration 07 - Tableaux


// 1. Tableaux (à une dimension [vecteur])

// 1.1. Déclaration d'un tableau à une dimension
// Algo: Variable nomTableau : Tableau de Type[taille]
// C#: type[] nomTableau; => Déclaration une variable de type tableau

int[] entiers; // Créer un emplacement en mémoire où on stockera l'adresse mémoire du tableau d'entiers

// 1.2. Initialisation d'un tableau
entiers = new int[5]; // Instancier un tableau de 5 entiers qu'on stocke dans l'emplacement en mémoire déclaré précédemment


// 1.3. Déclaration et instanciation d'un tableau
string[] strings = new string[5];

// 1.4. Initialisation des emplacements en mémoire du tableau
entiers[0] = 10;
entiers[1] = 20;
entiers[2] = 30;
entiers[3] = 40;
entiers[4] = 50;

// 1.5. Déclaration, instancier et initialiser un tableau
double[] doubles = { 1.0, 2.0, 3.0, 4.0, 5.0 }; // Sucre syntaxique
bool[] bools = [true, false, true, false, true];
DateTime[] dateTimes = new DateTime[5]
{
    new DateTime(), 
    new DateTime(), 
    new DateTime(), 
    new DateTime(),
    new DateTime()
};

// 1.6. Récupération d'une valeur

Console.WriteLine(entiers[0]); // 10
Console.WriteLine(entiers[1]); // 20
Console.WriteLine(entiers[2]); // 30
Console.WriteLine(entiers[3]); // 40
Console.WriteLine(entiers[4]); // 50

// 1.7. Récupération de la taille d'un tableau
Console.WriteLine($"Taille du tableau: {entiers.Length}");
//entiers.Length = 5; // Pas possible car lecture seule (getter uniquement)

// 1.8. Itérer sur un tableau

for (int i = 0; i < entiers.Length; i++)
{
    Console.WriteLine($"{i}: {entiers[i]}");
}

foreach (double d in doubles)
{
    Console.WriteLine($"{d:F10}");
}

// 2. Tableaux multi-dimensionnels (orthogonaux / matrices)



// 3. Collections



// 4. Collections génériques


