using System;
using System.Collections.Generic;

namespace _111.Model;

public partial class Point
{
    public int Id { get; set; }

    public string Post { get; set; }

    public string Adress { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
