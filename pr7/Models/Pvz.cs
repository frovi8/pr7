using System;
using System.Collections.Generic;

namespace pr7.Models;

public partial class Pvz
{
    public int PvzId { get; set; }

    public string Adress { get; set; } = null!;

    public int Capacity { get; set; }

    public int WorkLoad { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
