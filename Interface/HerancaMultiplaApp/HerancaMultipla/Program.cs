
using HerancaMultipla.Devices;

// Problema do Diamante: causada pela herança múltipla, é uma ambiguidade causada pela existência do mesmo
// método em mais de uma superclasse. 

Printer p = new Printer()
{
    SerialNumber = 1080
};

p.ProcessDoc("My letter");
p.Print("My letter");


Scanner s = new Scanner()
{
    SerialNumber = 2003
};

s.ProcessDoc("My Email");
Console.WriteLine(s.Scan());