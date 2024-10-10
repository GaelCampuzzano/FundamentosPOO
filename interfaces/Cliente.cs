using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.interfaces
{
    internal class Cliente : IUsuario
    {
        public string Nombre { get; set; }
        public string Email { get; set; }

        public bool ActualizarPerfil(string Nombre, string Email)
        {
            throw new NotImplementedException();
        }

        public void Login()
        {
            throw new NotImplementedException();
        }
    }
}
