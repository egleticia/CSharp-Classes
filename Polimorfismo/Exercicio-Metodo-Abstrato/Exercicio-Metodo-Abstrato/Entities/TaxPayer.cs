using System;

namespace Exercicio_Metodo_Abstrato.Entities
{
    abstract class TaxPayer
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public TaxPayer() { }

        public TaxPayer(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double CalculoRenda();
    }
}