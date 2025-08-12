using System.Collections;


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

// 2.1. Tableaux orthogonaux

// 2.1.1. Déclaration, instanciation et initialisation

int[][] tabOrth = new int[5][];

tabOrth[0] = new int[6];
tabOrth[1] = new int[2];
tabOrth[2] = new int[1];
tabOrth[3] = new int[8];
tabOrth[4] = new int[3];

// [
//  [0, 0, 0, 0, 0],
//  [0, 0],
//  [0],
//  [0, 0, 0, 0, 0, 0, 0, 0],
//  [0, 0, 0]
// ] 

int[][] tabOrth2 = new int[5][]
{
    new int[5],
    new int[2],
    new int[1],
    new int[8],
    new int[3],
};

int[][] tabOrth3 = {
    new int[5],
    new int[2],
    new int[1],
    new int[8],
    new int[3],
};

int[][] tabOrth4 = [
    [0, 0, 0, 0, 0],
    [0, 0],
    [0],
    [0, 0, 0, 0, 0, 0, 0, 0],
    [0, 0, 0],
];

// 2.1.2. Récupération de la taille des tableaux
Console.WriteLine($"Taille du tableau: {tabOrth.Length}");
Console.WriteLine($"Taille du tableau: {tabOrth.Rank}");

Console.WriteLine($"Taille du tableau: {tabOrth[0].Length}");
Console.WriteLine($"Taille du tableau: {tabOrth[0].Rank}");

// 2.1.3. Itérer sur un tableau orthogonal

for (int i = 0; i < tabOrth.Length; i++)
{
    for (int j = 0; j < tabOrth[i].Length; j++)
    {
        Console.Write($"[{tabOrth[i][j]}] ");
    }
    Console.WriteLine();
}

int[][][] tabOrth5 =
{
    [new int[3], new int[3], new int[6]],
    [new int[2], new int[5], new int[3]],
    [new int[7], new int[3], new int[1]],
};

Console.WriteLine("--------------------------------------------");

for (int i = 0; i < tabOrth5.Length; i++)
{
    for (int j = 0; j < tabOrth5[i].Length; j++)
    {
        for (int k = 0; k < tabOrth5[i][j].Length; k++)
        {
            Console.Write($"[{tabOrth5[i][j][k]}] ");
        }
        Console.Write("\t");
    }
    Console.WriteLine();
}


// 2.2. Tableaux matriciels


// 5: Nombre de tableaux
// 4: Taille pour tous les sous-tableaux
int[,] tabMatriciel = new int[5, 4];
int[,] tabMatriciel2 = new int[5, 4]
{
    { 0, 1, 2, 3 },
    { 0, 1, 2, 3 },
    { 0, 1, 2, 3 },
    { 0, 1, 2, 3 },
    { 0, 1, 2, 3 },
};

// 2.2.2. Récupération de la taille de la matrice

Console.WriteLine($"Taille de la matrice: {tabMatriciel.Length}");
Console.WriteLine($"Nombre de dimension de la matrice: {tabMatriciel.Rank}");
Console.WriteLine($"Nombre d'éléments de la dimension 0: {tabMatriciel.GetLength(0)}");
Console.WriteLine($"Nombre d'éléments de la dimension 1: {tabMatriciel.GetLength(1)}");


// 2.2.3. Itération sur une matrice

for (int i = 0; i < tabMatriciel.GetLength(0); i++)
{
    for (int j = 0; j < tabMatriciel.GetLength(1); j++)
    {
        Console.Write($"[{tabMatriciel[i, j]}]");
    }
    Console.WriteLine();
}

Console.Clear();

// 3. Collections

// > Tableau dynamique (nombre d'éléments + typage)

// a. ArrayList (collection classique)
// b. HashTable (Clef / valeur)
// c. Queue (FIFO : First In First Out)
// d. Stack (LIFO : Last In First Out)

// a. ArrayList
// Collection classique d'éléments de tous types

ArrayList arrayList = new ArrayList();

// 3.a.1. Récupération de la taille d'une ArrayList
Console.WriteLine($"Taille de l'arraylist: {arrayList.Count}"); // 0

// 3.a.2. Ajouter un élément dans le tableau
arrayList.Add(42);
arrayList.Add("a");
arrayList.Add(true);
arrayList.Add(new DateTime());
arrayList.Add(new int[5]);
arrayList.Add(new ArrayList());

ArrayList col2 = new ArrayList()
{
    5, "a"
};

arrayList.AddRange(col2);
arrayList.AddRange(new ArrayList() { "Bonjour", "Au revoir", "Merci" });

Console.WriteLine(arrayList);

foreach (object item in arrayList)
{
    Console.WriteLine($"{item} ");

    if (item is string myString)
    {
        Console.WriteLine($"{((string)item).ToUpper()}");
        Console.WriteLine($"{myString.ToUpper()}");
    }
}

// Indexeur
arrayList[0] = 42;
Console.WriteLine(arrayList[0]); // 42

// 3.b. HashTable

Hashtable hashtable = new Hashtable();

hashtable.Add("00001", "Quentin");
hashtable.Add("00002", true);
hashtable.Add(42, new DateTime());
//hashtable.Add(42, new DateTime()); // Ne fonctionne pas car déjà présent

//hashtable.Remove(42);

// 3.b.2. Itérations sur une hashtable

foreach (object key in hashtable.Keys)
{
    Console.WriteLine($"{key}: {hashtable[key]}");
}

foreach (object? value in hashtable.Values)
{
    Console.WriteLine($"{value}");
}

foreach (DictionaryEntry clefvaleur in hashtable)
{
    Console.WriteLine($"{clefvaleur.Key}: {clefvaleur.Value}");
}

Console.Clear();

// c. Queue (FIFO = First In First Out)

Queue fileAttente = new Queue();

fileAttente.Enqueue("Martin");
fileAttente.Enqueue("Slimane");
fileAttente.Enqueue("Ousmane");
fileAttente.Enqueue("Raphael");

foreach (object? personne in fileAttente)
{
    Console.WriteLine($"Personne: {personne}");
}

Console.WriteLine("---");

int countFileAttente = fileAttente.Count;

for (int i = 0; i < countFileAttente; i++)
{
    object? p = fileAttente.Dequeue();
    object? nextP = fileAttente.Count > 0 ? fileAttente.Peek() : null;

    Console.WriteLine($"Personne actuelle: {p}, prochaine: {nextP}");
}

// d. Stack (LIFO = Last In First Out)

Stack pileAssiettes = new Stack();

pileAssiettes.Push("Assiette 1");
pileAssiettes.Push("Assiette 2");
pileAssiettes.Push("Assiette 3");
pileAssiettes.Push("Assiette 4");
pileAssiettes.Push("Assiette 5");

foreach (object? assiette in pileAssiettes)
{
    Console.WriteLine($"{assiette}");
}

Console.WriteLine("---");
int countAssiettes = pileAssiettes.Count;

for (int i = 0; i < countAssiettes; i++)
{
    object? assiette = pileAssiettes.Pop();
    object? nextAssiette = pileAssiettes.Count > 0 ? pileAssiettes.Peek() : null;

    Console.WriteLine($"Nettoyage de l'assiette: {assiette}");
    if (nextAssiette != null)
        Console.WriteLine($"Prochaine assiette à nettoyer: {nextAssiette}");
    else
        Console.WriteLine("Plus d'assiette à nettoyer");
}


// 4. Collections génériques

// a. ArrayList → List<T>

List<string> prenoms = new List<string>();
var prenoms2 = new List<string>();
List<string> prenoms3 = new(); // Inférence de type (à partir de C# 9)

prenoms.Add("Quentin");
//prenoms.Add(12);

// b. Hashtable → Dictionary<T, U>

Dictionary<string, string> contacts = new Dictionary<string, string>();

contacts.Add("quentin.geerts@bstorm.be", "Geerts Quentin");
//contacts.Add(12, 12);

foreach (KeyValuePair<string, string> contact in contacts)
{
    Console.WriteLine($"{contact.Key}: {contact.Value}");
}

// c. Queue → Queue<T>

Queue<string> fileAttenteString = new Queue<string>();

//fileAttenteString.Enqueue(12);
fileAttenteString.Enqueue("Quentin");

// d. Stack → Stack<T>

Stack<string> files = new Stack<string>();
files.Push("./files/montexte.txt");
//files.Push(12);
