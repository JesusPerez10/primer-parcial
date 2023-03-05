using System;

class Program
{
    static void Main(string[] args)
    {
        int N;
        int sumaPares = 0;

        Console.Write("Ingrese un número entero positivo N: ");
        N = int.Parse(Console.ReadLine());

        // Calcular la suma de los números enteros positivos pares menores o iguales que N
        for (int i = 2; i <= N; i += 2)
        {
            sumaPares += i;
        }

        Console.WriteLine("La suma de los números enteros positivos pares menores o iguales que N es: " + sumaPares);

        // Imprimir en pantalla los números enteros positivos menores o iguales que N que sean divisibles entre 2 y 3
        Console.WriteLine("Los números enteros positivos menores o iguales que N que sean divisibles entre 2 y 3 son:");
        for (int i = 1; i <= N; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Imprimir en pantalla los números enteros positivos menores o iguales que N que sean divisibles entre 3 y 5
        Console.WriteLine("Los números enteros positivos menores o iguales que N que sean divisibles entre 3 y 5 son:");
        for (int i = 1; i <= N; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Imprimir en pantalla la secuencia de números enteros positivos que comienzan en N y se decrementan en 1 hasta que se alcance un valor menor que 1
        Console.WriteLine("La secuencia de números enteros positivos que comienzan en N y se decrementan en 1 hasta que se alcance un valor menor que 1 es:");
        for (int i = N; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("El valor de la variable sumaPares al final del proceso es: " + sumaPares);
    }
}
