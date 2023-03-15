

string path = @"c:\Projetos Studio\CSharp-Classes\Trabalhando com Arquivos\File1.txt";

FileStream fs = null;
StreamReader sr = null;

try
{
    fs = new FileStream(path, FileMode.Open);
    sr = new StreamReader(fs);
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred.");
    Console.WriteLine(e.Message);
}

// finaly para fechar as streams, independente de ter dado certo ou não.
finally
{
    if (sr != null) sr.Close();
    if (fs != null) fs.Close();
}