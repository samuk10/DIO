using Xunit;
public class testclass
{
    [Fact]
    public void PassingAddTest()
    {
        // Acontece que eu vou testar a variável Add como 2 + 2 
        // e ela tem que retornar 4 caso meu código esteja correto.
        Assert.Equal(4, Program.Add(2, 2));
        // Se eu colocar 5 no lugar do 4 e rodar o teste vai apresentar falha no teste
        // significando que o código "está quebrado"
    }

    [Fact]
    public void FailingTest()
    {
        // Acontece que eu vou testar a variável Add como 2 + 2 
        // e ela tem que retornar diferente de 5.
        Assert.NotEqual(5, Program.Add(2, 2));
    }

    // Aqui vamos testar vários valores!
    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    // O erro está aqui, 6 não é ÍMPAR!!! 
    [InlineData(6)]
    public void MyFirstTheory(int mynumber)
    {
        Assert.True(Program.IsOdd(mynumber));
    }
}