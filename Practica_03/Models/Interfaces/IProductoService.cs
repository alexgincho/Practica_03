using Practica_03.Models.ModelsBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_03.Models.Interfaces
{
    public interface IProductoService
    {
        public Producto Create(Producto producto);
        public Producto Get(int id);
        public List<Producto> GetAll();
        public List<Producto> GetProductoFechas(DateTime fFechaActual);
    }
}
