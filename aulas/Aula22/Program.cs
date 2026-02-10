
using System.Data.Common;

namespace Aula22;

public class Program
{
    //Aplicação de Console - Ela vai começar aqui
    public static void Main()
    {
        //1. Instância (objeto) da classe Cake - new
        var cakeStrawberry = new Cake();

        //2. Setar as informações do nosso bolo de morango
        cakeStrawberry.Id = 472;
        cakeStrawberry.Name = "Bolo de morango Recheado";
        cakeStrawberry.Description = "Intolerantes a lactose, não consumir";
        cakeStrawberry.Value = 30;
        cakeStrawberry.isFilling = true;

        //3. Mostrar ao usuário
        Console.WriteLine("Id: " + cakeStrawberry.Id);
        Console.WriteLine("Nome: " + cakeStrawberry.Name);
        Console.WriteLine("Descrição: " + cakeStrawberry.Description);
        Console.WriteLine("Valor: R$ " + cakeStrawberry.Value);
        Console.WriteLine("É recheado?: " + cakeStrawberry.isFilling);

        Console.WriteLine("-----------------------");

        //-------------------------------------
        //4. Instância de Bolo de Chocolate
        var cakeChocolate = new Cake();

        cakeChocolate.Id = 472;
        cakeChocolate.Name = "Bolo de Chocolate";
        cakeChocolate.Description = "Intolerantes a lactose, não consumir";
        cakeChocolate.Value = 30;
        cakeChocolate.isFilling = false;

        Console.WriteLine("Id: " + cakeChocolate.Id);
        Console.WriteLine("Nome: " + cakeChocolate.Name);
        Console.WriteLine("Descrição: " + cakeChocolate.Description);
        Console.WriteLine("Valor: R$ " + cakeChocolate.Value);
        Console.WriteLine("É recheado?: " + cakeChocolate.isFilling);

        //----------------------------
        //5. Lista de Bolos
        Console.WriteLine("-----------------------");
        Console.WriteLine("Criação da Lista");

        List<Cake> cakeList = new List<Cake>();
        cakeList.Add(cakeChocolate);
        cakeList.Add(cakeStrawberry);

        //6. Vizualizar 
        foreach (Cake cake in cakeList) // Uma instrução de repetição (foreach (var item in colecao)) para percorrer coleções.
        {
            Console.WriteLine("Id: " + cake.Id);
            Console.WriteLine("Nome: " + cake.Name);
            Console.WriteLine("Descrição: " + cake.Description);
            Console.WriteLine("Valor: R$ " + cake.Value);
            Console.WriteLine("É recheado?: " + cake.isFilling);
            Console.WriteLine("-------------------------------");

        }
        


    }
}