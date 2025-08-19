using TodoList.Enums;

namespace TodoList.Models;

public struct Tache
{
    public string Titre { get; set; }
    public string? Description { get; set; }
    public StatutTache StatutTache{ get; set; }
    public DateTime DateCreation { get; set; }
}
