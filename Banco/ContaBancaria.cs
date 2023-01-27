
namespace Banco
{
    public class ContaBancaria
    {
        public int saldo { get; set; }
        public string CPF { get; set; }

        public ContaBancaria(int valor, string cpf)
        {
            this.saldo = valor;
            this.CPF = cpf;
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

    }
}