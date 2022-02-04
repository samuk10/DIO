namespace Classes.Metodos
{
    public class Out
    {
        static void Dividir(int x, int y, out int resultado, out int resto)
        {
            // % = retorna resto de uma divisão
            resultado = x / y;
            resto = x % y;
        }

        public static void Dividir()
        // usando o método dividir
        {
            Dividir(10, 3, out int resultado, out int resto);
            System.Console.WriteLine("{0} {1}", resultado, resto);	// Escreve "3 1"
        }
    }
}