using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class Entrega
{
    public int IdEntrega { get; set; }

    public DateOnly FechaProgramada { get; set; }

    public DateOnly? FechaRealEntrega { get; set; }

    public TimeOnly HoraProgramada { get; set; }

    public TimeOnly? HoraRealEntrega { get; set; }

    public string? ObservacionesEntrega { get; set; }

    public int IdPedido { get; set; }

    public int IdRuta { get; set; }

    public int IdEstadoEntrega { get; set; }

    public virtual EstadoEntrega IdEstadoEntregaNavigation { get; set; } = null!;

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;

    public virtual Ruta IdRutaNavigation { get; set; } = null!;

    public virtual ICollection<Incidencia> Incidencia { get; set; } = new List<Incidencia>();
}
