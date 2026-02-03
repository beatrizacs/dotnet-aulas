namespace Aula04;

public class Program
{
    
    public static void Main()
    {
        Console.WriteLine("----Cadastro de usuários----");

        //Solicitar o nome do usuário
        Console.WriteLine("Digite seu nome: ");
        string name = Console.ReadLine();

        // Solicitar a idade do usuário
        Console.WriteLine("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("--------------------------");

        Console.WriteLine("Nome do usuário: " + name);
        Console.WriteLine("Idade do usuário: " + age);

    }
}