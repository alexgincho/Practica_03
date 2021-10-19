using System;
using System.Collections.Generic;

#nullable disable

namespace Practica_03.Models.ModelsBD
{
    public partial class VentaProducto
    {
        public int Id { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdProducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Total { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
