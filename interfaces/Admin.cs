using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.interfaces
{
    internal class Admin : IUsuario
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Nivel { get; set; }

        public bool ActualizarPerfil(string Nombre, string Email)
        {
            //actualizar información
            return true;
        }

        public void Login()
        {
            //hacer conexion a base de datos y buscar en la tabla admin
            Console.WriteLine("Usuario Logueado");
        }
    }
}
