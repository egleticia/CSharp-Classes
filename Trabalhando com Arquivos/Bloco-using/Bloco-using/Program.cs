
string path = @"c:\Projetos Studio\CSharp-Classes\Trabalhando com Arquivos\File1.txt";


// executa o que está no bloco e após executar é automaticamente fechado

try
{


    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }

}

catch (IOException e)
{
    Console.WriteLine("An error occurred.");
    Console.WriteLine(e.Message);
}
