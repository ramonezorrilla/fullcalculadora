// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Runtime.CompilerServices;

namespace fullcalculadora
{
    class fullcalculadora
    { 
        static void Main(String[] args)
        {
            float resultado, a, b;
            string linea;
            int opcion;

            do
            {
                Console.Write("\n---------------------------");
                Console.WriteLine("\n--:: CALCULADORA::   --");
                Console.Write("\n---------------------------");
                Console.Write("\n---------------------------");
                Console.Write("\n---------------------------");
                Console.WriteLine("\n 1.- Suma                  4.- Multiplicación");
                Console.WriteLine("\n 2.- Resta                 5.- División");
                Console.WriteLine("\n 3.- Raíz Cuadrada         6.- Potencia");
                Console.WriteLine("\n                 7.- Salir");
                Console.Write("\n---------------------------");
                Console.WriteLine("\n Nota: Solo funciona con numeros enteros \n");

                Console.WriteLine("\n Elija una opción:    ");
                opcion =  int.Parse(Console.ReadLine());
               
                switch (opcion)
                {
                    case 1: Console.WriteLine("Introduzca el Primer sumando  \n");
                        a = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduzca el Segundo sumando  \n");
                        b = int.Parse(Console.ReadLine());

                        resultado = a + b;

                        Console.WriteLine($"\n LA SUMA DE {a} + {b} ES IGUAL A {resultado}");
                        break;
                    case 2:
                        Console.WriteLine("Introduzca el Primer restando  \n");
                        a = int.Parse(Console.ReadLine());

                        Console.WriteLine("Introduzca el Segundo restando  \n");
                        b = int.Parse(Console.ReadLine());

                        resultado = a - b;

                        Console.WriteLine($"\n LA RESTA DE {a} - {b} ES IGUAL A {resultado}");
                        break;
                    case 3:
                        Console.WriteLine("Introduzca el número al que se le efectuará la raíz  \n");
                        a = float.Parse(Console.ReadLine());

                        if (a > 0)
                        {
                            resultado = (float)Math.Sqrt(a);
                            Console.WriteLine($"\n LA RAIZ CUADRADA DE {a} ES IGUAL A {resultado}");
                        }
                        else {
                            Console.WriteLine("\n No se puede hacer la raíz cuadrada de un numero negativo!!!");
                                }
                        break;

                    case 4:
                        Console.WriteLine("Introduzca el Primer multiplicando  \n");
                        a = float.Parse(Console.ReadLine());

                        Console.WriteLine("Introduzca el Segundo multiplicando  \n");
                        b = float.Parse(Console.ReadLine());

                        resultado = a * b;

                        Console.WriteLine($"\n LA MULTIPLICACION DE {a} X {b} ES IGUAL A {resultado}");
                        break;
                    case 5:
                        Console.WriteLine("Introduzca el Primer dividendo  \n");
                        a = float.Parse(Console.ReadLine());

                        Console.WriteLine("Introduzca el Segundo dividendo  \n");
                        b = float.Parse(Console.ReadLine());

                        if (b != 0)
                        {
                            resultado = a/b;
                            Console.WriteLine($"\n LA DIVISION ENTRE {a} Y {b} ES IGUAL A {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("\n No se puede dividir entre CERO!!!");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Introduzca el número base  \n");
                        a = float.Parse(Console.ReadLine());

                        Console.WriteLine("Introduzca el número exponente  \n");
                        b = float.Parse(Console.ReadLine());
                        if (b > 0)
                            Console.WriteLine("\n solo se admiten exponentes positivos");
                        {
                            resultado = (float)Math.Pow(a, b);
                            Console.WriteLine($"\n EL RESULTADO DE {a} ^ {b} ES IGUAL A {resultado}");
                        }
                        
                        break;

                    case 7: Console.WriteLine("PULSE ENTER PARA SALIR........");
                        break;

                }
            } while (opcion != 7);


        }





    }

}