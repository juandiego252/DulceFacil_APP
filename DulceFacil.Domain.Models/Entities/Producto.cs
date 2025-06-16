using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string NombreProducto { get; set; } = null!;

    public string? CategoriaProducto { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Volumen { get; set; }

    public string? EstadoProducto { get; set; }

    public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
}
