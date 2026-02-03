using System.Security.Cryptography.X509Certificates;

namespace Aula06;

public class Program
{
    public static void Main()
    {
       Console.WriteLine("==========Verificador de números pares ou ímpares==========");
       Console.WriteLine("Digite um número: ");
       int number = Convert.ToInt32(Console.ReadLine());

       int result = number % 2;
       
       if(result == 0)
        {
            Console.WriteLine("O número digitado é par!");
        }
        else
        {
            Console.WriteLine("O número digitado é ímpar!");
        }

       
    }
}

/*
 Console.WriteLine("Digite a sua idade:");
       int age = Convert.ToInt32(Console.ReadLine());

       if(age>18)
        {
            Console.WriteLine("Você é maior de idade!");
        }
*/