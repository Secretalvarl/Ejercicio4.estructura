namespace Ejercicio4.estructura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribame el tamaño del vector");
            int tamanyo = Convert.ToInt32(Console.ReadLine());

            int[] numeroAleatorio = new int[tamanyo];

            Random voleo = new Random();

            for (int i = 0; i < tamanyo; i++)
            {
                int numeroGuardar = voleo.Next(1, 1000);
                numeroAleatorio[i] = numeroGuardar;

                Console.WriteLine(i + ": " + numeroAleatorio[i]);
            }

            Console.WriteLine("" + "\n" + "");

            Array.Sort(numeroAleatorio);

            for (int j = 0; j < tamanyo; j++)
            {
                Console.WriteLine(j + ": " + numeroAleatorio[j]);
            }

        }
    }
}