using System;
using System.Collections.Generic;

namespace GrigStock.Model;

public partial class Client
{
    public int ClientId { get; set; }

    public string ClientName { get; set; } = null!;

    public string? ClientContact { get; set; }

    public string? ClientAddress { get; set; }

    public string? ClientPhone { get; set; }

    public string? ClientMail { get; set; }

    public string? ClientDescription { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
