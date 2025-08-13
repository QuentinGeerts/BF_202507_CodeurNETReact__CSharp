// 2.Grâce à une boucle « for » et à l’aide d’une collection générique,
// calculez les x premiers nombres premiers (version optimisée).

int nbPrimes = 0;
bool isPrime;
List<int> primes = new(); // Inférence de type (depuis C# 9)

Console.WriteLine($"Combien de nombre premiers voulez-vous ?");

while (nbPrimes <= 0)
{
    while (!int.TryParse(Console.ReadLine(), out nbPrimes))
    {
        Console.WriteLine($"Erreur, réessayez:");
    }

    if (nbPrimes <= 0) Console.WriteLine($"La valeur doit être strictement positive.");
}

for (int value = 2; primes.Count < nbPrimes; value++)
{
    isPrime = true;

    for (int i = 2; i < value; i++)
    {
        if (value % i == 0)
        {
            isPrime = false;
            i = value;
        }
    }

    if (isPrime) primes.Add(value);
}

Console.WriteLine($"Nombres premiers: {string.Join(", ", primes)}");