namespace Aula19;
using System.IO;

public class Program
{
    public static void Main()
    {
        //1. Estrutura
        string path = @"C:\Users\Ana Silva\beatriz\repos\aulas\Aula19\";
        string fileName = "Shopping_list.txt";
        string filePath = path + fileName;

        List<string> shoppingList = new List<string>();
        
        //2. Lógica
        if(File.Exists(filePath))
        {
            shoppingList.AddRange(File.ReadAllLines(filePath));
        }

        while (true)
        {
            Console.WriteLine("\n=== Lista de Compras ===");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Exibir a lista");
            Console.WriteLine("4. Limpar a lista");
            Console.WriteLine("5. Exportar lista para .txt");
            Console.WriteLine("Escolha um número para continuar");

            string choiceUser = Console.ReadLine();

            switch(choiceUser)
            {
                case "1":
                    Console.WriteLine("Digite o nome do item para adicionar: ");
                    string itemInsert = Console.ReadLine();
                    
                    if(!string.IsNullOrEmpty(itemInsert))
                    {
                        shoppingList.Add(itemInsert);
                        Console.WriteLine($"O item '{itemInsert}' foi adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("O item não pode ser vazio!");
                    }
                break;

                case "2":
                    Console.WriteLine("Digite o nome do item para remover: ");
                    string itemRemove = Console.ReadLine();

                    if(shoppingList.Remove(itemRemove))
                    {
                        Console.WriteLine($"Item '{itemRemove}' Removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Item '{itemRemove}' não encontrado!");
                    }

                break;

                case "3":
                    Console.WriteLine("\n Itens na sua lista de Compra");

                    if(shoppingList.Count == 0)
                    {
                        Console.WriteLine("Sua lista está vazia!");
                    }
                    else
                    {
                        for(int i = 0; i < shoppingList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                        } 
                    }
                break;

                case "4": // Fiz sozinha
                    Console.WriteLine("Deseja realmente apagar");
                    string sorN = Console.ReadLine();
                    if(sorN == "sim")
                    {
                        shoppingList.Clear();
                    }
                break;

                case "5":
                    File.WriteAllLines(filePath, shoppingList);
                    Console.WriteLine("Lista salva com sucesso! Saindo... ");
                    return; //pra acabar aqui
                
                default:
                    Console.WriteLine("Opção invalida. Tente novamente");
                break;

                

            }

        }
    }
}

