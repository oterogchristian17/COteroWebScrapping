﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Producto
    {
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Costo { get; set; }

        public List<Producto> Productos { get; set; }

    }
}
