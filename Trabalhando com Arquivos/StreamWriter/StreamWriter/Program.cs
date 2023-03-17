
string sourcePath = @"c:\Projetos Studio\CSharp-Classes\Trabalhando com Arquivos\File1.txt";
string targetPath = @"c:\Projetos Studio\CSharp-Classes\Trabalhando com Arquivos\File2.txt";


try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}

catch (IOException e)
{
    Console.WriteLine("An error occurred.");
    Console.WriteLine(e.Message);
}