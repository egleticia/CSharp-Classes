using System;


namespace ExecicioFixacao_Excecoes.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
