

namespace WFATriangulo
{
    internal class TrianguloEquilatero : Triangulo
    {

        private double altura;

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        private int ba;

        public int Ba
        {
            get { return ba; }
            set { ba = value; }
        }   


        private double hipo;

        public double Hipo
        {
            get { return hipo; }
            set { hipo = value; }
        }

        public override double CalcularArea()
        {
            altura = (ba * System.Math.Sqrt(3) / 2);
            return ba * altura / 2;
        }

        public override double CalcularPerimetro()
        {
            return ba * 3;
        }
    }
}
