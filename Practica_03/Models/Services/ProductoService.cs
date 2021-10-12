using Practica_03.Models.Interfaces;
using Practica_03.Models.ModelsBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_03.Models.Services
{
    public class ProductoService : IProductoService
    {
        public Producto Create(Producto producto)
        {
            Producto result = null;
            string error = "";
            try
            {
                using(var db = new BD_Practica03Context())
                {
                    if(producto != null)
                    {
                        result = new Producto();
                        result.Nombre = producto.Nombre;
                        result.Imagen = producto.Imagen;
                        result.Descripcion = producto.Descripcion;
                        result.Precio = producto.Precio;
                        result.Cantidad = producto.Cantidad;
                        result.IdCategoria = producto.IdCategoria;

                        db.Productos.Add(result);
                        db.SaveChanges();
                    }
                    else { throw new Exception("Error. Datos Vacios"); }
                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            return result;
        }

        public Producto Get(int id)
        {
            Producto result = null;
            string error = "";
            try
            {
                using (var db = new BD_Practica03Context())
                {
                    var obj = db.Productos.Where(p => p.Id == id).FirstOrDefault();
                    if(obj != null) { result = obj; }
                    else { throw new Exception("Error. Producto no Existe."); }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return result;
        }

        public List<Producto> GetAll()
        {
            List<Producto> result = null;
            string error = "";
            try
            {
                using (var db = new BD_Practica03Context())
                {
                    var lst = db.Productos.ToList();
                    if(lst.Count > 0) { result = lst; }
                    else { throw new Exception("Error. No hay Productos Registrados"); }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return result;
        }
    }
}
