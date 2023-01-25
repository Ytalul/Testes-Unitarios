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
            ContaBancaria Conta = new ContaBancaria( 200, "0001");
            bool Valido = Conta.Saque(100);
            Assert.IsTrue(Valido);
        }

    }
}