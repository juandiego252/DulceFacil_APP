using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class CategoriaCliente
{
    public int IdCategoria { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? CriteriosClasificacion { get; set; }

    public int? PrioridadEntrega { get; set; }

    public decimal? DescuentoAplicable { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}
