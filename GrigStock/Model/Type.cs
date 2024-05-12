using System;
using System.Collections.Generic;

namespace GrigStock.Model;

public partial class Type
{
    public int TypeId { get; set; }

    public string TypeCategory { get; set; } = null!;

    public string? TypeDescription { get; set; }

    public virtual ICollection<Tovar> Tovars { get; set; } = new List<Tovar>();
}
