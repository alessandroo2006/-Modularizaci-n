using System;


namespace MultiExpresionProgram
{
    class program
    {
        static void main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Selecciona una opcion:");
                Console.WriteLine("1 calculadora basica:");
                Console.WriteLine("2 validacion de contrasena:");
                Console.WriteLine("3 Numeros Primos:");
                Console.WriteLine("4 Suma de Numeros Pares:");
                Console.WriteLine("5 Conversion de Temperartura:");
                Console.WriteLine("6 Contador de Vocales:");
                Console.WriteLine("7 Calculo Factorial:");
                Console.WriteLine("8 Juego de Adivinanza:");
                Console.WriteLine("9 Pasos por Referencia:");
                Console.WriteLine("10 Tabla de Multiplicar:");
                Console.WriteLine("11 Salir:");
                Console.WriteLine("Elige una Opcion que desees Realizar:");
                if (int.TryParse(Console.ReadLine(), out int choicce))
                {
                    switch (choicce)
                    {
                        case 1:
                            BasicCalculator();
                            break;
                        case 2:
                            passwordValidation();
                            break;
                        case 3:
                            PrimeNumberCheck();
                            break;
                        case 4:
                            SumeEverNumbers();
                            break;
                        case 5:
                            TemperatureConversion();
                            break;
                        case 6:
                            VowelCounter();
                            break;
                        case 7:
                            FactorialCalculation();
                            break;
                        case 8:
                            GuessingGame();
                            break;
                        case 9:
                            PassByReference();
                            break;
                        case 10:
                            MultiplicationTable();
                            break;
                        case 11:
                            return;
                        default:
                            Console.WriteLine("Opcion no valida. Intenta nuevamente.");
                            break;




                    }
                }
                else
                {
                    Console.WriteLine("Entrada no valida intenta nuevamente :");
                }
                Console.WriteLine("presiona alguna tecla para poder continuar:");
                Console.ReadKey();

            }

        }




        static void BasicCalculator()
        {
            Console.Clear();
            Console.WriteLine("Calculadora basica");
            Console.Write("ingresa el primer  numero:");
            if (double.TryParse(Console.ReadLine() out double num1))
            {
                Console.Write("ingresa el segundo numero:");
                if (double.TryParse(Console.ReadLine() out double num2))
                {
                    Console.WriteLine("Selecciona alguna de estas Opciones:");
                    Console.WriteLine("suma");
                    Console.WriteLine("Resta");
                    Console.WriteLine("Multiplicacion");
                    Console.WriteLine("Division");
                    Console.WriteLine("Ingresa alguna Operacion:");
                    if (int.TryParse(Console.ReadLine(), out int operation))
                    {
                        double result = 0;
                        switch (operation)
                        {
                            case 1:
                                result = num1 + num2;
                                break;
                            case 2:
                                result = num1 - num2;
                                break;
                            case 3:
                                result = num1 * num2;
                                break;
                            case 4:
                                if (num2 != 0)
                                {
                                    result = num1 / num2;
                                }
                                else
                                {
                                    Console.WriteLine("Error: al Dividir por cero.");
                                    return;

                                }
                                break;
                            default:
                                Console.WriteLine("operacion no valida.");
                                return;
                        }


                        Console.WriteLine($"El resultado es: {result}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("entrada no valida.");

                    }
                }
                else
                {
                    Console.WriteLine("entrada no valida.");
                }

            }
            static void passwordValidation()
            {
                Console.Clear();
                Console.WriteLine("validacion de contrasena");
                string pasword;
                do
                {

                    Console.Write("Ingresa la contrasena");
                    password = Console.ReadLine();
                } while (password != "holamundo2025");
                Console.WriteLine("Acceso Consedido.");


            }
            static void PrimerNumberCheck()
            {
                Console.Clear();
                Console.WriteLine("Numeros Primos");
                Console.Write("ingresa un numero:");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (Isprime(number))
                    {
                        Console.WriteLine($" {number} es un numero primo.");
                    }
                    else
                    {
                        Console.WriteLine($"{number}no es numero primo.");
                    }

                }
                else
                {
                    Console.WriteLine("Entrada no valida");

                }

            }
            static bool IsPrime(int number)
            {
                if (number <=) return false;
                for (int i = 2; <= Match.Sqrt(number); i++)
        }
            return true;
        }
        static void SumeEvenNumbers()
        {
            Console.Clear();
            Console.WriteLine("suma de numeros pares");
            int sum = 0;
            int number;
            do
            {
                Console.Write("ingresa un numero (0 para terminar):");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number % 2 == 0)
                    {
                        sum += number;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida.");
                }
            }
    Console.WriteLine($"La suma de los números pares es: {sum}");
        }


        static void TemperatureConvesion()
        {
            Console.Clear();
            Console.WriteLine("conversion de temperatura");
            Console.WriteLine("Selecciona la conversion");
            Console.WriteLine("1 Celsius a Faherenheit");
            Console.WriteLine("2 Faherenheit a Celsius");
            Console.Write("ingresa alguna opcion");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.Write("ingresa la temperatura:");
                if (double.TryParse(Console.ReadLine(), out double temperature))

                {
                    double converted = 0;
                    switch (choice)
                    {
                        case 1:
                            converted = CelsiusTOFaherenheit(temperature);
                            break;
                        case 2:
                            converted = FaherenheitToCelsius(temperature);
                            break;
                        default:
                            Console.WriteLine($"la temperatura convertida es de {converted}:");

                    }
                            else
                    {
                        Console.WriteLine("Entrada no Valida:");
                    }
                }
                else
                {
                    Console.Write("entrada no valida:");
                }

            }
            static double CelsiusToFaherenheit(double celsius)
            {
                return (celsius * 9 / 5) + 32;
            }
            static double FaherenheitToCelsius(double Faherenheit)
            {
                return (Faherenheit - 32) * 5 / 9;
            }
            static void VowelCounter()
            {
                Console.Clear();
                Console.WriteLine("contador de vocales:");
                Console.Write("Ingresa alguna Palabra o Frase:");
                string pharse = Console.ReadLine();
                int volwelcount = CountVowels(phrase);
                Console.WriteLine($" La frase contiene {vowelCout} vocales.");

            }
            static int CoutVolwels(string phrase)
            {
                int count = 0;
                foreach (char c in phrase)
                {
                    if ("aeiouAEIOU".Contains(c))
                    {
                        count++;

                    }
                }
                return count;

            }

            static void FactorialCalculation()
            {
                Console.Clear();
                Console.WriteLine("Calculo de factoriales");
                Console.Write("ingresa un numero:");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    long factorial = CalculateFactorial(number);
                    Console.WriteLine($" El factorial del {number} es {factorial}");

                }
                else
                {
                    Console.WriteLine("opcion no valida.");
                }

            }
            static long CalculateFactorial(int number)
            {
                if (number < 0) return -1;
                long factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;

                }
                return factorial;

            }
            static void GuessingGame()
            {
                Console.Clear();
                Console.WriteLine("Juego de adivinanza");
                Random rand = new Random();
                int randomNumber = rand.Next(1, 100);
                int guess;
                do
                {
                    Console.Write("Adivina el número (entre 1 y 100): ");
                    if (int.TryParse(Console.ReadLine(), out guess))
                    {
                        if (guess > randomNumber)
                        {
                            Console.WriteLine("Demasiado alto.");
                        }
                        else if (guess < randomNumber)
                        {
                            Console.WriteLine("Demasiado bajo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida.");
                    }
                } while (guess != randomNumber);
                Console.WriteLine($"¡Felicidades! Adivinaste el número {randomNumber}.");
            }

            static void PassByReference()
            {
                Console.Clear();
                Console.WriteLine("Paso por referencia");
                Console.Write("Ingrese el primer número: ");
                if (int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.Write("Ingrese el segundo número: ");
                    if (int.TryParse(Console.ReadLine(), out int num2))
                    {
                        Console.WriteLine($"Valores originales: num1 = {num1}, num2 = {num2}");
                        Swap(ref num1, ref num2);
                        Console.WriteLine($"Valores intercambiados: num1 = {num1}, num2 = {num2}");
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida.");
                }
            }

            static void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            static void MultiplicationTable()
            {
                Console.Clear();
                Console.WriteLine("Tabla de multiplicar");
                Console.Write("Ingrese un número: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    PrintMultiplicationTable(number);
                }
                else
                {
                    Console.WriteLine("Entrada no válida.");
                }
            }

            static void PrintMultiplicationTable(int number)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} x {i} = {number * i}");
                }
            }
        }
    }



        