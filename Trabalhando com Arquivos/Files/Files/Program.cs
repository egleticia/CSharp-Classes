using System.IO;

string sourcePath = @"c:\Projetos Studio\CSharp-Classes\Trabalhando com Arquivos\File1.txt";
string targetPath = @"c:\Projetos Studio\CSharp-Classes\Trabalhando com Arquivos\File2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath);

    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}

catch (IOException e)
{
    Console.WriteLine("An error occurred.");
    Console.WriteLine(e.Message);
}