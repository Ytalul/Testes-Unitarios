namespace Banco
{
    public class ContaBancaria
    {
        public int saldo;
        public string CPF;

        public ContaBancaria(int valor, string cpf)
        {
            this.saldo = valor;
            this.CPF = cpf;
        }

        public bool Saque(int valorParaSacar)
        {
            if ( saldo < valorParaSacar)
            {
                return false;
            }
            else
            {
                saldo = saldo - valorParaSacar;
                return true;
            }
        }

        public bool Depositar(int valorDepositado)
        {
            saldo = saldo+ valorDepositado;
            return true;
        }

    }
}