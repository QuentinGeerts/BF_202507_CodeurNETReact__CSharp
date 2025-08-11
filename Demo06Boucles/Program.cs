// Démonstration 06 - Boucles

// 1. for ...

int i;

//   init.  condi.   incré.
for (i = 0; i < 10; i++)
{
    Console.WriteLine($"i: {i}"); // 0 ... 9
}

Console.WriteLine($"i (en dehors): {i}"); // 10

for (int j = 0; j < 10; j++) // Variable locale
{
    Console.WriteLine($"j: {j}");
}

// Console.WriteLine($"j (en dehors): {j}"); // N'existe pas dans le context global

for (int j = 0; j < 10; j++)
{
    // ...
}

for (i = 0; i < 10; i++)
{
    // ...
}

// 2. while ...

i = 0;

while (i < 10)
{
    Console.WriteLine($"i: {i++}");
    // i++;
}


//Console.WriteLine("Entrez un nombre entre 1 et 10: ");
//int value = int.Parse(Console.ReadLine());

//while (value < 1 || value > 10)
//{
//    Console.WriteLine("Erreur, réessayez:");
//    value = int.Parse(Console.ReadLine());
//}

int value = 0;

Console.WriteLine("Entrez un nombre entre 1 et 10: ");

while (value < 1 || value > 10)
{
    while (!int.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("Format incorrect, réessayez:");
    }

    if (value < 1 || value > 10)
    {
        Console.WriteLine("Valeur incorrecte, réessayez:");
    }
}

Console.WriteLine($"Valeur récupérée: {value}");

// 3. do ... while

do
{
    // bloc d'instructions
} while (false);

// 4. foreach ...

string prenom = "Quentin";

foreach (char lettre in prenom)
{
    Console.WriteLine($"Lettre: {lettre}");
}

int[] entiers = [1, 2, 3, 4, 5];

foreach (var entier in entiers)
{
    Console.WriteLine($"Entier: {entier}");
}
