using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class Conductor
{
    public int IdConductor { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Cedula { get; set; } = null!;

    public string? Telefono { get; set; }

    public string LicenciaConducir { get; set; } = null!;

    public DateTime? FechaIngreso { get; set; }

    public string? EstadoConductor { get; set; }

    public virtual ICollection<Rutum> Ruta { get; set; } = new List<Rutum>();
}
