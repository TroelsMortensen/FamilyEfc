namespace FamilyEfc.Entities;

public class Pet
{
    public int Id { get; set; }

    public string? Species { get; set; }

    public string? Name { get; set; }

    public int Age { get; set; }

    public int? ChildId { get; set; }

    public int? FamilyHouseNumber { get; set; }

    public string? FamilyStreetName { get; set; }

    public Child? Child { get; set; }

    public Family? Family { get; set; }
}