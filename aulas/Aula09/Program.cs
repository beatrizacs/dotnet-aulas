using System.Security.AccessControl;

namespace Aula09;

public class Program
{
    
    public static void Main()
    {
        Console.WriteLine("==========Operadores Lógicos=========");

        bool isLogged = true;
        bool hasAdminAcess = false;

        Console.WriteLine("\nInformações do Usuário: ");
        Console.WriteLine("Usuário logado: " + isLogged);
        Console.WriteLine("Acesso ao painel de administrador: " + hasAdminAcess);

        Console.WriteLine("\nPermisões");

        //Operador (||) - OU
        if(isLogged || hasAdminAcess)
        {
            Console.WriteLine("Acesso ao sistema concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao sistema negado");
        }

        //Operador (&&) - E
        if( isLogged && hasAdminAcess)
        {
            Console.WriteLine("Acesso ao painel de administrador concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao painel de administrador negado");
        }

        //Operador de negaçao (!) - "Não..."
        if(!isLogged)
        {
            Console.WriteLine("Usuário não está logado");
        }
        else
        {
            Console.WriteLine("Usuário está logado");
        }


    }
}