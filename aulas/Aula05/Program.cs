namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("========Calculadora Simples========");

        //Solicitar o primeiro numero
        Console.WriteLine("Digite o primeiro valor : ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        //Segundo valor
        Console.WriteLine("Digite o segundo valor : ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        //int number1 = 10;
        //int number2 = 20;

        Console.WriteLine("========Resultados========");

        int sum = number1 + number2;
        int subtraction = number2 - number1;
        int mutiplication = number1 * number2;
        double division = (double)number2 / number1;
        int module = number2 % number1;

        Console.WriteLine("O valor da soma é: " + sum );
        Console.WriteLine("O valor da subtração é: " + subtraction );
        Console.WriteLine("O valor da multiplicação é: " + mutiplication );
        Console.WriteLine("O valor da divisão é: " + division );
        Console.WriteLine("O valor do resto da divisão é: " + module );
    }

}