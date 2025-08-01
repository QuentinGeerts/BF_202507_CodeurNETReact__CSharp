/*
 * Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK sur la console sinon KO.
 * Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. 
 * Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 97.
 * (utilisez la méthode « Substring » de la classe « string »).
 */

// Exemples de BBAN valides:
// - 510007547061
// - 970000000097

string bban = "510007547061";

long tenFirst = long.Parse(bban.Substring(0, 10));
long twoLast = Convert.ToInt64(bban.Substring(10));

bool cond1 = tenFirst % 97 == twoLast;
bool cond2 = tenFirst % 97 == 0 && twoLast == 97;

Console.WriteLine($"{(cond1 || cond2 ? "OK" : "KO")}");