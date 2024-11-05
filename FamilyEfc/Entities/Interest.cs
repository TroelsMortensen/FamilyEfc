namespace FamilyEfc.Entities;

public class Interest
{
    public string Type { get; set; } = null!;

    public string? Description { get; set; }

    public ICollection<Child> Children { get; set; } = new List<Child>();
}