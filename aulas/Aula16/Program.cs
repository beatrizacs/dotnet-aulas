namespace Aula16;

public class Program
{
    public static void Main()
    {
        string separator = "----------------------------";

        //1. Declaração de Array inicializando com valores
        string[] fruits = {"Maçã","Banana","Manga","Caju"};
        
        Console.WriteLine(separator);

        //2. Acessar os valores
        Console.WriteLine(fruits[0]);

        Console.WriteLine(separator);

        //2.1 Acessar os valores
        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //3. Contagem de Índices
        Console.WriteLine("Quantidade de índices: " + fruits.Length);

        Console.WriteLine(separator);

        //4. Alterar os valores
        Console.WriteLine("Valor antes da alteração: " + fruits[1]);
        fruits[1] = "Abacaxi";
        Console.WriteLine("Valor depois da alteração: " + fruits[1]);

        Console.WriteLine(separator);

        //5. Declaração sem inicializar
        int[] numbers = new int[5];
        
        numbers[0]=10;

         foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}