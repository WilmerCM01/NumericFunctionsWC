using System;

namespace Programas
{
    class Program
    {

        static int abs(int x){

            if((1 + (x >> 31) - (-x >> 31)) == 0){

                x = ~x + 1;

            }

            return x;

        }

        static Boolean isPositive(int x){

            Boolean verificador = false;

            if((1 + (x >> 31) - (-x >> 31)) == 2){

                verificador = true;

            }

            return verificador;

        }

        static Boolean isNegative(int x){

            Boolean verificador = false;

            if((1 + (x >> 31) - (-x >> 31)) == 0){

                verificador = true;

            }

            return verificador;

        }

        static Boolean isOdd(int x){

            Boolean verificador = false;

            if((x ^ 1) != x+1){

                verificador = true;

            }

            return verificador;

        }

        static Boolean isEven(int x){

            Boolean verificador = false;

            if((x ^ 1) == x+1){

                verificador = true;

            }

            return verificador;

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Selecciona una opción: ");
            Console.WriteLine();
            Console.WriteLine("1- Valor absoluto de un número");
            Console.WriteLine("2- Verificar si un número es positivo");
            Console.WriteLine("3- Verificar si un número es negativo");
            Console.WriteLine("4- Verificar si un número es impar");
            Console.WriteLine("5- Verificar si un número es par");

            Console.WriteLine();
            int eleccion = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (eleccion)
            {
                case 1:
                    Console.WriteLine("Introduzca un número: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Valor absoluto: " + abs(numero));
                    break;
                case 2:
                    Console.WriteLine("Introduzca un número: ");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if(isPositive(numero) ==  true){

                        Console.WriteLine("Es positivo");

                    }else{

                        Console.WriteLine("No es positivo");
                    }
                    break;
                case 3:
                    Console.WriteLine("Introduzca un número: ");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if(isNegative(numero) ==  true){

                        Console.WriteLine("Es negativo");

                    }else{

                        Console.WriteLine("No es negativo");
                    }
                    break;
                case 4:
                    Console.WriteLine("Introduzca un número: ");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if(isOdd(numero) ==  true){

                        Console.WriteLine("Es impar");

                    }else{

                        Console.WriteLine("No es impar");
                    }
                    break;
                case 5:
                    Console.WriteLine("Introduzca un número: ");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if(isEven(numero) ==  true){

                        Console.WriteLine("Es par");

                    }else{

                        Console.WriteLine("No es par");
                    }
                    break;
                
            }

            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}