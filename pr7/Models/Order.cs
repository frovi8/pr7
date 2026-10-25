using System;
using System.Collections.Generic;

namespace pr7.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public int PvzId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Pvz Pvz { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
