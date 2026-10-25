using System;
using System.Collections.Generic;

namespace pr7.Models;

public partial class Cart
{
    public int CartId { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<ProductInCart> ProductInCarts { get; set; } = new List<ProductInCart>();

    public virtual User User { get; set; } = null!;
}
