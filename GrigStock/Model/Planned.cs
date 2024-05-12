using System;
using System.Collections.Generic;

namespace GrigStock.Model;

public partial class Planned
{
    public int TovarId { get; set; }

    public int OrderId { get; set; }

    public decimal Cost { get; set; }

    public int Count { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Tovar Tovar { get; set; } = null!;
}
