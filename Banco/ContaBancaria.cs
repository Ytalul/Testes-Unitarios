
namespace Banco
{
    public class ContaBancaria
    {
        public int saldo { get; set; }
        public string CPF { get; set; }
        public string cep { get; set; }
        public IValidadorCredito ValidarCred;

        public IValidadorCredito TeraTaxa;


        public int GetSaldo()
        {
            return saldo;
        }

        public ContaBancaria(int valor, string cpf, string cep)
        {
            this.saldo = valor;
            this.CPF = cpf;
            this.cep = cep; 
        }

        public bool Saque(int valorParaSacar)
        {
            if (saldo < valorParaSacar)
            {
                return false;
            }
            else if (valorParaSacar < 0)
            {
                return false;
            }
            else if (valorParaSacar == 0)
            {
                Thread.Sleep(2000);
                throw new ArgumentOutOfRangeException("Valor invalido");
            }
            else
            {
                saldo = saldo - valorParaSacar;
                return true;
            }
        }

        public bool Depositar(int valorDepositado)
        {
            saldo = saldo + valorDepositado;
            return true;
        }

        public void SetValidador(IValidadorCredito validador)
        {
            this.ValidarCred = validador;
        }

        public bool SolicitarEmprestimo(int valor)
        {

            bool Validador = ValidarCred.ValidarCredito(this.CPF);
            if ( Validador == true)
            {
                this.saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetClasseTemTaxa(IValidadorCredito validartaxa)
        {
            this.TeraTaxa = validartaxa;
            
        }

        public bool EntregarCartaoTemTaxa()
        {
            bool Tem = TeraTaxa.TemTaxa(this.cep);
            if (Tem == true)
            {
                this.saldo -= 100;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}