using System;
using System.Collections.Generic;

namespace FamilyEfc;

public partial class Family
{
    public string StreetName { get; set; } = null!;

    public int HouseNumber { get; set; }

    public virtual ICollection<Adult> Adults { get; set; } = new List<Adult>();

    public virtual ICollection<Child> Children { get; set; } = new List<Child>();

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
