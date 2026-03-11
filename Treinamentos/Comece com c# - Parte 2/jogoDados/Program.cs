Random Dados = new Random();

int rodada1 = Dados.Next(1,7);
int rodada2 = Dados.Next(1,7);
int rodada3 = Dados.Next(1,7);

int total = rodada1 + rodada2 + rodada3;

Console.WriteLine($"Lançamento de dados: {rodada1} + {rodada2} + {rodada3} = {total}");

if ((rodada1 == rodada2) || (rodada2 == rodada3) || (rodada1 == rodada3))
{
    if ((rodada1 == rodada2) && (rodada2 == rodada3))   
    {
    Console.WriteLine("Você tirou um trio! +6 de bônus no total!");
    total += 6;
    }
    else
    {
    Console.WriteLine("Você tirou um par! +2 de bônus no total!");
    total += 2;
    }   
}

if (total >= 16)
{
    Console.WriteLine("Você ganhou um carro novo!");
}
else if (total >= 10)
{
    Console.WriteLine("Você ganhou um novo laptop!");
}
else if (total == 7)
{
    Console.WriteLine("Você ganhou uma viagem para duas pessoas!");
}
else
{
    Console.WriteLine("Você ganhou um gatinho!");
}
