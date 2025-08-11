// 1. Calculer les 25 premiers nombres de la suite de Fibonacci.

// Déclaration des variables

int nb1, nb2, somme;

nb1 = 0;
nb2 = 1;

Console.WriteLine($"0. {nb1} ");

for (int i = 1; i < 25; i++)
{
    Console.WriteLine($"{i}. {nb2} ");

    somme = nb1 + nb2;
    nb1 = nb2;
    nb2 = somme;
}
