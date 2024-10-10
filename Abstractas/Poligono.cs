using FundamentosPOO.Abstractas;

    internal class Poligono : Figura
{
    public int NumeroLados { get; set; }
    public int LongitudLado { get; set; }
    public double Apotema { get; set; } // Apotema es necesario para calcular el área del polígono regular

    public override void CalcularArea()
    {
        // Fórmula del área para polígonos regulares: (Perimetro * Apotema) / 2
        CalcularPerimetro();
        Area = (int)((Perimetro * Apotema) / 2);
    }

    public override void CalcularPerimetro()
    {
        Perimetro = NumeroLados * LongitudLado;
    }
}