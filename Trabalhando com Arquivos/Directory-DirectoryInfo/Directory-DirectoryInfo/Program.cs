
string path = @"c:\Projetos Studio\CSharp-Classes\Trabalhando com Arquivos\myfolder";


try
{
   var folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

    Console.WriteLine("FOLDERS: ");

    foreach (string s in folders)
    {
        Console.WriteLine(s);
    }

}
catch (IOException e)
{
    Console.WriteLine("An error eccurred.");
    Console.WriteLine(e.Message);
}

Directory.CreateDirectory(@"c:\Projetos Studio\CSharp-Classes\Trabalhando com Arquivos\myfolder\newfolder");
//Directory.CreateDirectory(path + @"\newfolder");

try
{
    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

    Console.WriteLine("FILES: ");

    foreach (string s in files)
    {
        Console.WriteLine(s);
    }

}
catch (IOException e)
{
    Console.WriteLine("An error eccurred.");
    Console.WriteLine(e.Message);
}