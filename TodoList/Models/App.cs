using TodoList.Enums;

namespace TodoList.Models;

public struct App
{
    private List<Tache> taches;
    private bool execution = true;

    public App()
    {
        taches = new List<Tache>();
    }

    public void Demarrer()
    {
        while (execution)
        {
            Console.Clear();
            AfficherMenu();
        }
    }
    private void AfficherMenu()
    {
        MenuOptions choix;

        Console.Clear();
        Console.WriteLine("=== GESTIONNAIRE DE TÂCHES ===");
        Console.WriteLine("1. Afficher toutes les tâches");
        Console.WriteLine("2. Ajouter une nouvelle tâche");
        Console.WriteLine("3. Modifier le statut d'une tâche");
        Console.WriteLine("4. Supprimer une tâche");
        Console.WriteLine("5. Rechercher une tâche");
        Console.WriteLine("6. Afficher les statistiques");
        Console.WriteLine("0. Quitter");
        Console.Write("Votre choix : ");

        // Boucle de validation de l'entrée utilisateur
        while (!Enum.TryParse<MenuOptions>(Console.ReadLine(), out choix)
               || !Enum.IsDefined<MenuOptions>(choix))
        {
            Console.Write("Erreur de saisie, réessayez : ");
        }

        Console.Clear();

        switch (choix)
        {
            case MenuOptions.AfficherTache:
                AfficherTaches();
                break;
            case MenuOptions.AjouterTache:
                AjouterTache();
                break;
            case MenuOptions.ModifierStatut:
                ModifierStatut();
                break;
            case MenuOptions.SupprimerTache:
                SupprimerTache();
                break;
            case MenuOptions.RechercherTache:
                RechercherTache();
                break;
            case MenuOptions.AfficherStatistiques:
                AfficherStatistiques();
                break;
            case MenuOptions.Quitter:
                Console.WriteLine("Au revoir !");
                execution = false;
                break;
            default:
                Console.WriteLine("Option non reconnue.");
                break;
        }

        Pause();


    }
    private void AfficherTaches()
    {
        Console.WriteLine("-- Liste des tâches actuelles --");

        if (taches.Count > 0)
        {
            for (int i = 0; i < taches.Count; i++)
            {
                Console.WriteLine($"[{i + 1}]" +
                    $"\tTitre: {taches[i].Titre}\n" +
                    $"\tDescription: {(!string.IsNullOrEmpty(taches[i].Description) ? taches[i].Description : "Aucune description")}\n" +
                    $"\tStatut: {taches[i].StatutTache}\n" +
                    $"\tCréée le: {taches[i].DateCreation}\n");
            }
        }
        else
        {
            Console.WriteLine($" > Aucune tâche dans la liste.");
        }
    }
    private void AjouterTache()
    {
        Console.WriteLine($"-- Création d'une tâche --");

        Console.WriteLine($"Entrez le titre: ");
        string titre = Console.ReadLine();

        while (titre.Length < 3)
        {
            Console.WriteLine($"Erreur, le titre doit faire minimum 3 caractères.");
            titre = Console.ReadLine();
        }

        Console.WriteLine($"Entrez la description (laissez vide pour ignorer): ");
        string? description = Console.ReadLine();

        StatutTache statut = StatutTache.EnAttente;
        DateTime dateCreation = DateTime.Now;

        Tache tache = new Tache()
        {
            Titre = titre,
            Description = description,
            StatutTache = statut,
            DateCreation = dateCreation
        };

        taches.Add(tache);

        Console.WriteLine($"La tâche '{tache.Titre} a bien été créée.");
    }
    private void ModifierStatut()
    {
        Console.WriteLine($"-- Modification d'une tâche --");

        AfficherTaches();

        if (taches.Count == 0)
        {
            return;
        }

        Console.WriteLine($"Quelle tâche voulez-vous modifier (numéro): ");
        int index;
        while (!int.TryParse(Console.ReadLine(), out index) || index <= 0 || index > taches.Count)
        {
            Console.WriteLine($"Erreur, réessayez: ");
        }

        Console.WriteLine($"Tâche sélectionnée: {taches[index - 1].Titre}");
        Console.WriteLine($"Statut actuel: {taches[index - 1].StatutTache}");

        Console.WriteLine($"Statuts disponibles:");

        foreach (StatutTache s in Enum.GetValues<StatutTache>())
        {
            Console.WriteLine($" {(int)s}. {s}");
        }

        Console.WriteLine($"Choix:");

        StatutTache statut;
        while (!Enum.TryParse<StatutTache>(Console.ReadLine(), ignoreCase: true, out statut) || !Enum.IsDefined<StatutTache>(statut))
        {
            Console.WriteLine($"Veuillez entrer une valeur valide:");
        }

        
        // taches[index - 1].StatutTache = statut; // <!> impossible de modifier une copie retournée (type valeur)

        // Pour ce faire, créer une nouvelle tâche, la modifier et remplacer l'ancienne par la nouvelle
        Tache tacheModifiee = taches[index - 1];
        tacheModifiee.StatutTache = statut;
        taches[index - 1] = tacheModifiee;

        Console.WriteLine($"Le statut de la tâche '{tacheModifiee.Titre}' a été modifié vers '{statut}'.");

    }
    private void SupprimerTache()
    {
        Console.WriteLine($"-- Suppression d'une tâche --");

        AfficherTaches();

        if (taches.Count == 0)
        {
            return;
        }

        Console.WriteLine($"Quelle tâche voulez-vous supprimer (numéro): ");
        int index;
        while (!int.TryParse(Console.ReadLine(), out index) || index <= 0 || index > taches.Count)
        {
            Console.WriteLine($"Erreur, réessayez: ");
        }

        string titreTache = taches[index - 1].Titre;

        Console.WriteLine($"Êtes-vous sûr de vouloir supprimer '{titreTache}' ? (o/n): ");
        string confirmation = Console.ReadLine()?.ToLower();

        if (confirmation == "o" || confirmation == "oui")
        {
            taches.RemoveAt(index - 1);
            Console.WriteLine($"La tâche '{titreTache}' a été supprimée avec succès.");
        }
        else
        {
            Console.WriteLine($"Suppression annulée.");
        }
    }
    private void RechercherTache()
    {
        Console.WriteLine($"-- Recherche de tâches --");

        if (taches.Count == 0)
        {
            Console.WriteLine($"Aucune tâche dans la liste.");
            return;
        }

        Console.WriteLine($"Entrez une recherche (titre ou description): ");
        string recherche = Console.ReadLine()?.ToLower() ?? "";

        // Permet de savoir si la chaîne de caractères est nulle, vide
        // ou contient seulement des caractères blancs ;)
        if (string.IsNullOrWhiteSpace(recherche))
        {
            Console.WriteLine($"Terme de recherche invalide.");
            return;
        }

        List<int> tachesTrouvees = new List<int>();

        for (int i = 0; i < taches.Count; i++)
        {
            // On vérifie si le titre ou la description contient la chaîne de caractères de recherche
            // <!> Une description peut-être vide (à vérifier)
            bool trouve = taches[i].Titre.ToLower().Contains(recherche) ||
                         (!string.IsNullOrEmpty(taches[i].Description) &&
                          taches[i].Description.ToLower().Contains(recherche));

            if (trouve)
            {
                tachesTrouvees.Add(i);
            }
        }

        if (tachesTrouvees.Count > 0)
        {
            Console.WriteLine($"Tâches trouvées ({tachesTrouvees.Count}):");
            foreach (int i in tachesTrouvees)
            {
                Console.WriteLine($"[{i + 1}]" +
                    $"\tTitre: {taches[i].Titre}\n" +
                    $"\tDescription: {(string.IsNullOrEmpty(taches[i].Description) ? "Aucune description" : taches[i].Description)}\n" +
                    $"\tStatut: {taches[i].StatutTache}\n" +
                    $"\tCréée le: {taches[i].DateCreation}\n");
            }
        }
        else
        {
            Console.WriteLine($"Aucune tâche trouvée avec le terme '{recherche}'.");
        }
    }
    private void AfficherStatistiques()
    {
        if (taches.Count == 0)
        {
            Console.WriteLine($"Aucune tâche dans la liste.");
            return;
        }

        Console.WriteLine("-- Statistiques --");

        // Compter les tâches par statut
        int nbEnAttente = taches.Count(t => t.StatutTache == StatutTache.EnAttente);
        int nbEnCours = taches.Count(t => t.StatutTache == StatutTache.EnCours);
        int nbTerminee = taches.Count(t => t.StatutTache == StatutTache.Terminee);

        Console.WriteLine($"Total des tâches: {taches.Count}");
        Console.WriteLine($"En attente: {nbEnAttente} ({(nbEnAttente * 100.0 / taches.Count):F1}%)");
        Console.WriteLine($"En cours: {nbEnCours} ({(nbEnCours * 100.0 / taches.Count):F1}%)");
        Console.WriteLine($"Terminées: {nbTerminee} ({(nbTerminee * 100.0 / taches.Count):F1}%)");
    }


    private static void Pause()
    {
        Console.WriteLine($"\n\nAppuyez sur une touche pour continuer...");
        Console.ReadKey();
    }
}
