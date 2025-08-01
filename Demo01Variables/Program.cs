// Demo 01 - Variables


// 1. Déclaration de variables
// > type nomVariable;
// > type nomVariable1, nomVariable2, ... ;

int age;
string nom, prenom;

// 2. Initialisation
// > nomVariable = valeur;

age = 29;
nom = "Geerts";
prenom = "Quentin";

// 3. Déclaration et initialisation
// type nomVariable = valeur;
// type nomVariable1 = valeur, nomVariable2 = valeur, ... ;

bool aPermis = true, aEnfants = false, estMarie;

// 4. Constantes
// const type NOM_CONSTANTE = valeur;

const double TAUX_TVA = 0.21;
// TAUX_TVA = 0.06; // Impossible de modifier une constante

// 5. Nullable
// null: le "rien" informatique (pas de valeur)

// int i = null; // Pas possible

Nullable<int> i = null;
int? j = null; // Sucre syntaxique (raccourci d'écriture)


