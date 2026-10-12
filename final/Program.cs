using System;

namespace itm.basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"¡Hola {nombre}! Por favor, elige un ejercicio del sistema menu:");

            Menu.MostrarMenu();

            while (true)
            {
                Console.Write("\nSeleccione una opción (1-15) o 'Q' / 'exit' para salir: ");
                string opcion = Console.ReadLine()?.Trim();

                if (string.Equals(opcion, "Q", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(opcion, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\n¡Hasta luego! Gracias por usar el programa.");
                    break;
                }

                if (int.TryParse(opcion, out int seleccion) && seleccion >= 1 && seleccion <= 15)
                {
                    Console.WriteLine($"\n--- Ejecutando Challenge {seleccion} ---");
                    switch (seleccion)
                    {
                        case 1:
                            Challenge1 challenge1 = new Challenge1();
                            challenge1.Run();
                            break;
                        case 2:
                            Challenge2 challenge2 = new Challenge2();
                            challenge2.Run();
                            break;
                        case 3:
                            Challenge3 challenge3 = new Challenge3();
                            challenge3.Run();
                            break;
                        case 4:
                            Challenge4 challenge4 = new Challenge4();
                            challenge4.Run();
                            break;
                        case 5:
                            Challenge5 challenge5 = new Challenge5();
                            challenge5.Run();
                            break;
                        case 6:
                            Challenge6 challenge6 = new Challenge6();
                            challenge6.Run();
                            break;
                        case 7:
                            Challenge7 challenge7 = new Challenge7();
                            challenge7.Run();
                            break;
                        case 8:
                            Challenge8 challenge8 = new Challenge8();
                            challenge8.Run();
                            break;
                        case 9:
                            Challenge9 challenge9 = new Challenge9();
                            challenge9.Run();
                            break;
                        case 10:
                            Challenge10 challenge10 = new Challenge10();
                            challenge10.Run();
                            break;
                        case 11:
                            Challenge11 challenge11 = new Challenge11();
                            challenge11.Run();
                            break;
                        case 12:
                            Challenge12 challenge12 = new Challenge12();
                            challenge12.Run();
                            break;
                        case 13:
                            Challenge13 challenge13 = new Challenge13();
                            challenge13.Run();
                            break;
                        case 14:
                            Challenge14 challenge14 = new Challenge14();
                            challenge14.Run();
                            break;
                        case 15:
                            Challenge15 challenge15 = new Challenge15();
                            challenge15.Run();
                            break;
                    }
                    Console.WriteLine("------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, seleccione un número entre 1 y 15, o ingrese 'Q' o 'exit' para salir.");
                }
            }
        }
    }
}