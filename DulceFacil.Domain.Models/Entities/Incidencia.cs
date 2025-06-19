using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class Incidencia
{
    public int IdIncidencia { get; set; }

    public DateTime? FechaIncidencia { get; set; }

    public string TipoIncidencia { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? EstadoIncidencia { get; set; }

    public string? SolucionAplicada { get; set; }

    public int? IdEntrega { get; set; }

    public virtual Entrega? IdEntregaNavigation { get; set; }
}
