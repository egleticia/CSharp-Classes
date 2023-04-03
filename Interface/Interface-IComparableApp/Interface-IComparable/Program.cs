using Interface_IComparable.Entities;

//string path = @"c:\Projetos Studio\CSharp-Classes\Interface\in.txt";

//try
//{
//    using (StreamReader sr = File.OpenText(path))
//    {
//        List<string> list = new List<string>();
//        while (!sr.EndOfStream)
//        {
//            list.Add(sr.ReadLine());
//        }
//        list.Sort();
//        foreach(string s in list)
//        {
//            Console.WriteLine(s);
//        }
//    }
//}


//catch (IOException e)
//{
//    Console.WriteLine("An error occurred");
//    Console.WriteLine(e.Message);
//}


string path = @"c:\Projetos Studio\CSharp-Classes\Interface\on.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee> list = new List<Employee>();
        while (!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine()));
        }
        list.Sort();
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp);
        }
    }
}


catch (IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
