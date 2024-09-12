using System;
using System.Collections.Generic;

namespace SLAM5_TP1___Entity_Framework_Core.Entities;

public partial class Style
{
    public int Numstyle { get; set; }

    public string? Libstyle { get; set; }

    public virtual ICollection<Partition> Partitions { get; set; } = new List<Partition>();
}
