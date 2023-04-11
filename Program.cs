using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            calculadora.Introduccion();
        }

        public void Introduccion()
        {
            int opcion;
            try
            {
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("CALCULADORA");
                    Console.WriteLine("Selecciona una opción:");
                    Console.WriteLine("1 - Modo manual");
                    Console.WriteLine("2 - Modo automático");
                    Console.WriteLine("0 - Salir");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            ModoManual();
                            break;
                        case 2:
                            ModoAutomatico();
                            break;
                    }

                } while (opcion != 0);
            }
            catch
            {
                Console.WriteLine("Prueba otra vez:");
                Introduccion();
            }
        }

        public void ModoManual()
        {
            Console.WriteLine("Modo manual");
            Console.WriteLine("Selecciona una operación: +, -, *, /, ^");
            string operacion = Console.ReadLine();
            Console.WriteLine("Escribe un primer valor:");
            if (!double.TryParse(Console.ReadLine(), out double valor1))
            {
                Console.WriteLine("Prueba otra vez:");
                Introduccion();
            }
            Console.WriteLine("Escribe un segundo valor:");
            if (!double.TryParse(Console.ReadLine(), out double valor2))
            {
                Console.WriteLine("Prueba otra vez:");
                Introduccion();
            }
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = valor1 + valor2;
                    Console.WriteLine($"El resultado de sumar {valor1} y {valor2} es {resultado}");
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    Console.WriteLine($"El resultado de restar {valor1} y {valor2} es {resultado}");
                    break;
                case "*":
                    resultado = valor1 * valor2;
                    Console.WriteLine($"El resultado de multiplicar {valor1} y {valor2} es {resultado}");
                    break;
                case "/":
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                        Console.WriteLine($"El resultado de dividir {valor1} y {valor2} es {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero");
                    }
                    break;
                case "^":
                    resultado = 1;
                    for (int i = 0; i < valor2; i++)
                    {
                        resultado *= valor1;
                    }
                    Console.WriteLine($"El resultado de {valor1} elevado a {valor2} es {resultado}");
                    break;
                default:
                    Console.WriteLine("Prueba otra vez:");
                    break;
            }
        }

        public void ModoAutomatico()
        {
            Console.WriteLine("Modo automático");
            Console.WriteLine("Escribe una operación simple (+, -, /, *) con dos operandos:");
            string operacion = Console.ReadLine();

            if (operacion.Contains("+"))
            {
                string[] parte = operacion.Split('+');
                if (parte.Length > 2 || !double.TryParse(parte[0], out double valor1) || !double.TryParse(parte[1], out double valor2))
                {
                    Console.WriteLine("Prueba otra vez:");
                }
                else
                {
                    double resultado = valor1 + valor2;
                    Console.WriteLine($"El resultado de sumar {valor1} y {valor2} es {resultado}");
                }
            }
            else if (operacion.Contains("-"))
            {
                string[] parte = operacion.Split('-');
                if (parte.Length > 2 || !double.TryParse(parte[0], out double valor1) || !double.TryParse(parte[1], out double valor2))
                {
                    Console.WriteLine("Prueba otra vez:");
                }
                else
                {
                    double resultado = valor1 - valor2;
                    Console.WriteLine($"El resultado de restar {valor1} y {valor2} es {resultado}");
                }
            }
            else if (operacion.Contains("*"))
            {
                string[] parte = operacion.Split('*');
                if (parte.Length > 2 || !double.TryParse(parte[0], out double valor1) || !double.TryParse(parte[1], out double valor2))
                {
                    Console.WriteLine("Prueba otra vez:");
                }
                else
                {
                    double resultado = valor1 * valor2;
                    Console.WriteLine($"El resultado de multiplicar {valor1} y {valor2} es {resultado}");
                }
            }
            else if (operacion.Contains("/"))
            {
                string[] parte = operacion.Split('/');
                if (parte.Length > 2 || !double.TryParse(parte[0], out double valor1) || !double.TryParse(parte[1], out double valor2))
                {
                    Console.WriteLine("Prueba otra vez:");
                }
                else if (valor2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre cero");
                }
                else
                {
                    double resultado = valor1 / valor2;
                    Console.WriteLine($"El resultado de dividir {valor1} y {valor2} es {resultado}");
                }
            }
            else
            {
                Console.WriteLine("Prueba otra vez:");
            }
        }
    }
}
