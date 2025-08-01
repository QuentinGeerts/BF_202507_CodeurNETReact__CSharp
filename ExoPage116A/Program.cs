/*
 * Demander à l’utilisateur d’encoder 1 nombre (int), si la somme des deux 
 * moitiés de celui-ci donne le nombre, afficher « le nombre est paire »
 * sinon « le nombre est impaire ».
 */

Console.WriteLine("Entrez un nombre: ");
int nb = int.Parse(Console.ReadLine());

int moitie = nb / 2;

// 1ère version
Console.WriteLine($"Le nombre est { (moitie + moitie == nb ? "pair" : "impair") }");


// 2ème version
string resultat = "";
if (moitie + moitie == nb) resultat = "pair";
else resultat = "impair";
Console.WriteLine($"Le nombre est {resultat}");