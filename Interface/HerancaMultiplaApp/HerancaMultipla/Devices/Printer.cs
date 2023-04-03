﻿
namespace HerancaMultipla.Devices
{
    class Printer : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing:" + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }
    }
}
