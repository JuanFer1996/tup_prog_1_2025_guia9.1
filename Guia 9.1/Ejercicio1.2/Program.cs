namespace Ejercicio1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] libreta = new int[60];
            double[] notas = new double[60];
            string[] nombres= new string[60];

            Console.WriteLine("Ingrese numero de libreta");
            int n = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            while (n!= - 1){
                libreta[contador]=n; 
                Console.WriteLine("INgrese nombre");
                nombres[contador] = Console.ReadLine;
                Console.WriteLine("ingrese nota");
                notas[contador]=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese numero de libreta");
                int n = Convert.ToInt32(Console.ReadLine());
                contador++;
            }
            



        }
    }
}
