

namespace HerancaMultipla.Devices
{
    class Scanner : Device, IScanner
    {
        // implementação do método Device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing:" + document);
        }

        // implementação do método de IScanner
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
