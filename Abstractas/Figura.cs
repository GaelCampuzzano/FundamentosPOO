using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO.Abstractas
{
    internal abstract class Figura
    {
        protected int Area { get; set; }
        protected int Perimetro { get; set; }
        public string UnidadMedida { get; set; }
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
        public void MuestraArea()
        {
            Console.WriteLine($"El Area Es {Area} {UnidadMedida}^2");
        }

        public void MuestraPerimetro()
        {
            Console.WriteLine($"El Perimetro Es {Perimetro} {UnidadMedida}");
        }
    }
}