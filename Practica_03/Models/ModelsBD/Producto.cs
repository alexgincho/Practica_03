using System;
using System.Collections.Generic;

#nullable disable

namespace Practica_03.Models.ModelsBD
{
    public partial class Producto
    {
        public Producto()
        {
            VentaProductos = new HashSet<VentaProducto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string Descripcion { get; set; }
        public decimal? Precio { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? IdCategoria { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; }
        public virtual ICollection<VentaProducto> VentaProductos { get; set; }
    }
}
