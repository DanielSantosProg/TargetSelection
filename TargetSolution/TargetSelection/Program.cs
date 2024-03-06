int opcao;

try
{
    while (true)
    {
        Console.WriteLine("\nMenu de questões");
        Console.WriteLine("Digite:\n1-Questão 1\t2-Questão 2\t3-Questão 3\t4-Questão 4\t5-Questão 5");
        Console.WriteLine("Ou digite qualquer outro numero para encerrar.");
        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Questao1();
                break;
            case 2:
                Questao2();
                break;
            case 3:
                Questao3();
                break;
            case 4:
                Questao4();
                break;
            case 5:
                Questao5();
                break;
            default:
                Console.WriteLine("Programa encerrado");
                return;
        }
    }
}
catch (FormatException ex)
{
    Console.WriteLine("\nDigite um número inteiro.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("\nHouve um erro.");
    Console.WriteLine($"Mensagem: {ex.Message}");
}

static void Questao1()
{
    Console.WriteLine("\nQuestão 1 resposta:");
    Console.WriteLine("Soma = 91");
}

static void Questao2()
{
    Console.WriteLine("\nQuestão 2 resposta:");

        int numInput = 0;
        var listNum = new List<int>();

        try
        {
            Console.WriteLine("Cálculo da sequência de Fibonacci.\nDigite um número para fazer o cálculo de Fibonacci.\n");
            numInput = Convert.ToInt32(Console.ReadLine());

            if (numInput < 0)
            {
                Console.WriteLine("Digite um número maior ou igual a 0.");
            }
            else
            {
                int num1 = 0, num2 = 1, numStorage;

                // Adiciona o primeiro número fora do loop
                listNum.Add(num1);

                while (num2 <= numInput)
                {
                    listNum.Add(num2);

                    numStorage = num1;
                    num1 = num2;
                    num2 = numStorage + num2;
                }
            }

            Console.WriteLine("\nNúmeros da sequência de Fibonacci:");
            foreach (int num in listNum)
            {
                Console.WriteLine(num);
            }
            if (listNum.Contains(numInput))
            {
                Console.WriteLine($"\nO número {numInput} está presente na sequência de Fibonacci");
            }
            else
            {
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Houve um erro.");
            Console.WriteLine($"Mensagem: {ex.Message}");

        }
}

static void Questao3()
{
    Console.WriteLine("\nQuestão 3 resposta:");
    Console.WriteLine("a) 1, 3, 5, 7, 9 - Somando 2.");
    Console.WriteLine("b) 2,4,8,16,32,64,128 - Dobro do número anterior.");
    Console.WriteLine("c) 0,1,4,9,16,25,36,49 - Quadrado dos números inteiros, começando do 0.");
    Console.WriteLine("d) 4,16,36,64,100 - Quadrado dos número pares, começando do 2.");
    Console.WriteLine("e) 1,1,2,3,5,8,13 - Sequência de Fibonacci.");
}
static void Questao4()
{
    Console.WriteLine("\nQuestão 4 resposta:");
    Console.WriteLine("Sem resposta...");
}
static void Questao5()
{
    Console.WriteLine("\nQuestão 5 resposta:");

    Console.WriteLine("Escreva uma palavra.");
    string? palavra = Console.ReadLine();

    List<char> listChar = [.. palavra?.ToCharArray()];

    string palavraReversa = "";
    for (int i = listChar.Count - 1; i >= 0; i--)
    {
        palavraReversa += listChar[i];
    }

    Console.WriteLine(palavraReversa);
}
