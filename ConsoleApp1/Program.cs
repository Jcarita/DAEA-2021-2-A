using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }
        static double Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static double Division(int a, int b)
        {
            return a / b;
        }

        static void numerosPrimos()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (PrimoR(i))
                {
                    Console.WriteLine(i);
                }
                else
                {

                }
            }
        }
        static bool PrimoR(int num)
        {
            for (int a = 2; a <= num - 1; a++)
            {
                if (num % a == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Raiz() {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("La raiz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static float convertFahrenheitToCelsius(int num)
        {
            return (5 * (num - 32)) / 9;
        }
        static double convertCelsiusToFahrenheit(int num) 
        {
            return ( (9 * num) / 5) + 32;
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            String opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Sumar");
                Console.WriteLine("[4] Resta");
                Console.WriteLine("[5] Multiplicacion");
                Console.WriteLine("[6] Division");
                Console.WriteLine("[7] 10 Numeros Primos");
                Console.WriteLine("[8] Convertir FAHRENHEIT a CELSIUS");
                Console.WriteLine("[9] Converitr CELSIUS a FAHRENHEIT");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer numero: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        int suma = a + b;
                        Console.WriteLine("La sima de {0} y {1} es {2}", a, b, suma);
                        Console.ReadKey();
                        break;
                    case "2":
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("----------------SUMA----------------");
                        Console.WriteLine("Ingrese el primer numero: ");
                        int numberSuma1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        int numberSuma2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma es: {0}", Suma(numberSuma1, numberSuma2));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("----------------RESTA----------------");
                        Console.WriteLine("Ingrese el primer numero: ");
                        int numberResta1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        int numberResta2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta es: {0}", Resta(numberResta1, numberResta2));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("----------------MULTIPLICACION----------------");
                        Console.WriteLine("Ingrese el primer numero: ");
                        int numberMulti1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        int numberMulti2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion es: {0}", Multiplicacion(numberMulti1, numberMulti2));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("----------------DIVISION----------------");
                        Console.WriteLine("Ingrese el primer numero: ");
                        int numberDivision1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        int numberDivision2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division es: {0}", Division(numberDivision1, numberDivision2));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("----------------NUMEROS PRIMOS----------------");
                        numerosPrimos();
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("-------------------CONVERSION TEMPERATURA FAHRENHEIT a CELSIUS---------------");
                        Console.WriteLine("Ingrese Numero: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(convertFahrenheitToCelsius(number));
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.WriteLine("------------------CONVERSION TEMPERATURA CELSIUS A FAHRENHEIT---------------");
                        Console.WriteLine("Ingrese Numero: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(convertCelsiusToFahrenheit(num));
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
            } while (!opcion.Equals("0"));
        }
    }
}
