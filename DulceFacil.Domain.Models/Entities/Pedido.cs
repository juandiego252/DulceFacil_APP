using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public DateTime? FechaPedido { get; set; }

    public DateTime FechaRequerida { get; set; }

    public decimal TotalPedido { get; set; }

    public string? EstadoPedido { get; set; }

    public string? Observaciones { get; set; }

    public int IdCliente { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();

    public virtual ICollection<Entrega> Entregas { get; set; } = new List<Entrega>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
