namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;
            int max;
            int indicemax = 0;
            int min;
            int indicemin = 0;
            int n = 0;
            int[] numeros = new int[100];
            Console.WriteLine("ingrese un numero, -1 para salir");
            n = Convert.ToInt32(Console.ReadLine());
            min = n;
            max = n;
            while (n != -1 || contador == 100)
            {
                numeros[contador] = n;
                Console.WriteLine("ingrese un numero,-1 para salir");
                n = Convert.ToInt32(Console.ReadLine());

                contador++;


            }
            if (contador > 1)
            {
                for (int i = 0; i < contador; i++)
                {
                    acumulador += numeros[i];
                    if (numeros[i] > max)
                    {
                        max = numeros[i];
                        indicemax = i;
                    }
                    if (numeros[i] < min)
                    {
                        min = numeros[i];
                        indicemin = i;
                    }
                }

                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine($"{i}:{numeros[i]}");

                }


                double prom = 1.0 * acumulador / contador;
                Console.WriteLine($"Promedio {prom}");
                Console.WriteLine($"Valor maximo: {max} con indice {indicemax}");
                Console.WriteLine($"Valor minimo: {min} con indice {indicemin}");
            }
        }
    }
}
