using Practica_03.Models.Interfaces;
using Practica_03.Models.ModelsBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_03.Models.Services
{
    public class UsuarioService : IUsuarioService
    {
        public Usuario Create(Usuario usuario)
        {
            Usuario resul = null;
            string error = "";
            try
            {
                using (var db = new BD_Practica03Context())
                {
                    if(usuario != null)
                    {
                        resul = new Usuario();
                        resul.Nombre = usuario.Nombre;
                        resul.Apellidos = usuario.Apellidos;
                        resul.Telefono = usuario.Telefono;
                        resul.Direccion = usuario.Direccion;

                        db.Usuarios.Add(resul);
                        db.SaveChanges();
                    }
                    else { throw new Exception("Error. Datos Vacios."); }
                }
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            return resul;
        }

        public Usuario Get(int id)
        {
            Usuario resul = null;
            string error = "";
            try
            {
                using (var db = new BD_Practica03Context())
                {
                    var obj = db.Usuarios.Where(u => u.Id == id).FirstOrDefault();
                    if (obj != null) { resul = obj; }
                    else { throw new Exception("Error. Producto no Existe."); }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return resul;
        }
    }
}
