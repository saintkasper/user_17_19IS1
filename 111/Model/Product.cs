using System;
using System.Collections.Generic;

namespace _111.Model;

public partial class Product
{
    public int Id { get; set; }

    public string Article { get; set; }

    public string Title { get; set; }

    public int UnitId { get; set; }

    public int Cost { get; set; }

    public int MaxDiscount { get; set; }

    public int ManufacturerId { get; set; }

    public int SupplierId { get; set; }

    public int CategoryId { get; set; }

    public int Dicsount { get; set; }

    public int Stock { get; set; }

    public string Specification { get; set; }

    public byte[]? Image { get; set; }

    public virtual Category Category { get; set; }

    public virtual Manufacturer Manufacturer { get; set; }

    public virtual ICollection<Orderproduct> Orderproducts { get; set; } = new List<Orderproduct>();

    public virtual Supplier Supplier { get; set; }

    public virtual Unit Unit { get; set; }
}
