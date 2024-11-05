namespace FamilyEfc.Entities;

public class Child
{
    public int Id { get; set; }

    public int FamilyHouseNumber { get; set; }

    public string FamilyStreetName { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string HairColor { get; set; }

    public string EyeColor { get; set; }

    public int Age { get; set; }

    public double Weight { get; set; }

    public int Height { get; set; }

    public string Sex { get; set; }

    public Family Family { get; set; }

    public ICollection<Pet> Pets { get; set; } = new List<Pet>();

    public ICollection<Interest> InterestsTypes { get; set; } = new List<Interest>();
}