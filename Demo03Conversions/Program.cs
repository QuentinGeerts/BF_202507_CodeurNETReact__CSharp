// Démonstration 03 - Conversions

// 1. Conversion type vers string: .ToString()
int i = 5;
double j = 5.2;
bool k = false;

string stringDeI = i.ToString();
string stringDeJ = j.ToString();
string stringDeK = k.ToString();

Console.WriteLine($"Valeur de stringDeI: {stringDeI}, type: {stringDeI.GetType()}");
Console.WriteLine($"Valeur de stringDeJ: {stringDeJ}, type: {stringDeJ.GetType()}");
Console.WriteLine($"Valeur de stringDeK: {stringDeK}, type: {stringDeK.GetType()}");

string a = "5", b = "7";

Console.WriteLine(a + b); // 57

Console.WriteLine("Entrez la valeur de a: ");
a = Console.ReadLine();

Console.WriteLine("Entrez la valeur de b: ");
b = Console.ReadLine();

Console.WriteLine(a + b); // Concaténation des deux valeurs

// 2. Conversion de string vers type

// a. Classe "Convert": Convertir n'importe quoi en n'importe quoi (CTS)

//int aConverti = Convert.ToInt32(a); // Conversion d'une string en Int32 (int)
//int bConverti = Convert.ToInt32(12.5); // Conversion d'un double en Int32 (int)

//Console.WriteLine($"a: {aConverti}");
//Console.WriteLine($"b: {bConverti}");

// b. Méthode "Parse": Convertir une chaine en type

//int aParsed = int.Parse(a);
//int bParsed = int.Parse(b);


// c. Méthode "TryParse": Convertir une chaine en type

// Avant
int resultatA;
bool conversionReussieA = int.TryParse(a, out resultatA);

// Maintenant
bool conversionReussieB = int.TryParse(b, out int resultatB);

Console.WriteLine($"ConversionA: {conversionReussieA} => {resultatA}");
Console.WriteLine($"ConversionB: {conversionReussieB} => {resultatB}");

int resultat;
Console.WriteLine("Entrez un nombre: ");
while (!int.TryParse(Console.ReadLine(), out  resultat)) {
    Console.WriteLine("Erreur, vous devez entrer un nombre.");
}

Console.WriteLine($"Ok, vous avez réussi à convertir la valeur: {resultat}");

// 3. Conversion implicite

int entier = 2147483647;

long longEntier = entier + 1L;

// 4. Conversion explicite

int entierLong = (int)longEntier;

double res = 100 / (double)200 * 5;

char lettreA = (char)65;

Console.WriteLine("Lettre A: " + lettreA);

// 5. Boxing & Unboxing

// Boxing: Transformer un type valeur en type référence
// Unboxing: Transformer un type référence en type valeur

int monEntier = 5;
object o = monEntier; // boxing
int monEntier2 = (int)o; // unboxing



