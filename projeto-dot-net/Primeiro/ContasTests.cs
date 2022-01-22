using Xunit;
namespace Contas.Tests
{
    public class ContasTests
    {
        [Fact]
        public void SomaTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 10;
            var contas = new Contas();

            var result = contas.Soma(a, b);

            Assert.Equal(esperado, result);
        }
        [Fact]
        public void SubtracaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 0;
            var contas = new Contas();

            var result = contas.Subtracao(a, b);

            Assert.Equal(esperado, result);
        }
        [Fact]
        public void DivisaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 1;
            var contas = new Contas();

            var result = contas.Divisao(a, b);

            Assert.Equal(esperado, result);
        }
        [Fact]
        public void MultiplicacaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 25;
            var contas = new Contas();

            var result = contas.Multiplicacao(a, b);

            Assert.Equal(esperado, result);
        }
    }
}