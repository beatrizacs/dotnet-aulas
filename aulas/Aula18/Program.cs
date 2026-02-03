namespace Aula18;
using System.IO;

public class Program
{
    public static void Main()
    {
        //1. Criar um arquivo
        //System.IO.File.WriteAllText("file.txt","Hello word");

        //Console.WriteLine("Arquivo criado com sucesso.");

        //2. Criar arquivo em local específico
        //string path = @"C:\Users\Ana Silva\beatriz\repos\aulas\Aula18\bin\Debug\net8.0\FileName.txt";
        //string content = "Oi Mundo";

        //File.WriteAllText(path , content);

        //3. Criar um arquivo Word

        //string path = @"C:\Users\Ana Silva\beatriz\repos\aulas\Aula18\bin\Debug\net8.0\";
        //string FileName = "document.Doc";
        //string FilePath = path + FileName;

        //string content = "Oi Mundo";

        //File.WriteAllText(FilePath, content);

        //Console.WriteLine("Criado com Sucesso");

        //4. Inserir um parágrafo em um arquivo

        string path = @"C:\Users\Ana Silva\beatriz\repos\aulas\Aula18\bin\Debug\net8.0\";
        string FileName = "FileName.txt";
        string FilePath = path + FileName;

        //string additionalcontent = " | Curso de c# e .NET";

        //File.AppendAllText(FilePath, additionalcontent);

        //Console.WriteLine("Atualizado com Sucesso");
        
        //5. Ler o arquivo
        string fileContent = File.ReadAllText(FilePath);
        Console.WriteLine("Conteúdo do Arquivo: " + fileContent);




    }
}