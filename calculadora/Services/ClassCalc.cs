using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Calculadora.Services
{
  public class ClassCalc
  {
    public int Somar(int x, int y){
      return x + y;
    }

    public int Subtrair(int x, int y){
      return x - y;
    }

    public int Multiplicar(int x, int y){
      return x * y;
    }

    public double Dividir(int x, int y){
      return (x / y) * 1.00;
    }

  }
}