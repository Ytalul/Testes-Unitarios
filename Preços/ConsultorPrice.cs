using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preços
{
    public class ConsultorPrice : IConsultorPrice
    {
        public readonly decimal Price;
        public ConsultorPrice(decimal price)
        {
            Price = price;

        }
        public bool Consultar(decimal price) 
        {
            // usa recurso das americanas e se for menor que 100 retorna true ,
            bool CAmazon = ConsultarAmazon(Price);
            bool CCB = ConsultarCB(Price);
            bool CAB = ConsultarAirBNB(Price);
            if (CAmazon == true && CCB == true && CAB == true)
            {
                return true;
            }
            return false;
        }

        // Consulta em mais dois sites se é barato (abaixo de 100)
        private bool ConsultarAmazon(decimal price)
        {
            return true;
        }

        private bool ConsultarCB(decimal price)
        {
            return true;
        }

        private bool ConsultarAirBNB(decimal price)
        {
            return true;
        }



        public bool TemTaxaEntrega(int id)
        {
            if (ConsultarAmericanas(id) == true) return true;
            else return false;
        }

        private bool ConsultarAmericanas(int id)
        {
            // consome uma api e retorna true se tiver taxa
            return true;
        }

    }
}
