using System;
using System.Collections.Generic;

namespace GrigStock.Model;

public partial class Order
{
    public int OrderId { get; set; }

    public int ClientId { get; set; }

    public int EmployeeId { get; set; }

    public DateTime? ShippingDate { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string Recipient { get; set; } = null!;

    public string RecipientAddress { get; set; } = null!;

    public virtual Client Client { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
