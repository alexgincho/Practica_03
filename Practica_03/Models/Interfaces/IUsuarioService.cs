using Practica_03.Models.ModelsBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_03.Models.Interfaces
{
    public interface IUsuarioService
    {
        public Usuario Create(Usuario usuario);
        public Usuario Get(int id);
    }
}
