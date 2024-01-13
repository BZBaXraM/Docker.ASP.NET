namespace MiniMvcCmsApp.Models;

public class OrderViewModel
{
    public Guid Id { get; init; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Order { get; set; } = string.Empty;
    public long Count { get; set; }
    public string Notes { get; set; } = string.Empty;
    public bool IsDelivered { get; set; }
}