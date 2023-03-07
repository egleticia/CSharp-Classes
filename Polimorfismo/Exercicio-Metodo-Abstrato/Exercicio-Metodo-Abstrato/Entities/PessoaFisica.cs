
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace Exercicio_Metodo_Abstrato.Entities
{
    class PessoaFisica : TaxPayer
    {
        public double GastosSaude { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double CalculoRenda()
        {
            double renda;
            double saude;
            double total;

            if (RendaAnual < 20000.00)
            {
                renda = RendaAnual * 0.15;
            }

        else
            {
                renda = RendaAnual * 0.25;
            }

            if (GastosSaude > 0)
            {
                saude = GastosSaude * 0.50;
            }
            
            else
            {
                saude = GastosSaude;
            }

            total = renda - saude;

            return total;

        }

    }
}
