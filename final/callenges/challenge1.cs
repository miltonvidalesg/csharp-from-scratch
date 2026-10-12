using System;
using System.Collections.Generic;
using System.Linq;

namespace itm.basic
{
    // Challenge 1: Solicita un número y determina si es positivo, negativo o cero
    public class Challenge1
    {
        public void Run()
        {
            Console.Write("Ingrese un número: ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                if (numero > 0)
                    Console.WriteLine("El número es positivo.");
                else if (numero < 0)
                    Console.WriteLine("El número es negativo.");
                else
                    Console.WriteLine("El número es cero.");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }

    // Challenge 2: Solicita dos números y muestra el mayor entre ellos
    public class Challenge2
    {
        public void Run()
        {
            Console.Write("Ingrese el primer número: ");
            double.TryParse(Console.ReadLine(), out double num1);
            Console.Write("Ingrese el segundo número: ");
            double.TryParse(Console.ReadLine(), out double num2);

            if (num1 > num2)
                Console.WriteLine($"El número mayor es: {num1}");
            else if (num2 > num1)
                Console.WriteLine($"El número mayor es: {num2}");
            else
                Console.WriteLine("Ambos números son iguales.");
        }
    }

    // Challenge 3: Solicita un número y muestra su cuadrado
    public class Challenge3
    {
        public void Run()
        {
            Console.Write("Ingrese un número: ");
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                double cuadrado = Math.Pow(num, 2);
                Console.WriteLine($"El cuadrado de {num} es: {cuadrado}");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }

    // Challenge 4: Solicita el radio de un círculo y calcula su área
    public class Challenge4
    {
        public void Run()
        {
            Console.Write("Ingrese el radio del círculo: ");
            if (double.TryParse(Console.ReadLine(), out double radio) && radio >= 0)
            {
                double area = Math.PI * Math.Pow(radio, 2);
                Console.WriteLine($"El área del círculo con radio {radio} es: {area:F2}");
            }
            else
            {
                Console.WriteLine("Radio no válido.");
            }
        }
    }

    // Challenge 5: Solicita un número del 1 al 7 y muestra el día de la semana con un switch
    public class Challenge5
    {
        public void Run()
        {
            Console.Write("Ingrese un número entre 1 y 7: ");
            if (int.TryParse(Console.ReadLine(), out int dia))
            {
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("Día: Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Día: Martes");
                        break;
                    case 3:
                        Console.WriteLine("Día: Miércoles");
                        break;
                    case 4:
                        Console.WriteLine("Día: Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Día: Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Día: Sábado");
                        break;
                    case 7:
                        Console.WriteLine("Día: Domingo");
                        break;
                    default:
                        Console.WriteLine("Número no válido. Debe ingresar un valor entre 1 y 7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }

    // Challenge 6: Solicita el salario mensual y calcula el 10% de impuesto si supera 1000
    public class Challenge6
    {
        public void Run()
        {
            Console.Write("Ingrese su salario mensual: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal salario))
            {
                if (salario > 1000)
                {
                    decimal impuesto = salario * 0.10m;
                    Console.WriteLine($"El salario excede los 1000. El impuesto a pagar (10%) es: {impuesto:C}");
                }
                else
                {
                    Console.WriteLine("El salario no excede los 1000, por lo que no aplica impuesto.");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }

    // Challenge 7: Solicita dos números y realiza la división con manejo de excepciones Try-Catch
    public class Challenge7
    {
        public void Run()
        {
            try
            {
                Console.Write("Ingrese el dividendo (entero): ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el divisor (entero): ");
                int num2 = int.Parse(Console.ReadLine());

                int resultado = num1 / num2;
                Console.WriteLine($"El resultado de la división es: {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error específico: No se puede dividir entre cero ({ex.Message}).");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error de formato: Ingrese números enteros válidos ({ex.Message}).");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error general inesperado: {ex.Message}");
            }
        }
    }

    // Challenge 8: Calcula y muestra la suma de los números impares del 1 al 100 con un ciclo for
    public class Challenge8
    {
        public void Run()
        {
            int sumaImpares = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    sumaImpares += i;
                }
            }
            Console.WriteLine($"La suma de los números impares entre 1 y 100 es: {sumaImpares}");
        }
    }

    // Challenge 9: solicita al usuario los valores para dos fraccones y muestra la suma de esas fracciones.*/
    public class Challenge9
    {
        public void Run()
        {
            Console.WriteLine("--- Primera Fracción ---");
            Console.Write("Numerador: ");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.Write("Denominador: ");
            int.TryParse(Console.ReadLine(), out int den1);

            Console.WriteLine("--- Segunda Fracción ---");
            Console.Write("Numerador: ");
            int.TryParse(Console.ReadLine(), out int num2);
            Console.Write("Denominador: ");
            int.TryParse(Console.ReadLine(), out int den2);

            if (den1 == 0 || den2 == 0)
            {
                Console.WriteLine("El denominador no puede ser cero.");
                return;
            }

            Fraccion f1 = new Fraccion(num1, den1);
            Fraccion f2 = new Fraccion(num2, den2);

            Fraccion resultado = f1.Sumar(f2);
            Console.WriteLine($"La suma de {f1} + {f2} es: {resultado}");
        }
    }

    // Clase auxiliar para el ejercicio 9 (Programación Orientada a Objetos)
    public class Fraccion
    {
        public int Numerador { get; set; }
        public int Denominador { get; set; }

        public Fraccion(int numerador, int denominador)
        {
            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Sumar(Fraccion otra)
        {
            int nuevoNumerador = (Numerador * otra.Denominador) + (otra.Numerador * Denominador);
            int nuevoDenominador = Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }

        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }

    // Challenge 10: Solicita una palabra y la muestra en orden inverso
    public class Challenge10
    {
        public void Run()
        {
            Console.Write("Ingrese una palabra o texto: ");
            string palabra = Console.ReadLine();

            if (!string.IsNullOrEmpty(palabra))
            {
                char[] caracteres = palabra.ToCharArray();
                Array.Reverse(caracteres);
                string invertida = new string(caracteres);
                Console.WriteLine($"Palabra invertida: {invertida}");
            }
            else
            {
                Console.WriteLine("No se ingresó ningún texto.");
            }
        }
    }

    // Challenge 11: Solicita al usuario tres números y se muetra el promedio de esos numero.*/
    public class Challenge11
    {
        public void Run()
        {
            Console.Write("Ingrese el primer número: ");
            double.TryParse(Console.ReadLine(), out double n1);
            Console.Write("Ingrese el segundo número: ");
            double.TryParse(Console.ReadLine(), out double n2);
            Console.Write("Ingrese el tercer número: ");
            double.TryParse(Console.ReadLine(), out double n3);

            double promedio = (n1 + n2 + n3) / 3.0;
            Console.WriteLine($"El promedio de los tres números es: {promedio:F2}");
        }
    }

    // Challenge 12: Solicita cinco números y muestra el nmero ms grande de esos cinco//
    public class Challenge12
    {
        public void Run()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Ingrese 5 números enteros:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Número {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int valor))
                {
                    numeros.Add(valor);
                }
                else
                {
                    Console.WriteLine("Valor inválido, asignando 0 por defecto.");
                    numeros.Add(0);
                }
            }

            int maximo = numeros.Max();
            Console.WriteLine($"El número más grande entre los cinco es: {maximo}");
        }
    }

    // Challenge 13: Solicita una palabra y determina si es un palíndromo (se lee igual de izquierda a derecha y de derecha a izquierda)
    public class Challenge13
    {
        public void Run()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine()?.Trim();

            if (!string.IsNullOrEmpty(palabra))
            {
                string limpia = palabra.ToLower().Replace(" ", "");
                char[] arr = limpia.ToCharArray();
                Array.Reverse(arr);
                string invertida = new string(arr);

                if (limpia == invertida)
                    Console.WriteLine($"'{palabra}' es un palíndromo (se lee igual en ambos sentidos).");
                else
                    Console.WriteLine($"'{palabra}' no es un palíndromo.");
            }
            else
            {
                Console.WriteLine("Texto no válido.");
            }
        }
    }

    // Challenge 14: Solicita un número y determina si es par o impar
    public class Challenge14
    {
        public void Run()
        {
            Console.Write("Ingrese un número entero: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num % 2 == 0)
                    Console.WriteLine($"El número {num} es par.");
                else
                    Console.WriteLine($"El número {num} es impar.");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }

    // Challenge 15: Solicita un número y verifica si está en el rango de 0 a 10
    public class Challenge15
    {
        public void Run()
        {
            Console.Write("Ingrese un número: ");
            if (double.TryParse(Console.ReadLine(), out double num))
            {
                if (num >= 0 && num <= 10)
                    Console.WriteLine($"El número {num} está dentro del rango del 0 al 10.");
                else
                    Console.WriteLine($"El número {num} está fuera del rango del 0 al 10.");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }
}