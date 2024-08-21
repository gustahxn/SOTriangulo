
using System;

namespace WFATriangulo
{
    internal class TriangulosIsosceles : Triangulo
    {
        private double altura;

        public double Altura

        {
            get { return altura; }
            set { altura = value; }
        }

        private double ba;

        public double Ba
        {
            get { return ba; }
            set { ba = value; }
        }
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }
        private double hipotenusa;

        public double Hipotenusa
        {
            get { return hipotenusa; }
            set { hipotenusa = value; }
        }


        public override double CalcularArea()
        {

            return ba * altura / 2;
        }

        public override double CalcularPerimetro()
        {
            hipotenusa = System.Math.Sqrt(System.Math.Pow(ba, 2) + Math.Pow(altura, 2));
            return hipotenusa * 2 + ba;
        }
    }
}
