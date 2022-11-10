
using Back_End_ER02.Interfaces;
namespace Back_End_ER02.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {
        public string? cpf { get; set; }

        public DateTime dataNasc { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento<=1500)
            {
                return 0;
            } else if (rendimento > 1500 &&rendimento <=3500)
            {
                float resultado = (rendimento/100) * 1.5f;
                return resultado;
            } else 
            {
                float resultado = (rendimento/100) * 5;
                return resultado;
            }
   
        }

        public bool ValidarDataNasc (DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double idade = (dataAtual - dataNasc).TotalDays / 365;
            Console.WriteLine(idade);

            if(idade>=18)
            {
                return true;

            } else
            {
                return false;
            }
            
        }

        public bool ValidarDataNasc (string dataNasc)
        {
            if (DateTime.TryParse(dataNasc, out DateTime dataConvert))
            {
                DateTime dataAtual = DateTime.Today;
                double idade = (dataAtual - dataConvert).TotalDays/365;
                Console.WriteLine(idade);

                if(idade >= 18)
                {
                    return true;

                } else return false;
            }

            return false;
        }

        internal bool ValidarDataNasc(object dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}