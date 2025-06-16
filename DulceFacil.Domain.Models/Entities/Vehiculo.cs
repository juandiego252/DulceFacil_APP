using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class Vehiculo
{
    public int IdVehiculo { get; set; }

    public string Placa { get; set; } = null!;

    public string? Modelo { get; set; }

    public decimal CapacidadPesoKg { get; set; }

    public decimal CapacidadVolumenM3 { get; set; }

    public string? EstadoVehiculo { get; set; }

    public bool? GpsActivo { get; set; }

    public virtual ICollection<Rutum> Ruta { get; set; } = new List<Rutum>();
}
