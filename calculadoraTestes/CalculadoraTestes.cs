using Calculadora.Services;

namespace calculadoraTestes;

public class CalculadoraTestes
{

    private ClassCalc _calculadora;

    public CalculadoraTestes()
    {
        _calculadora = new ClassCalc();
    }

    [Fact]
    public void Somar_1com1_Retornar2()
    {
        int x = 1;
        int y = 1;
        
        int res = _calculadora.Somar(x, y);

        Assert.Equal(2, res);
    }

    [Fact]
    public void Subtrair_1com1_Retornar0()
    {
        int x = 1;
        int y = 1;
        
        int res = _calculadora.Subtrair(x, y);

        Assert.Equal(0, res);
    }

    [Fact]
    public void Multiplicar_1com1_Retornar1()
    {
        int x = 1;
        int y = 1;
        
        int res = _calculadora.Multiplicar(x, y);

        Assert.Equal(1, res);
    }

    [Fact]
    public void Dividir_1com1_Retornar1()
    {
        int x = 1;
        int y = 1;
        
        double res = _calculadora.Dividir(x, y);

        Assert.Equal(1, res);
    }
}