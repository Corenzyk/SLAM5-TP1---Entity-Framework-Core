using System;
using System.Collections.Generic;

namespace SLAM5_TP1___Entity_Framework_Core.Entities;

public partial class Partition
{
    public int Numpart { get; set; }

    public string? Libpart { get; set; }

    public int? Prixpart { get; set; }

    public virtual ICollection<Auteur> Numauts { get; set; } = new List<Auteur>();

    public virtual ICollection<Commande> Numcdes { get; set; } = new List<Commande>();
}
