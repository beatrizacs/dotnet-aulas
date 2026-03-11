//string[] IDsEncomendasFraudulentas = new string[3];

//IDsEncomendasFraudulentas[0] = "A123";
//IDsEncomendasFraudulentas[1] = "B123";
//IDsEncomendasFraudulentas[2] = "C123";
//IDsEncomendasFraudulentas[3] = "D000";

string[] IDsEncomendasFraudulentas = { "A123", "B456", "C789" };

Console.WriteLine($"Primeiro: {IDsEncomendasFraudulentas[0]}");
Console.WriteLine($"Segundo: {IDsEncomendasFraudulentas[1]}");
Console.WriteLine($"Terceiro: {IDsEncomendasFraudulentas[2]}");

IDsEncomendasFraudulentas[0] = "F000"; // teste

Console.WriteLine($"Atribuir primeiro: {IDsEncomendasFraudulentas[0]}");
Console.WriteLine($"Existem {IDsEncomendasFraudulentas.Length} encomendas fraudulentas para processar.");