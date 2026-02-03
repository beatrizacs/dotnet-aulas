namespace Aula17;

public class Program
{
    public static void Main()
    {
        string separator = "-----------------------------";
        //1. Declaração com inicialização de valores
        List<string> fruits = new List<string>()
        {
          "Manga",
          "Banana",
          "Uva",
          "Maçã"  
        };
        //2. Acessar os valores
        Console.WriteLine(fruits[2]);

        Console.WriteLine(separator);

         foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        //3. Adicionar elementos
        fruits.Add("Limão");
        fruits.Add("Laranja");
        fruits.Add("Maracujá");

        Console.WriteLine(separator);

        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //4. Remover elementos
        fruits.Remove("Limão");

         foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //5. Contagem de elementos
        Console.WriteLine("Quantidade de frutas: " + fruits.Count);

        Console.WriteLine(separator);

        //6. Modificar um elemento
        fruits[4] = "Abacate";

         foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //7. Limpar a lista
        fruits.Clear();

         foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //8. declarar sem inicializar
        List<int> numbers = new List<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }


    } 
}