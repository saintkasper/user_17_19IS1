﻿using System;
using System.Collections.Generic;

namespace _111.Model;

public partial class Orderproduct
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int OrderId { get; set; }

    public int Quantity { get; set; }

    public virtual Order Order { get; set; }

    public virtual Product Product { get; set; }
}
