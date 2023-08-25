namespace Lista02_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Exercício 03 ---

            int idade = 0;
            int menorDeIdade = 0, maiorDeIdade = 0;

            while (true)
            {
                Console.WriteLine("\nDigite uma idade: ");
                idade = Convert.ToInt32(Console.ReadLine());


                if (idade < 0)
                    break;

                else if (idade < 21)
                    menorDeIdade++;

                else
                    maiorDeIdade++;
            }

            Console.WriteLine($"Total de pessoas menores de 21 anos: {menorDeIdade} pessoas. \nTotal de pessoas maiores de 21 anos: {maiorDeIdade} pessoas.");


            // --- Exercício 04 ---

            int idadee = 0, identidadeGenero = 0, cargo = 0;
            int totalIdade = 0;

            int mulheresCis = 0, homensCis = 0, naoBinarios = 0, mulheresTrans = 0, homensTrans = 0, outros = 0;
            int backEnd = 0, frontEnd = 0, mobile = 0, fullStack = 0, totalDePessoas = 0;

            int menorQue30 = 0, maiorQue40 = 0;
            int homensCisTrans_mobile_maisQuarenta = 0, naoBinarios_fullStack_menosTrinta = 0;
            string? condicao = "n";

            while (true)
            {
                Console.WriteLine("Digite sua idade: ");
                idadee = Convert.ToInt32(Console.ReadLine());

                totalIdade += idadee;
                totalDePessoas++;

                if (idadee < 30)
                    menorQue30++;
                else if (idadee > 40)
                    maiorQue40++;


                Console.WriteLine("Qual a sua identidade de gênero? \n1 – Mulher Cis\r\n2 – Homem Cis\r\n3 – Não Binário\r\n4 – Mulher Trans\r\n5 – Homem Trans\r\n6 – Outros\r\n ");
                identidadeGenero = Convert.ToInt32(Console.ReadLine());


                switch (identidadeGenero)
                {
                    case 1:
                        mulheresCis++;
                        break;

                    case 2:
                        homensCis++;
                        break;

                    case 3:
                        naoBinarios++;
                        break;

                    case 4:
                        mulheresTrans++;
                        break;
                    case 5:
                        homensTrans++;
                        break;
                    case 6:
                        outros++;
                        break;
                }

                Console.WriteLine("Qual o seu cargo? \n1 – Backend\r\n2 – Frontend\r\n3 – Mobile\r\n4 – FullStack\r\n ");
                cargo = Convert.ToInt32(Console.ReadLine());

                switch (cargo)
                {
                    case 1:
                        backEnd++;
                        break;

                    case 2:
                        frontEnd++;
                        break;

                    case 3:
                        mobile++;
                        break;

                    case 4:
                        fullStack++;
                        break;
                }


                if ((identidadeGenero == 2 || identidadeGenero == 5) && cargo == 3 && idadee >= 40)
                    homensCisTrans_mobile_maisQuarenta++;
                else if (identidadeGenero == 3 && cargo == 4 && idadee <= 30)
                    naoBinarios_fullStack_menosTrinta++;

                Console.WriteLine("Gostaria de registrar mais pessoas? Digite 's' ou 'n'. (s/n)");
                condicao = Console.ReadLine();

                if (condicao == "n")
                    break;
            }

            Console.WriteLine($"Total de pessoas desenvolvedoras Backend: {backEnd}. \r\n");
            Console.WriteLine($"Total de homens cis e trans desenvolvedores Mobile maiores de 40 anos: {homensCisTrans_mobile_maisQuarenta}. \r\n");
            Console.WriteLine($"Total de pessoas não binárias desenvolvedoras FullStack menores de 30 anos: {naoBinarios_fullStack_menosTrinta}. \r\n");
            Console.WriteLine($"Total de pessoas que responderam à pesquisa: {totalDePessoas}. \r\n");
            Console.WriteLine($"A média de idade das pessoas que responderam à pesquisa: {totalIdade / totalDePessoas}. \r\n");
        }
    }
}