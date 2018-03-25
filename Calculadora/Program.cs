using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculadora
{
    public class Program
    {
        public enum ListMenu { Sumar, Restar, Multiplicar, Dividir };
        static void Main(string[] args)
        {
            bool isInt;
            CalculatorController Calculadora = new CalculatorController();
            ListMenu Operacion = ListMenu.Sumar;
            Usuario Usuari = new Usuario();

            do
            {
                UI.Menu();
                isInt = Int32.TryParse(Console.ReadLine(), out int opcion_num);
                opcion_num--;
                if (isInt && (opcion_num < 4 && opcion_num > -1))
                {
                    Operacion = (ListMenu)opcion_num;

                    UI.LlegirNum(Usuari);
                    switch (Operacion)
                    {
                        case ListMenu.Sumar:
                            Console.WriteLine("El resultado de sumar los números es " + Calculadora.Sumar(Usuari.Num1, Usuari.Num2));
                            break;
                        case ListMenu.Restar:
                            Console.WriteLine("El resultado de restar los números es " + Calculadora.Restar(Usuari.Num1, Usuari.Num2));
                            break;
                        case ListMenu.Multiplicar:
                            Console.WriteLine("El resultado de multiplicar los números es " + Calculadora.Multiplicar(Usuari.Num1, Usuari.Num2));
                            break;
                        case ListMenu.Dividir:
                            Console.WriteLine("El resultado de dividir los números es " + Calculadora.Dividir(Usuari.Num1, Usuari.Num2));
                            break;
                        default:
                            break;
                    }

                }
                if (opcion_num == 4) break;
            } while (true);    
        }

    }
}
