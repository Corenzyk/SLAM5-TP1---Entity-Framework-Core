using System;
using System.Collections.Generic;

namespace SLAM5_TP1___Entity_Framework_Core.Entities;

public partial class MoyenLivraison
{
    public int IdMoyen { get; set; }

    public string NomMoyen { get; set; } = null!;

    public string? DescMoyen { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();
}
