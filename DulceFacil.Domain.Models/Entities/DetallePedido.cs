﻿using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class DetallePedido
{
    public int IdDetalle { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal? Subtotal { get; set; }

    public int IdPedido { get; set; }

    public int IdProducto { get; set; }

    public virtual Pedido IdPedidoNavigation { get; set; } = null!;

    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
