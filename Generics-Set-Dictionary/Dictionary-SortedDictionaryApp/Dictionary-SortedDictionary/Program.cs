
//Implementando cookies

Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "11987540976";
cookies["phone"] = "11945632309";

//Como não é permitido repetições, o valor é subescrito

Console.WriteLine(cookies["email"]);
Console.WriteLine(cookies["phone"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
    Console.WriteLine("email");
else
    Console.WriteLine("Não contém este dado.");

Console.WriteLine("Size: " + cookies.Count);



Console.WriteLine("All cookies: ");
foreach(KeyValuePair<string, string> item in cookies)
    Console.WriteLine(item.Key + "=" + item.Value);