
namespace Exercicio_Metodo_Abstrato.Entities
{
    class PessoaJuridica : TaxPayer
    {
        public double NumeroFuncionarios { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, double numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalculoRenda()
        {
            if (NumeroFuncionarios <= 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }


        }
    }
}
