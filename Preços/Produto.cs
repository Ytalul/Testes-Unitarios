using System.Linq.Expressions;

namespace Preços
{
    public class Produto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Nome { get; set; }
        public IConsultorPrice Consultor { get; set; }


        public Produto(int id, decimal price, string nome)
        {
            Id = id;
            Price = price;
            Nome = nome;
        }

        public bool StatusPrice()
        {
            // preciso ir nas americanas consultar
            bool EhBarato = Consultor.Consultar(this.Price);
            if ( EhBarato == true)
            {
                return true;
            }
            else { return false; }
        }

        public bool TemTaxaEntrega(int id)
        {
            bool TemTaxa = false;
            try
            {
                TemTaxa = Consultor.TemTaxaEntrega(id);
            }
            catch (ArgumentNullException)
            {
                return false;
            }
            
            if (TemTaxa == true) return true;
            else return false;
        }

    }
}