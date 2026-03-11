Random random = new Random();
int diasParaVencimento = random.Next(12);
int descontoPercentual = 0;

if (diasParaVencimento == 0)
{
    Console.WriteLine("Sua assinatura expirou.");
}
else if (diasParaVencimento == 1)
{
    Console.WriteLine("Sua assinatura expira em um dia!");
    descontoPercentual = 20;
}
else if (diasParaVencimento <= 5)
{
    Console.WriteLine($"Sua assinatura expira em {diasParaVencimento} days.");
    descontoPercentual = 10;
}
else if (diasParaVencimento <= 10)
{
    Console.WriteLine($"Sua assinatura expira em {diasParaVencimento} days.");
    Console.WriteLine("Sua assinatura expirará em breve. Renove agora!");
}

if (descontoPercentual > 0)
{
    Console.WriteLine($"Renove agora e economize {descontoPercentual}%.");
} 
