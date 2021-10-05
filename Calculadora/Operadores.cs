

namespace Calculadora {
    class Operadores {
        public static decimal Calcular (int num1, int num2, string operador) {

            decimal resultado;

            switch (operador) 
            {
                case "+":
                    resultado = Somar(num1, num2);
                    break;
                case "-":
                    resultado = Subtrair(num1, num2);
                    break;
                case "*":
                    resultado = Multiplicar(num1, num2);
                    break;
                case "/":
                    resultado = Dividir(num1, num2);
                    break;
                default:
                    resultado = 0;
                    break;
            }
            return resultado;
        }

        private static decimal Somar(decimal num1, decimal num2) { // private para ninguém chama-ló fora da classe e static para não precisar fazer uma instancia.

            return num1 + num2;
        }

        private static decimal Subtrair(decimal num1, decimal num2) {
            return num1 - num2;
        }

        private static decimal Multiplicar(decimal num1, decimal num2) {
            return num1 * num2;
        }
        private static decimal Dividir(decimal num1, decimal num2) {
            return num1 / num2;
        }





    }
}
