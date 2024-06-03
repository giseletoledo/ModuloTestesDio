using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImpl
    {
        public int Somar(int num1,int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return (double)num1 / num2;
        }
    }
}