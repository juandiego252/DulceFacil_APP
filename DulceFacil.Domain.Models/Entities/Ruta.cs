using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class Ruta
{
    public int IdRuta { get; set; }

    public DateOnly FechaRuta { get; set; }

    public decimal? DistanciaTotalKm { get; set; }

    public int? TiempoEstimadoMin { get; set; }

    public int? TiempoRealMin { get; set; }

    public string? EstadoRuta { get; set; }

    public int IdVehiculo { get; set; }

    public int IdConductor { get; set; }

    public virtual ICollection<Entrega> Entregas { get; set; } = new List<Entrega>();

    public virtual Conductor IdConductorNavigation { get; set; } = null!;

    public virtual Vehiculo IdVehiculoNavigation { get; set; } = null!;
}
