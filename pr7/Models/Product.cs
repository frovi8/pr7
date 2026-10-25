using System;
using System.Collections.Generic;

namespace pr7.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<ProductInCart> ProductInCarts { get; set; } = new List<ProductInCart>();
}
