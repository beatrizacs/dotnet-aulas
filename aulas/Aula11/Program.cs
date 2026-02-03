namespace Aula11;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("=========Dia da Semana=========");
        Console.WriteLine("Digite um número de 1 a 7:");
        int dayOfweek = Convert.ToInt32(Console.ReadLine());

        switch(dayOfweek)
        {
            case 1:
            //possivel colocar case 2: > e continua...
               Console.WriteLine("O dia da semana é Segunda-feira");
               break;
            
            case 2:
               Console.WriteLine("O dia da semana é Terça-feira");
               break;

            case 3:
               Console.WriteLine("O dia da semana é Quarta-feira");
               break;

            case 4:
               Console.WriteLine("O dia da semana é Quinta-feira");
               break;

            case 5:
               Console.WriteLine("O dia da semana é Sexta-feira");
               break;

            case 6:
               Console.WriteLine("O dia da semana é Sábado");
               break;

            case 7:
               Console.WriteLine("O dia da semana é Domingo");
               break;
            
            default:
                Console.WriteLine("Dia inválido");
                break;
              
        }
    }
}

/*int number = 1;

        switch (number)
        {
            case 1:
            Console.WriteLine("O número é 1");
            break;

            case 2:
            Console.WriteLine("O número é igual a 2");
            break;
             
        }*/

        // > Quando tiver valores fixos, usar o Switch!