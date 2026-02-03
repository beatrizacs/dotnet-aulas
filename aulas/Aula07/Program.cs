namespace Aula07;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=====Operadores de Atribuição=====");
        
        // Iniciar a Variável
        int x = 10;
        Console.WriteLine("\nValor inicial da variável de x:" + x );

        //Operador de atribuição simples (=)
        x = 20;
        Console.WriteLine("\nAtribuição simples (=)");
        Console.WriteLine("Valor de x: " + x);

        //Atribuição composta (incremento)
        x++; // Equivale x = x + 1

        Console.WriteLine("\nAtribuição composta incremento(++) = " + x);

        //Atribuição Composta (+=)
        x+=10; // x + 10 = x

        Console.WriteLine("\nAtribuição composta (+=) = "+ x);

        //Atribuição composta (-=)
        x-=6;

        Console.WriteLine("\nAtribuição composta (-=) = "+ x);

        //Atribuição composta (*=)
        x*=2;

        Console.WriteLine("\nAtribuição composta (*=) = "+ x);

        //Atribuição composta (/=)
        x/=2;

        Console.WriteLine("\nAtribuição composta (/=) = "+ x);

    }
}

