namespace Aula27;

public class Program
{
    public static void Main()
    {
        //Instância da classe
        Cake cakeChocolate = new Cake("Chocolate" , "Coco" , "Chocolate" , 3 , "Médio");
        Cake cakeMorango = new Cake("Morango", "Coco","Chocolate", 3,"Pequeno");

        Console.WriteLine("-----------------------");
        Console.WriteLine("Criação da Lista");

        List<Cake> cakeList = new List<Cake>();
        cakeList.Add(cakeChocolate);
        cakeList.Add(cakeMorango);

        foreach(Cake cake in cakeList)
        {
            Console.WriteLine($"Sabor: {cake.Flavor} ");
            Console.WriteLine($"Recheio: {cake.Filling} ");
            Console.WriteLine($"Cobertura: {cake.Coverage} ");
            Console.WriteLine($"Camadas: {cake.Layers} ");
            Console.WriteLine($"Tamanho: {cake.Size} ");
            Console.WriteLine("\n------------------------");
        }

        /*Console.WriteLine($"Sabor: {cakeChocolate.Flavor} ");
        Console.WriteLine($"Recheio: {cakeChocolate.Filling} ");
        Console.WriteLine($"Cobertura: {cakeChocolate.Coverage} ");
        Console.WriteLine($"Camadas: {cakeChocolate.Layers} ");
        Console.WriteLine($"Tamanho: {cakeChocolate.Size} ");*/
    }
}
