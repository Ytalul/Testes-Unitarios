using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ValidadorCreditoFake : IValidadorCredito
    {
        public bool TemTaxa(string cep)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCredito(string cpf)
        {
            return true;

        }
    }
}
