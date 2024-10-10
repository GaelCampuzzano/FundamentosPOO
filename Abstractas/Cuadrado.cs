using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Abstractas
{
    internal class Cuadrado : Figura
    {
        public int MedirLado { get; set; }
        public override void CalcularArea()
        {
            Area = MedirLado * MedirLado;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = MedirLado * 4;
        }
    }
}
