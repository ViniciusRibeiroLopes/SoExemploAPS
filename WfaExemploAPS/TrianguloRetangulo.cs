using System;

namespace WfaExemploAPS
{
    public class TrianguloRetangulo : Triangulo
    {
        private double catetoA;
        private double catetoB;

        public double CatetoA
        {
            get { return catetoA; }
            set { catetoA = value; }
        }

        public double CatetoB
        {
            get { return catetoB; }
            set { catetoB = value; }
        }

        private double CalcularHipotenusa()
        {
            return System.Math.Sqrt(catetoA * catetoA + catetoB * catetoB);
        }

        public override double CalcularArea()
        {
            return 0.5 * catetoA * catetoB;
        }

        public override double CalcularPerimetro()
        {
            double hipotenusa = CalcularHipotenusa();
            return catetoA + catetoB + hipotenusa;
        }
    }
}
