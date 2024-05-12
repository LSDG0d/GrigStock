using GrigStock.Model;

namespace GrigStock;

public partial class Provider
{
    public int ProviderId { get; set; }

    public string ProviderName { get; set; } = null!;

    public string? ProviderContact { get; set; }

    public string? ProviderAddress { get; set; }

    public string? ProviderPhone { get; set; }

    public string? ProviderMail { get; set; }

    public virtual ICollection<Tovar> Tovars { get; set; } = new List<Tovar>();
}
