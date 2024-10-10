using FundamentosPOO.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPOO
{
    internal class Program
    {
        //Tarea:
        //Investigar las clases abstractas con ejemplos
        static void Main(string[] args)
        {
            //Persona2 persona2 = new Persona2("Juan", "Juan@correo.com", 1);
            //Console.ReadLine();
            //persona2.Nombre = "Juan Luis";
            //persona2.Email = "jluis@correo.com";
            //persona2.ImprimeNombre();
            //persona2.ImprimeEmail();
            //persona2.CambiarFecha(DateTime.Now);
            //persona2.ImprimeFecha();
            //Console.ReadLine();

            Cuadrado cuadrado = new Cuadrado()
            {
                MedirLado = 5,
                UnidadMedida = "Metros"
            };
            cuadrado.MuestraArea();
            cuadrado.MuestraPerimetro();
            cuadrado.MedirLado = 8;
            cuadrado.MuestraArea();

            Console.WriteLine();

            Rectangulo rectangulo = new Rectangulo()
            {
                MedirLado1 = 4,
                MedirLado2 = 6,
                UnidadMedida = "Metros"
            };
            rectangulo.CalcularArea();
            rectangulo.CalcularPerimetro();
            rectangulo.MuestraArea();
            rectangulo.MuestraPerimetro();

            Console.WriteLine();

            Circulo circulo = new Circulo()
            {
                Radio = 3.5,
                UnidadMedida = "Metros"
            };
            circulo.CalcularArea();
            circulo.CalcularPerimetro();
            circulo.MuestraArea();
            circulo.MuestraPerimetro();

            Console.WriteLine(); // Separador visual

            // Ejemplo de uso con Triángulo
            Triangulo triangulo = new Triangulo()
            {
                Base = 5,
                Altura = 3,
                Lado1 = 5,
                Lado2 = 4,
                Lado3 = 3,
                UnidadMedida = "Metros"
            };
            triangulo.CalcularArea();
            triangulo.CalcularPerimetro();
            triangulo.MuestraArea();
            triangulo.MuestraPerimetro();

            Console.WriteLine(); // Separador visual

            // Ejemplo de uso con Polígono
            Poligono poligono = new Poligono()
            {
                NumeroLados = 6,
                LongitudLado = 4,
                Apotema = 3.5,
                UnidadMedida = "Metros"
            };
            poligono.CalcularArea();
            poligono.CalcularPerimetro();
            poligono.MuestraArea();
            poligono.MuestraPerimetro();

            Console.ReadLine();
        }
    }
}