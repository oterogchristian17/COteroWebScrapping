using System;
using System.Collections.Generic;

namespace DL;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public byte[]? Imagen { get; set; }
}
