


string path = @"c:\Projetos Studio\CSharp-Classes\Trabalhando com Arquivos\myfolder\File1.txt";

Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
Console.WriteLine("PathSeparator: " + Path.PathSeparator);
Console.WriteLine("GetFileName: " + Path.GetFileName(path));
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
Console.WriteLine("GetExtension: " + Path.GetExtension(path));
Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
Console.WriteLine("GetTempPath: " + Path.GetTempPath());
