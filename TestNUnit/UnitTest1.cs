using Banco;
using NUnit.Framework;

namespace ContaTest.NUnit
{
    [TestFixture]
    public class TesteNUnit
    {

        [Test]
        public void SaqueValido()
        {
            // Arrange
            ContaBancaria Conta = new ContaBancaria(200, "0001");
            // Action
            bool Valido = Conta.Saque(100);
            // Assert
            Assert.IsTrue(Valido);
        }

        [Test]
        public void SaqueInvalido()
        {
            ContaBancaria Conta = new ContaBancaria(150 , "0036");
            bool ResultadoFalse = Conta.Saque(200);
            Assert.IsFalse(ResultadoFalse);
        }

        [Test]
        public void TesteDeposito()
        {
            ContaBancaria Conta = new ContaBancaria(100 , "0001");
            bool Resultado = Conta.Depositar(500);
            Assert.IsTrue(Resultado);
        }

    }
}