using System;

namespace WfaExemploAPS
{
    public class TrianguloEquilatero : Triangulo
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double CalcularArea()
        {
            return ((Math.Sqrt(3) / 4) * Math.Pow(lado, 2));
        }

        public override double CalcularPerimetro()
        {
            return (3 * lado);
        }
    }

}
