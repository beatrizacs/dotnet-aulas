namespace Aula25;

public class BankTerminal
{
    //Instancia da classe BankOperation
    BankOperations bank = new BankOperations();

    public void Start()
    {
        var inExecution = true;

        while(inExecution)
        {
            DisplayMenu();
            string option = Console.ReadLine();

            if(option == "1")
            {
                bank.CheckBalance();
            }
            else if(option == "2")
            {
                bank.Deposit();
            }
            else if(option == "3")
            {
                bank.WithDraw();
            }
            else if(option == "4")
            {
                inExecution = false;
                Console.WriteLine("Volte Sempre!");
            }
            else
            {
                Console.WriteLine("Operação inválida. Tente novamente");
            }

        }
    }
    public void DisplayMenu()
    {
        Console.WriteLine("=======Bank========");
        Console.WriteLine("1- Checar Saldo");
        Console.WriteLine("2- Déposito");
        Console.WriteLine("3- Saque");
        Console.WriteLine("4- Sair");
    }
}