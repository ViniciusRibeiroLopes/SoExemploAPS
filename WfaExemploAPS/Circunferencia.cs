using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaExemploAPS
{
    public abstract class Circunferencia : FormaGeometrica
    {
		private double raio;

		public double Raio
		{
			get { return raio; }
			set { raio = value; }
		}

		private double pi;

		public double PI
		{
			get { return pi; }
			set { pi = value; }
		}

        public override double CalcularArea()
        {
			return (Math.PI * Math.Pow(raio, 2));
        }

        public override double CalcularPerimetro()
        {
            return (Math.PI * (raio * 2) * 3);
        }


    }
}
