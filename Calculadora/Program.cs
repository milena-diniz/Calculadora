using System;

namespace Calculadora {
    class Program {
        static void Main(string[] args) {

            int num1, num2;
            decimal resultado;

            string operador;

            Console.Write("Primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Operador:  ");
            operador = Console.ReadLine();

            Console.Write("Segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            resultado = Operadores.Calcular(num1, num2, operador);


            Console.WriteLine($"Calculo: {num1}{operador}{num2}={resultado}");


        }
    }
}
