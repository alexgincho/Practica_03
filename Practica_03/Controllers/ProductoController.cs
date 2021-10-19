using Microsoft.AspNetCore.Mvc;
using Practica_03.Models.Interfaces;
using Practica_03.Models.ModelsBD;
using Practica_03.Models.ResponseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_03.Controllers
{
    public class ProductoController : Controller
    {
        public IProductoService _sP;
        public ProductoController(IProductoService prod)
        {
            this._sP = prod;
        }
        public IActionResult Index()
        {
            ViewBag.Productos = _sP.GetProductoFechas(DateTime.Now); // Llamamos a la funcion 
            return View();
        }
        public IActionResult Create()
        {
            using (var db = new BD_Practica03Context())
            {
                ViewBag.Categorias = db.Categoria.ToList();
            }
            return View();
        }
        // creacion de producto

        [HttpPost]
        public IActionResult CreateProducto([FromBody] Producto producto)
        {
            Response rpta = new Response();
            try
            {
                if (ModelState.IsValid)
                {
                    rpta.Data = _sP.Create(producto);
                    rpta.State = 200;
                    rpta.Message = "Exito";
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                rpta.Data = null;
                rpta.State = 400;
                rpta.Message = "Error";
            }
            return Ok(rpta);
        }
    }
}
