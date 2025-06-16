using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class Direccion
{
    public int IdDireccion { get; set; }

    public string DireccionCompleta { get; set; } = null!;

    public decimal Latitud { get; set; }

    public decimal Longitud { get; set; }

    public string? Referencia { get; set; }

    public int? IdSector { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual Sector? IdSectorNavigation { get; set; }
}
