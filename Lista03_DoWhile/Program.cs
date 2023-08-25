namespace Lista03_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // --- Exercício 5 ---

            int number = 1, somatoria = 0;

            do
            {
                Console.WriteLine("Digite um número: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                    somatoria += number;

            }
            while (number != 0);

            Console.WriteLine($"A soma do números positivos é: {somatoria}");



            // --- Exercício 6 ---

            float numero = 1, somaMultiplos3 = 0, contadorMultiplos3 = 0;

            do
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToSingle(Console.ReadLine());

                if (numero % 3 == 0 && numero != 0)
                {
                    somaMultiplos3 = somaMultiplos3 + numero;
                    contadorMultiplos3++;
                }
            }
            while (numero != 0);

            Console.WriteLine($"A média de todos os números múltiplos de 3 é: {somaMultiplos3 / contadorMultiplos3}");

        }
    }
}