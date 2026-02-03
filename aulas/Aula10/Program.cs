using System.Xml.XPath;

namespace Aula10;

public class Program
{
    public static void Main()
    {
        bool varContinue = true;

        while(varContinue)
        {
             //Inicialização do Programa
        Console.WriteLine("\n      Calculadora Simples \n");
        Console.WriteLine("Digite o Primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o Segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        //Selecionar o tipo de operação
        Console.WriteLine("\nEscolha uma operação");
        Console.WriteLine("1. Adição (+)");
        Console.WriteLine("2. Subtração (-)");
        Console.WriteLine("3. Multiplicação (*)");
        Console.WriteLine("4. Divisão (/)");
        Console.WriteLine("Digite o numero da operação: ");
        int operation = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        //Condições
        if(operation == 1)
        {
           result = num1 + num2;
        }
        else if(operation == 2)
        {
            result = num1 - num2;
        }
        else if(operation == 3)
        {
            result = num1 * num2;
        }
        else if(operation == 4)
        {
            if(num2 != 0 )
            {
                result = num1 / num2;
            }

            else
            {
                Console.WriteLine("Não é possivel dividir um número por zero");
            }
        }
        else
        {
            Console.WriteLine("\nOperação inválida: ");
        }

        Console.WriteLine("\nO resultado é: " + result);

        Console.WriteLine("\nDeseja realizar outra operação (s/n) ?");
        string response = Console.ReadLine();

        if(response != "s")
            {
                varContinue = false;
            }

        }

        Console.WriteLine("Obrigado por utilizar a calculadora");
    }
}