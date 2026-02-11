namespace Aula23;

public class Program
{
    public static void Main()
    {
        //1. Criar a instância bank
        var bankLay = new Bank();
        bankLay.Name = "Banco Lay";
        bankLay.Id = 234;

        //2. Métodos da instancia da class bank
        bankLay.RequestNewCard();
    } 
}