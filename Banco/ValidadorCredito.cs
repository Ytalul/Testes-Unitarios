using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ValidadorCredito : IValidadorCredito
    {

        public bool ValidarCredito(string cpf)
        {
            bool StatusSerasa = ValidarSerasa(cpf);
            bool StatusSpc = ValidarSPC(cpf);

            if ( StatusSerasa == true && StatusSpc== true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidarSerasa(string cpf)
        {

            // WebService do serasa consultar o nome e se for limpo retorna true
            return true;

        }

        private bool ValidarSPC(string cpf) 
        { 
            // WebService do SPC consultar o nome e se for limpo retorna true
            return true; 
        }


        public bool TemTaxa(string cep)
        {
            // Consumir api dos correios e se for mais de 100 km return true 
            return true;
        }

    }
}
