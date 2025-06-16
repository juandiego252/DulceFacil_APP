using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; } = null!;

    public string TipoNegocio { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public string? EstadoCliente { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdDireccion { get; set; }

    public virtual CategoriaCliente? IdCategoriaNavigation { get; set; }

    public virtual Direccion? IdDireccionNavigation { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
