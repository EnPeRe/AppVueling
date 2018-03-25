using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class UI
    {
        public static void Menu()
        {
            Console.WriteLine("Elija la operación que quiere realizar:");
            Console.WriteLine("(1) Suma");
            Console.WriteLine("(2) Resta");
            Console.WriteLine("(3) Multiplicación");
            Console.WriteLine("(4) División");
            Console.WriteLine("(5) Salir");
        }

        public static void LlegirNum(Usuario Usuari)
        {
            bool isFloat;
            do
            {
                Console.WriteLine("Escriba el primer numero");
                isFloat = float.TryParse(Console.ReadLine(), out float num1);
                Usuari.Num1 = num1;
            } while (!isFloat);

            do
            {
                Console.WriteLine("Escriba el segundo numero");
                isFloat = float.TryParse(Console.ReadLine(), out float num2);
                Usuari.Num2 = num2;
            } while (!isFloat);
        }
    }
}
