namespace FamilyEfc.Entities;

public class Family
{
    public string StreetName { get; set; } = null!;

    public int HouseNumber { get; set; }

    public ICollection<Adult> Adults { get; set; } = new List<Adult>();

    public ICollection<Child> Children { get; set; } = new List<Child>();

    public ICollection<Pet> Pets { get; set; } = new List<Pet>();
}