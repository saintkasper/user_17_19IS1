using System;
using System.Collections.Generic;

namespace _111.Model;

public partial class Order
{
    public int Id { get; set; }

    public DateOnly WhenDate { get; set; }

    public DateOnly WhenArrive { get; set; }

    public int PointId { get; set; }

    public int UserId { get; set; }

    public int PickupCode { get; set; }

    public bool IsArrived { get; set; }

    public virtual ICollection<Orderproduct> Orderproducts { get; set; } = new List<Orderproduct>();

    public virtual Point Point { get; set; }

    public virtual User User { get; set; }
}
