namespace Aula24;
public class Program
{
    public static void Main()
    {
        //1. Criar instância da Classe Person
        Person person = new Person();

        //2. Métodos - Simplificar as Classes
        Console.WriteLine("Digite seu nome:");
        string name = Console.ReadLine();

        Console.WriteLine("\nDigite uma idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        string response = person.IfLegalPersonRefactor(age, name);
        Console.WriteLine(response);

    }
}

/*var IfLegalPerson = person.IfLegalPerson(age);

       if(IfLegalPerson == true)
        {
            Console.WriteLine("A pessoa é maior de idade");
        }
        else
        {
            Console.WriteLine("A pessoa é menor de idade");
        }*/