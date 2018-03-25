using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class CalculatorController
    {
        public float Sumar(float num1, float num2)
        {
            return num1 + num2;
        }
        public float Restar(float num1, float num2)
        {
            return num1 - num2;
        }
        public float Multiplicar(float num1, float num2)
        {
            return num1 * num2;
        }
        public float Dividir(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}
