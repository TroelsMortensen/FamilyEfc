using System;
using System.Collections.Generic;

namespace FamilyEfc;

public partial class Interest
{
    public string Type { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Child> Children { get; set; } = new List<Child>();
}
