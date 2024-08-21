
namespace WFATriangulo
{
    public class Retangulo : FormaGeometrica
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        private double altura;
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        public override double CalcularArea()
        {
            return lado * altura;
        }

        public override double CalcularPerimetro()
        {
            return lado * 2 + altura * 2;
        }
    }
}
