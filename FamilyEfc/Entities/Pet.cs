using System;
using System.Collections.Generic;

namespace FamilyEfc;

public partial class Pet
{
    public int Id { get; set; }

    public string? Species { get; set; }

    public string? Name { get; set; }

    public int Age { get; set; }

    public int? ChildId { get; set; }

    public int? FamilyHouseNumber { get; set; }

    public string? FamilyStreetName { get; set; }

    public virtual Child? Child { get; set; }

    public virtual Family? Family { get; set; }
}
