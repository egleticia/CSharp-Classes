
using System.Reflection.Metadata.Ecma335;

namespace HerancaMultipla.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
