using System;
using System.Collections.Generic;

#nullable disable

namespace Practica_03.Models.ModelsBD
{
    public partial class Usuario
    {
        public Usuario()
        {
            VentaProductos = new HashSet<VentaProducto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<VentaProducto> VentaProductos { get; set; }
    }
}
