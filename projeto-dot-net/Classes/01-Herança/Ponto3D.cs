namespace Classes.Herança
{
    public class Ponto3D : Ponto
    // Ele herda da outra classe Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //Faz alguma coisa...
        }
        public override void CalcularDistancia3()
        {
            // da um overwrite
            //Faz outra coisa ...
            base.CalcularDistancia3();
        }
    }
}