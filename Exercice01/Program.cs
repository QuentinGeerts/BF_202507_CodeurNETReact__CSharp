/*
 * Créer une application qui demande à l'utilisateur : 
 * - Son nom
 * - Son prénom
 * - Sa date de naissance
 * 
 * Afficher le message suivant : "Bonjour prenom nom, vous êtes né le dateNaissance"
 */

// Déclaration des variables
string nom, prenom, dateNaissance;
DateOnly date;

// Demander à l'utilisateur de rentrer les infos
Console.WriteLine("Entrez votre nom: ");
nom = Console.ReadLine();

Console.WriteLine("Entrez votre prénom: ");
prenom = Console.ReadLine();

Console.WriteLine("Entrez votre date de naissance (AAAA-MM-JJ): ");
dateNaissance = Console.ReadLine();
date = DateOnly.Parse(dateNaissance);

// Affichage des données
Console.WriteLine($"Bonjour {prenom} {nom}, vous êtes né•e le {date}");