

using System;


namespace WFATriangulo
{
    internal class TrianguloRetangulo : Triangulo
    {
        private double altura;

        public double Altura

        {
            get { return altura; }
            set { altura = value; }
        }

        private double _base;

        public double Ba
        {
            get { return _base; }
            set { _base = value; }
        }

        private double hipo;

        public double Hipo
        {
            get { return hipo; }
            set { hipo = value; }
        }

        public override double CalcularArea()
        {
            return _base * altura / 2;
        }

        public override double CalcularPerimetro()
        {
            hipo = System.Math.Sqrt(System.Math.Pow(_base, 2) + Math.Pow(altura, 2));
            return altura + _base + hipo;
        }
    }
}
