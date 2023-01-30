using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preços
{
    public interface IConsultorPrice
    {
        bool Consultar(decimal valor);
        bool TemTaxaEntrega(int id);
    }
}
