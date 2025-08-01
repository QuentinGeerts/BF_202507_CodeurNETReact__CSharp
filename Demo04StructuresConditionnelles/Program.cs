// Structures conditionnelles

// 1. if ... else if ... else ...

// 1.1. if ...

if (true)
{
    Console.WriteLine("Exécution du bloc d'instructions");
}

if (false)
{
    Console.WriteLine("Non exécution du bloc d'instructions");
}

// 1.2. if ... else ...

if (true)
{
    Console.WriteLine("Exécution du bloc");
}
else
{
    Console.WriteLine("Non exécution du bloc");
}

if (false)
{
    Console.WriteLine("Non exécution du bloc");
}
else
{
    Console.WriteLine("Exécution du bloc");
}

// Petite astuce
if (true) Console.WriteLine("Exécution du bloc");

if (true)
    Console.WriteLine("Exécution du bloc");

// 1.3. if ... else if ... else ...

if (false)
{
    Console.WriteLine("Non exécution du bloc");
}
else if (true)
{
    Console.WriteLine("Exécution du bloc");
}
else
{
    Console.WriteLine("Non exécution");
}

// Exemple:

Console.WriteLine("Entrez votre âge:");
int age = int.Parse(Console.ReadLine());

if (age < 0) Console.WriteLine("Vous ne pouvez pas avoir un âge négatif!");
else if (age < 12) Console.WriteLine("Vous êtes un enfant.");
else if (age < 18) Console.WriteLine("Vous êtes un adolescent.");
else if (age < 65) Console.WriteLine("Vous êtes un adulte.");
else Console.WriteLine("Vous êtes un senior.");


// 2. switch ...

Console.WriteLine("Entrez un jour de la semaine (lundi, mardi): ");
string jour = Console.ReadLine().ToLower();

switch (jour)
{
    case "lundi":
        Console.WriteLine("lundi");
        break;
    case "mardi":
    case "mercredi":
        Console.WriteLine("mardi et mercredi");
        break;
    case "jeudi":
        Console.WriteLine("jeudi");
        break;
    case "vendredi":
        Console.WriteLine("vendredi");
        break;
    case "samedi":
        Console.WriteLine("samedi");
        break;
    case "dimanche":
        Console.WriteLine("dimanche");
        break;
    default:
        Console.WriteLine("Jour non reconnu");
        break;
}


// 3. Opérateur ternaire
// Syntaxe: (condition) ? valeur_si_vrai : valeur_si_faux

Console.WriteLine("Entrez votre sexe (H / F): ");
char sexe = char.Parse(Console.ReadLine());

Console.WriteLine($"Bonjour {(sexe == 'F' ? "Madame" : "Monsieur")}");


string civilite = sexe == 'F' ? "Madame" : (sexe == 'H') ? "Monsieur" : "Autre";
Console.WriteLine($"Bonjour {civilite}");


// 4. Opérateurs de comparaison

Console.WriteLine($"Égalité (==): {5 == 5}");
Console.WriteLine($"Différence (!=): {5 != 5}");
Console.WriteLine($"Strictement supérieur (>): {5 > 5}");
Console.WriteLine($"Supérieur ou égal (>=): {5 >= 5}");
Console.WriteLine($"Strictement inférieur (<): {5 < 5}");
Console.WriteLine($"Inférieur ou égal (<=): {5 <= 5}");


// 5. Opérateurs de logique

Console.WriteLine($"ET: &&");
Console.WriteLine($"true && true: {true && true}"); // true
Console.WriteLine($"false && true: {false && true}"); // false
Console.WriteLine($"true && false: {true && false}"); // false
Console.WriteLine($"false && false: {false && false}"); // false

Console.WriteLine($"OU: ||");
Console.WriteLine($"true || true: {true || true}"); // true
Console.WriteLine($"false || true: {false || true}"); // true
Console.WriteLine($"true || false: {true || false}"); // true
Console.WriteLine($"false || false: {false || false}"); // false

Console.WriteLine($"Négation: !");
Console.WriteLine($"!true: {!true}"); // false
Console.WriteLine($"!false: {!false}"); // true