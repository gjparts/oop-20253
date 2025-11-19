using System;
using System.Collections.Generic;

namespace _16_EntityFramework.Models;

public partial class Cliente
{
    public long ClienteId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Comentarios { get; set; }
}
