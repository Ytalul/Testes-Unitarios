using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public interface IValidadorCredito
    {
        public bool ValidarCredito(string cpf);

        public bool TemTaxa(string cep);
    }
}
