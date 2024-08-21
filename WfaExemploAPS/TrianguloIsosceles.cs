using System;

namespace WfaExemploAPS
{
    public class TrianguloIsosceles : Triangulo
    {
        private double ladoa;
        private double _base;

        public double Ladoa
        {
            get { return ladoa; }
            set { ladoa = value; }
        }

        public double Base 
        {
            get { return _base; }
            set { _base = value; }
        }

        public override double CalcularArea()
        {
            double altura = Math.Sqrt(Math.Pow(ladoa, 2) - Math.Pow(_base / 2, 2));
            return (_base * altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 2 * ladoa + _base;
        }
    }
}
