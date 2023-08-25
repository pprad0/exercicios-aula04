namespace Lista_01_For
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // --- Exercício 01 ---
            int numeroA, numeroB;

            Console.WriteLine("Digite o primeiro número do intervalo: ");
            numeroA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número do intervalo: ");
            numeroB = Convert.ToInt32(Console.ReadLine());


            if (numeroA > numeroB)
                Console.WriteLine("Intervalo inválido!");


            for (int i = numeroA; i <= numeroB; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine($"{i} é múltiplo de 3 e 5.");
            }




            // --- Exercício 02 ---

            int pares = 0, impares = 0, numero;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1} º número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine($"Total de números pares: {pares} \nTotal de números ímpares: {impares} \n");
        }
    }
}