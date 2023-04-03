
namespace HerancaMultipla.Devices
{
    class Printer : Device, IPrinter
    {
        // implementação do método Device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing:" + document);
        }

        // implementação do método de IPrinter
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
