// 1. Écriture en console: Console.Write() ou Console.WriteLine()
Console.Write("Valeur sur une");
Console.Write(" seule ligne ");

Console.WriteLine("Coucou");

// 2. Déclaration d'une variable + affectation
string prenom = "Quentin";

// 3. Concaténation: +
Console.WriteLine("Bonjour " + prenom + " !");

// 4. Lecture en console: Console.ReadLine() <!> retourne une chaîne de caractères
Console.WriteLine("Comment tu t'appelles ?");
string nom = Console.ReadLine();

// 5. Nettoyer la console: Console.Clear()
Console.Clear();

// 6. Interpolation de chaînes
Console.WriteLine($"Bonjour {nom} !"); 