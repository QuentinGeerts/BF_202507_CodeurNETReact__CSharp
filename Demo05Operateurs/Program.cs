// Démonstration 05 - Opérateurs

// 1. Opérateurs d'affectation et raccourcis

// 1.1. Affectation: =

int i = 5;

i = i + 5; // i += 5
i = i - 2; // i -= 2

// 2. Pré/Post - incrémentation/décrémentation: ++ / --

// 2.1. Pré-incrémentation/décrémentation
// a. Incrémenter/décrémenter la valeur
// b. Récupérer la valeur

int nb1 = 5;

int resultat = ++nb1; // résultat: 6 | nb1: 6
resultat = --nb1; // nb1: 5 | resultat: 5

// 2.2. Post-incrémentation/décrémentation
// a. Récupérer la valeur
// b. Incrémenter/décrémenter la valeur

resultat = nb1++; // resultat: 5 | nb1: 6
resultat = nb1--; // resultat: 6 | nb1: 5

// 3. Opérateur ternaire
// Syntaxe: (condition ? valeursivrai : valeursifaux)

i = 5;

Console.WriteLine(i == 5 ? "OK" : "KO");

// 4. Opérateur coalesce: ??

string s = null;

string res = s ?? "Valeur par défaut";

res = res == null ? "Valeur par défaut" : res;

// 4.1. Raccourci ??=

res = res ?? "valeur par défaut";
res ??= "Valeur par défaut";

int? value = null;
value ??= 12;

// 5. Opérateur typeof: typeof(type)
// Permet de récupérer un type dans une variable

object o = 5L; // boxing
Type type = typeof(object);

if (o.GetType() == type)
{
    Console.WriteLine($"o est de type object");
}
else
{
    Console.WriteLine($"o n'est pas de type object");
}

// 6. Opérateur is
// Permet de récupérer un booléen qui indique si on est du type

if (o is object)
{
    Console.WriteLine($"o fait partie des objects");
}
else
{
    Console.WriteLine($"o ne fait pas des objects");
}
