
namespace WFATriangulo
{
    public class Circuferencia : FormaGeometrica
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public override double CalcularArea()
        {
            return 3.14 * System.Math.Pow(raio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * 3.14 * raio;
        }
    }
}
