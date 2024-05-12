using System;
using System.Collections.Generic;

namespace GrigStock.Model;

public partial class Tovar
{
    public int TovarId { get; set; }

    public string TovarName { get; set; } = null!;

    public string TovarCount { get; set; } = null!;

    public decimal TovarCost { get; set; }

    public string? TovarDescription { get; set; }

    public int TypeId { get; set; }

    public int ProviderId { get; set; }

    public virtual Provider Provider { get; set; } = null!;

    public virtual Type Type { get; set; } = null!;
}
