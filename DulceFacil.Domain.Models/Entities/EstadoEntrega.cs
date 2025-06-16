using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class EstadoEntrega
{
    public int IdEstado { get; set; }

    public string NombreEstado { get; set; } = null!;

    public string? DescripcionEstado { get; set; }

    public int OrdenSecuencial { get; set; }

    public bool? NotificaCliente { get; set; }

    public virtual ICollection<Entrega> Entregas { get; set; } = new List<Entrega>();
}
