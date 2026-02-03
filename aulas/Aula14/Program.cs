using System.Text.Json;

namespace Aula14;

public class Program
{
    public static void Main()
    {
        //ex1:
        //for(int i = 1; i<=10; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //ex2:
        Console.WriteLine("==========Tabela de Multiplicação==========");
        for(int i = 1; i<=10; i++)
        {
            for(int j = 1; j<= 10; j++)
            {
                Console.Write($"{i * j,6}");
            }

        }


    }
}

//int i -> condição 1 é executada (uma única vez) antes da execução do bloco de código
//i<=10 -> condição 2 define a condição para executar o bloco de código
//i++ -> condição 3 é executada (todas as vezes) após o bloco de código ter sido executado