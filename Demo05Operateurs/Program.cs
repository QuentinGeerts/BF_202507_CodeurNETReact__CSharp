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

// 7. Pattern Matching: (type pattern)

object obj = (long)5;

// 7.1. Version avec if

if (obj is int)
{
    Console.WriteLine($"{obj} est un entier.");
}
else if (obj is long myLong)
{
    Console.WriteLine($"{obj} est un long.");
    Console.WriteLine($"Type de myLong: {myLong.GetType()}, valeur: {myLong}");
}
else if (obj is short)
{
    Console.WriteLine($"{obj} est un short.");
}
else if (obj is string)
{
    Console.WriteLine($"{obj} est une string.");
    ((string)obj).ToLower();
}
else
{
    Console.WriteLine($"Type non pris en charge");
}

// 7.2. Version avec switch

switch (obj)
{
    case int: Console.WriteLine("obj est un entier."); break;

    case long: Console.WriteLine("obj est un long"); break;

    case short: Console.WriteLine("obj est un short"); break;

    case string myString:
        Console.WriteLine($"{myString.ToLower()}");
        break;

    default: break;
}

// 8. Opérateur as
// Permet de convertir dans un type mais s'il n'y arrive pas retourne null

object obj2 = "Hello";

string str1 = obj2 as string;
str1 = o is string ? (string)o : null;

obj2 = 5;


// int monEntier = obj2 as int; // Ne fonctionne pas
int? monEntier = obj2 as int?;
int monEntier2 = obj2 as int? ?? 0;

// 9. Opérateur checked & unchecked
// Permet de vérifier les overflows (les dépassements de capacité)

int monEntier3 = int.MaxValue;

//int result = checked(monEntier3 + 1);
//checked
//{
//    int result1 = monEntier3 + 1;
//    int result2 = monEntier3 + 1;
//    int result3 = monEntier3 + 1;
//    int result4 = monEntier3 + 1;
//}

// Après configuration dans les propriétés du projet
// > Build > Advanced > Check for arithmetic overflows
//int result = monEntier3 + 1;

int result = unchecked(monEntier3 + 1);

unchecked
{
    // ...
}
