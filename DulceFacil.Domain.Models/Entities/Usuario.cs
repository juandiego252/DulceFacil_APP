using System;
using System.Collections.Generic;

namespace DulceFacil.Domain.Models.Entities;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string RolUsuario { get; set; } = null!;

    public string? EstadoUsuario { get; set; }

    public DateTime? FechaCreacion { get; set; }
}
