using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class Sector
{
    public int IdSector { get; set; }

    public string NombreSector { get; set; } = null!;

    public string? ZonaCobertura { get; set; }

    public int? DensidadClientes { get; set; }

    public int? TiempoPromedioEntrega { get; set; }

    public virtual ICollection<Direccion> Direccions { get; set; } = new List<Direccion>();
}
