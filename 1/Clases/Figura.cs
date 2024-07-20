using System;

namespace PracticaOOP.Clases
{ 
        public abstract class Figura
        {
            public abstract double CalcularArea();
        }

        public class Rectangulo : Figura
        {
            public double Ancho { get; set; }
            public double Alto { get; set; }

            public Rectangulo(double ancho, double alto)
            {
                Ancho = ancho;
                Alto = alto;
            }

            public override double CalcularArea()
            {
                return Ancho * Alto;
            }
        }

        public class Circulo : Figura
        {
            public double Radio { get; set; }

            public Circulo(double radio)
            {
                Radio = radio;
            }

            public override double CalcularArea()
            {
                return Math.PI * Radio * Radio;
            }
        }

        public class Triangulo : Figura
        {
            public double Base { get; set; }
            public double Altura { get; set; }

            public Triangulo(double baseTriangulo, double altura)
            {
                Base = baseTriangulo;
                Altura = altura;
            }

            public override double CalcularArea()
            {
                return 0.5 * Base * Altura;
            }
        }
}

