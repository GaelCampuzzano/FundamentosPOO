using FundamentosPOO.Abstractas;
using System;
internal class Circulo : Figura
{
    public double Radio { get; set; }

    public override void CalcularArea()
    {
        Area = (int)(Math.PI * Radio * Radio);
    }

    public override void CalcularPerimetro()
    {
        Perimetro = (int)(2 * Math.PI * Radio);
    }
}
