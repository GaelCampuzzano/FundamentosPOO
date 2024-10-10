using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Abstractas
{
    internal class Rectangulo : Figura
    {
        public int MedirLado1 { get; set; }
        public int MedirLado2 { get; set; }

        public override void CalcularArea()
        {
            Area = MedirLado1 * MedirLado2;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = 2 * (MedirLado1 + MedirLado2);
        }
    }
}

