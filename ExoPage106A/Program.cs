/*
 * En utilisant la méthode « Console.ReadLine() »
 * • Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, 
 *   la conversion devra utiliser la méthode « int.Parse() »
 * • Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, 
 *   la conversion devra utiliser la méthode « int.TryParse() »
 */

// Déclaration des variables
int nb1, nb2, resultat;

// a. int.Parse()
Console.WriteLine($"Entrez un premier nombre:");
nb1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Entrez un deuxième nombre:");
nb2 = int.Parse(Console.ReadLine());

// b. int.TryParse()

Console.WriteLine($"Entrez un premier nombre:");
bool convertNb1 = int.TryParse(Console.ReadLine(), out nb1);

Console.WriteLine($"Entrez un deuxième nombre:");
bool convertNb2 = int.TryParse(Console.ReadLine(), out nb2);


resultat = nb1 + nb2;

Console.WriteLine($"{nb1} + {nb2} = {resultat}");