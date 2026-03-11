int[] inventario = { 200, 450, 700, 175, 250 };
int soma = 0;
int caixa = 0;

foreach (int itens in inventario)
{
    soma += itens;
    caixa++;
    Console.WriteLine($"caixa {caixa} = {itens} itens (Total acumulado: {soma})");
}

Console.WriteLine($"\nNós temos {soma} itens em estoque.");